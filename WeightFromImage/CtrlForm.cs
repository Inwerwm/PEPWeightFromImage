using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.SDX;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WeightFromImage
{
    public partial class CtrlForm : Form
    {
        IPERunArgs args;
        IPXPmx pmx;

        Bitmap bitmap;
        Bitmap[] materialBmp;

        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
            Format();
        }

        public void Format()
        {
            pmx = args.Host.Connector.Pmx.GetCurrentState();
            listBoxMaterial.Items.Clear();
            listBoxMaterial.Items.Add("");
            listBoxMaterial.Items.AddRange(pmx.Material.Select(m => m.Name).ToArray());
            comboBoxBone.Items.AddRange(pmx.Bone.Select(b => b.Name).ToArray());
            materialBmp = new Bitmap[pmx.Material.Count];
        }

        private Bitmap ImageFileOpen()
        {
            //ファイルを開くダイアログボックスの作成  
            var ofd = new OpenFileDialog();
            //ファイルフィルタ  
            ofd.Filter = "Image File(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";
            //ダイアログの表示 （Cancelボタンがクリックされた場合は何もしない）
            if (ofd.ShowDialog() == DialogResult.Cancel) return null;

            try
            {
                return ImageFileOpen(ofd.FileName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Bitmap ImageFileOpen(string fileName)
        {
            // 指定したファイルが存在するか？確認
            if (File.Exists(fileName) == false) throw new FileNotFoundException();

            // 拡張子の確認
            var ext = Path.GetExtension(fileName).ToLower();

            // ファイルの拡張子が対応しているファイルかどうか調べる
            if (
                (ext != ".bmp") &&
                (ext != ".jpg") &&
                (ext != ".png") &&
                (ext != ".tif")
                )
            {
                throw new InvalidOperationException();
            }

            Bitmap bmp;

            // ファイルストリームでファイルを開く
            using (var fs = new FileStream(
                fileName,
                FileMode.Open,
                FileAccess.ReadWrite))
            {
                bmp = new Bitmap(fs);
            }
            return bmp;
        }

        private float V(float value) => value * bitmap.Height - (checkBoxDec.Checked ? 1 : 0);

        private float U(float value) => value * bitmap.Width - (checkBoxDec.Checked ? 1 : 0);

        Color GetPointColor(IPXVertex vertex)
        {
            int x = U(vertex.UV.U).Round();
            int y = V(vertex.UV.V).Round();
            Color pixel = bitmap.GetPixel(x, y);

            int selectedColor = 0;
            if (radioButtonPiR.Checked)
                selectedColor = pixel.R;
            if (radioButtonPiG.Checked)
                selectedColor = pixel.G;
            if (radioButtonPiB.Checked)
                selectedColor = pixel.B;
            if (radioButtonPiA.Checked)
                selectedColor = pixel.A;

            return Color.FromArgb(selectedColor, 0, 0);
        }

        Bitmap GetMeshImage(IPXMaterial material, bool withLine = true)
        {
            if (bitmap == null)
                return null;
            V2 Scale(V2 v)
            {
                return new V2(U(v.U), V(v.V));
            }
            Rectangle VertexSquare(V2 vertex, int size)
            {
                Rectangle square = new Rectangle();
                square.X = (int)Math.Round(U(vertex.U) - (size - 1) / 2, MidpointRounding.AwayFromZero);
                square.Y = (int)Math.Round(V(vertex.V) - (size - 1) / 2, MidpointRounding.AwayFromZero);
                square.Width = size;
                square.Height = size;
                return square;
            }
            Bitmap map = new Bitmap(bitmap.Width, bitmap.Height);
            var mesh = new PXMesh(material);
            using (Graphics graphics = Graphics.FromImage(map))
            {
                int penWidth = (int)numericWidth.Value;
                int squareSize = (int)numericWidth.Value * 3;

                if (withLine)
                {
                    foreach (var s in mesh.Sides)
                    {
                        using (Pen pen = new Pen(Color.Black, penWidth))
                        {
                            graphics.DrawLine(pen, Scale(s.VertexPair[0].UV).ToPointF(), Scale(s.VertexPair[1].UV).ToPointF());
                        }
                    }
                }
                foreach (IPXVertex v in mesh.Vertices)
                {
                    using (Pen pen = new Pen(GetPointColor(v)))
                    {
                        graphics.FillRectangle(pen.Brush, VertexSquare(v.UV, squareSize));
                    }
                }
            }
            return map;
        }

        void DrawMesh()
        {
            var selectedID = listBoxMaterial.SelectedIndex - 1;
            if (selectedID < 0)
            {
                pictureBoxMesh.Image = null;
                return;
            }

            if (bitmap == null)
                return;

            if (materialBmp[selectedID] == null)
                materialBmp[selectedID] = GetMeshImage(pmx.Material[selectedID], checkBoxWithLine.Checked);
            pictureBoxMesh.Image = materialBmp[selectedID];
        }
        void DisposeMaterialBMP()
        {
            for (int i = 0; i < materialBmp.Length; i++)
            {
                materialBmp[i]?.Dispose();
                materialBmp[i] = null;
            }
        }

        private void CtrlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var selectedMaterialID = listBoxMaterial.SelectedIndex - 1;
            if (selectedMaterialID < 0)
            {
                MessageBox.Show("ウェイト転写対象の材質を選択してください。");
                return;
            }
            if(comboBoxBone.SelectedIndex<0)
            {
                MessageBox.Show("ウェイト対象のボーンを選択してください。");
                return;
            }

            pmx = args.Host.Connector.Pmx.GetCurrentState();
            IPXMaterial targetMaterial = pmx.Material[selectedMaterialID];
            IPXBone targetBone = pmx.Bone[comboBoxBone.SelectedIndex];

            var mesh = new PXMesh(targetMaterial);
            for (int i = 0; i < mesh.Vertices.Count; i++)
            {
                IPXVertex v = mesh.Vertices[i];
                (IPXBone bone, float weight) bw = (targetBone, GetPointColor(v).R);
                var vertexWB = Utility.GetWeights(v);

                //頂点のウェイトを編集
                vertexWB.RemoveAll(w => w.bone == bw.bone);
                Utility.NormalizeWeights(vertexWB, 1 - bw.weight);
                vertexWB.Add(bw);
                Utility.SetVertexWeights(vertexWB, ref v);
            }

            Utility.Update(args.Host.Connector, pmx, PmxUpdateObject.Vertex);
            MessageBox.Show("完了");
        }

        private void buttonOpenMap_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = ImageFileOpen();
                if (bitmap != null)
                {
                    pictureBoxMap.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxMap.Image = bitmap;
                    DrawMesh();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("エラー：ファイルを開けませんでした。");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("エラー：非対応の拡張子のファイルが選択されました。");
            }

        }

        private void ReDrawMesh(object sender, EventArgs e)
        {
            DrawMesh();
        }
        private void ClearDrawMesh(object sender, EventArgs e)
        {
            DisposeMaterialBMP();
            DrawMesh();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            DisposeMaterialBMP();
            Format();
        }
    }
}
