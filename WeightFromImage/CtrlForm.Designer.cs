namespace WeightFromImage
{
    partial class CtrlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            bitmap?.Dispose();
            foreach (var item in materialBmp)
            {
                item?.Dispose();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonOpenMap = new System.Windows.Forms.Button();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.pictureBoxMesh = new System.Windows.Forms.PictureBox();
            this.listBoxMaterial = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.groupBoxPixelInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonPiA = new System.Windows.Forms.RadioButton();
            this.radioButtonPiG = new System.Windows.Forms.RadioButton();
            this.radioButtonPiB = new System.Windows.Forms.RadioButton();
            this.radioButtonPiR = new System.Windows.Forms.RadioButton();
            this.checkBoxDec = new System.Windows.Forms.CheckBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.checkBoxWithLine = new System.Windows.Forms.CheckBox();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.comboBoxBone = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.pictureBoxMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesh)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.groupBoxPixelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(801, 5);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(227, 55);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "ウェイトを画像から転写";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonOpenMap
            // 
            this.buttonOpenMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenMap.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenMap.Name = "buttonOpenMap";
            this.buttonOpenMap.Size = new System.Drawing.Size(791, 59);
            this.buttonOpenMap.TabIndex = 1;
            this.buttonOpenMap.Text = "マップ画像を開く";
            this.buttonOpenMap.UseVisualStyleBackColor = true;
            this.buttonOpenMap.Click += new System.EventHandler(this.buttonOpenMap_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMap.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxMap.Controls.Add(this.pictureBoxMesh);
            this.pictureBoxMap.Location = new System.Drawing.Point(3, 68);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxMap, 2);
            this.pictureBoxMap.Size = new System.Drawing.Size(791, 720);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMap.TabIndex = 2;
            this.pictureBoxMap.TabStop = false;
            // 
            // pictureBoxMesh
            // 
            this.pictureBoxMesh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMesh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMesh.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMesh.Name = "pictureBoxMesh";
            this.pictureBoxMesh.Size = this.pictureBoxMap.Size;
            this.pictureBoxMesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMesh.TabIndex = 0;
            this.pictureBoxMesh.TabStop = false;
            // 
            // listBoxMaterial
            // 
            this.listBoxMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMaterial.FormattingEnabled = true;
            this.listBoxMaterial.ItemHeight = 20;
            this.listBoxMaterial.Location = new System.Drawing.Point(800, 113);
            this.listBoxMaterial.Name = "listBoxMaterial";
            this.listBoxMaterial.Size = new System.Drawing.Size(229, 664);
            this.listBoxMaterial.TabIndex = 3;
            this.listBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.ReDrawMesh);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxMap, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxMaterial, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpenMap, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRun, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSettings, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSettings, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSettings, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBone, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1267, 791);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSettings.Controls.Add(this.groupBoxPixelInfo);
            this.panelSettings.Controls.Add(this.checkBoxDec);
            this.panelSettings.Controls.Add(this.buttonReload);
            this.panelSettings.Controls.Add(this.checkBoxWithLine);
            this.panelSettings.Controls.Add(this.numericWidth);
            this.panelSettings.Controls.Add(this.labelWidth);
            this.panelSettings.Location = new System.Drawing.Point(1035, 113);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(229, 675);
            this.panelSettings.TabIndex = 4;
            // 
            // groupBoxPixelInfo
            // 
            this.groupBoxPixelInfo.Controls.Add(this.radioButtonPiA);
            this.groupBoxPixelInfo.Controls.Add(this.radioButtonPiG);
            this.groupBoxPixelInfo.Controls.Add(this.radioButtonPiB);
            this.groupBoxPixelInfo.Controls.Add(this.radioButtonPiR);
            this.groupBoxPixelInfo.Location = new System.Drawing.Point(7, 86);
            this.groupBoxPixelInfo.Name = "groupBoxPixelInfo";
            this.groupBoxPixelInfo.Size = new System.Drawing.Size(127, 94);
            this.groupBoxPixelInfo.TabIndex = 5;
            this.groupBoxPixelInfo.TabStop = false;
            this.groupBoxPixelInfo.Text = "取得情報";
            // 
            // radioButtonPiA
            // 
            this.radioButtonPiA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPiA.AutoSize = true;
            this.radioButtonPiA.Location = new System.Drawing.Point(79, 64);
            this.radioButtonPiA.Name = "radioButtonPiA";
            this.radioButtonPiA.Size = new System.Drawing.Size(42, 24);
            this.radioButtonPiA.TabIndex = 1;
            this.radioButtonPiA.Text = "透";
            this.radioButtonPiA.UseVisualStyleBackColor = true;
            // 
            // radioButtonPiG
            // 
            this.radioButtonPiG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonPiG.AutoSize = true;
            this.radioButtonPiG.Location = new System.Drawing.Point(6, 64);
            this.radioButtonPiG.Name = "radioButtonPiG";
            this.radioButtonPiG.Size = new System.Drawing.Size(42, 24);
            this.radioButtonPiG.TabIndex = 1;
            this.radioButtonPiG.Text = "緑";
            this.radioButtonPiG.UseVisualStyleBackColor = true;
            // 
            // radioButtonPiB
            // 
            this.radioButtonPiB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPiB.AutoSize = true;
            this.radioButtonPiB.Location = new System.Drawing.Point(79, 26);
            this.radioButtonPiB.Name = "radioButtonPiB";
            this.radioButtonPiB.Size = new System.Drawing.Size(42, 24);
            this.radioButtonPiB.TabIndex = 0;
            this.radioButtonPiB.Text = "青";
            this.radioButtonPiB.UseVisualStyleBackColor = true;
            // 
            // radioButtonPiR
            // 
            this.radioButtonPiR.AutoSize = true;
            this.radioButtonPiR.Checked = true;
            this.radioButtonPiR.Location = new System.Drawing.Point(6, 26);
            this.radioButtonPiR.Name = "radioButtonPiR";
            this.radioButtonPiR.Size = new System.Drawing.Size(42, 24);
            this.radioButtonPiR.TabIndex = 0;
            this.radioButtonPiR.TabStop = true;
            this.radioButtonPiR.Text = "赤";
            this.radioButtonPiR.UseVisualStyleBackColor = true;
            // 
            // checkBoxDec
            // 
            this.checkBoxDec.AutoSize = true;
            this.checkBoxDec.Location = new System.Drawing.Point(7, 598);
            this.checkBoxDec.Name = "checkBoxDec";
            this.checkBoxDec.Size = new System.Drawing.Size(67, 24);
            this.checkBoxDec.TabIndex = 4;
            this.checkBoxDec.Text = "Size--";
            this.checkBoxDec.UseVisualStyleBackColor = true;
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.Location = new System.Drawing.Point(0, 628);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(229, 47);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "再読込";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // checkBoxWithLine
            // 
            this.checkBoxWithLine.AutoSize = true;
            this.checkBoxWithLine.Checked = true;
            this.checkBoxWithLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWithLine.Location = new System.Drawing.Point(7, 56);
            this.checkBoxWithLine.Name = "checkBoxWithLine";
            this.checkBoxWithLine.Size = new System.Drawing.Size(107, 24);
            this.checkBoxWithLine.TabIndex = 2;
            this.checkBoxWithLine.Text = "線を描画する";
            this.checkBoxWithLine.UseVisualStyleBackColor = true;
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(7, 23);
            this.numericWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(219, 27);
            this.numericWidth.TabIndex = 1;
            this.numericWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelSettings
            // 
            this.labelSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSettings.Location = new System.Drawing.Point(1114, 69);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(71, 37);
            this.labelSettings.TabIndex = 0;
            this.labelSettings.Text = "設定";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(3, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(72, 20);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "点の大きさ";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.Location = new System.Drawing.Point(1036, 5);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(227, 55);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "再描画";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ClearDrawMesh);
            // 
            // comboBoxBone
            // 
            this.comboBoxBone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBone.FormattingEnabled = true;
            this.comboBoxBone.Location = new System.Drawing.Point(800, 77);
            this.comboBoxBone.Name = "comboBoxBone";
            this.comboBoxBone.Size = new System.Drawing.Size(229, 28);
            this.comboBoxBone.TabIndex = 5;
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 791);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(999, 830);
            this.Name = "CtrlForm";
            this.Text = "CtrlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.pictureBoxMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.groupBoxPixelInfo.ResumeLayout(false);
            this.groupBoxPixelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonOpenMap;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.PictureBox pictureBoxMesh;
        private System.Windows.Forms.ListBox listBoxMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.CheckBox checkBoxWithLine;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.CheckBox checkBoxDec;
        private System.Windows.Forms.GroupBox groupBoxPixelInfo;
        private System.Windows.Forms.RadioButton radioButtonPiA;
        private System.Windows.Forms.RadioButton radioButtonPiG;
        private System.Windows.Forms.RadioButton radioButtonPiB;
        private System.Windows.Forms.RadioButton radioButtonPiR;
        private System.Windows.Forms.ComboBox comboBoxBone;
    }
}