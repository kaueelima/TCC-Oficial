namespace LiveFaceDetection
{
    partial class FaceRecognizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceRecognizer));
            this.cbCamIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxScIncRte = new System.Windows.Forms.ComboBox();
            this.comboBoxMinNeigh = new System.Windows.Forms.ComboBox();
            this.textBoxWinSiz = new System.Windows.Forms.TextBox();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbRecog = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecog)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.Enabled = false;
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCamIndex.Location = new System.Drawing.Point(210, 356);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(57, 21);
            this.cbCamIndex.TabIndex = 4;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecionar Camera:";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(273, 355);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "---";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Scale Increase Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Neighbors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min.detection Scale\r\n(Window Size)";
            // 
            // comboBoxScIncRte
            // 
            this.comboBoxScIncRte.FormattingEnabled = true;
            this.comboBoxScIncRte.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
            this.comboBoxScIncRte.Location = new System.Drawing.Point(130, 28);
            this.comboBoxScIncRte.Name = "comboBoxScIncRte";
            this.comboBoxScIncRte.Size = new System.Drawing.Size(64, 21);
            this.comboBoxScIncRte.TabIndex = 13;
            this.comboBoxScIncRte.Text = "1.1";
            // 
            // comboBoxMinNeigh
            // 
            this.comboBoxMinNeigh.FormattingEnabled = true;
            this.comboBoxMinNeigh.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxMinNeigh.Location = new System.Drawing.Point(130, 54);
            this.comboBoxMinNeigh.Name = "comboBoxMinNeigh";
            this.comboBoxMinNeigh.Size = new System.Drawing.Size(64, 21);
            this.comboBoxMinNeigh.TabIndex = 14;
            this.comboBoxMinNeigh.Text = "2";
            // 
            // textBoxWinSiz
            // 
            this.textBoxWinSiz.Location = new System.Drawing.Point(130, 81);
            this.textBoxWinSiz.Name = "textBoxWinSiz";
            this.textBoxWinSiz.Size = new System.Drawing.Size(64, 20);
            this.textBoxWinSiz.TabIndex = 15;
            this.textBoxWinSiz.Text = "25";
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(10, 64);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(366, 282);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(10, 354);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 26);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Procurar";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxWinSiz);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxMinNeigh);
            this.groupBox1.Controls.Add(this.comboBoxScIncRte);
            this.groupBox1.Location = new System.Drawing.Point(397, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(206, 119);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tune Detection Parameters:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pbRecog
            // 
            this.pbRecog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRecog.Location = new System.Drawing.Point(398, 155);
            this.pbRecog.Name = "pbRecog";
            this.pbRecog.Size = new System.Drawing.Size(102, 108);
            this.pbRecog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecog.TabIndex = 28;
            this.pbRecog.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Face Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Loaded Face:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FaceRecognizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 496);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbRecog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FaceRecognizer";
            this.Text = "Face Recognizer";
            this.Load += new System.EventHandler(this.FaceRecognizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCamIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxScIncRte;
        private System.Windows.Forms.ComboBox comboBoxMinNeigh;
        private System.Windows.Forms.TextBox textBoxWinSiz;
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pbRecog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

