namespace LiveFaceDetection
{
    partial class TrainingSetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingSetEditor));
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.gBFaceAdder = new System.Windows.Forms.GroupBox();
            this.pbCollectedFaces = new System.Windows.Forms.PictureBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSpeech = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gBFaceAdder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectedFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCamIndex.Location = new System.Drawing.Point(520, 449);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(57, 21);
            this.cbCamIndex.TabIndex = 4;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecionar Camera:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(312, 432);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 46);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "---";
            this.btnStart.UseVisualStyleBackColor = false;
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
            this.comboBoxScIncRte.Text = "0.7";
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
            this.CamImageBox.Location = new System.Drawing.Point(9, 11);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(736, 345);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(333, 480);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(107, 24);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Pesquisar Imagem";
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
            this.groupBox1.Location = new System.Drawing.Point(24, 371);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(201, 112);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tune Detection Parameters:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(75, 139);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Proximo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(17, 139);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(56, 23);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Text = "Anterior";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // gBFaceAdder
            // 
            this.gBFaceAdder.Controls.Add(this.pbCollectedFaces);
            this.gBFaceAdder.Controls.Add(this.btnNext);
            this.gBFaceAdder.Controls.Add(this.btnPrev);
            this.gBFaceAdder.Location = new System.Drawing.Point(604, 371);
            this.gBFaceAdder.Name = "gBFaceAdder";
            this.gBFaceAdder.Size = new System.Drawing.Size(145, 172);
            this.gBFaceAdder.TabIndex = 26;
            this.gBFaceAdder.TabStop = false;
            this.gBFaceAdder.Text = "Rosto Detectado";
            this.gBFaceAdder.Visible = false;
            this.gBFaceAdder.Enter += new System.EventHandler(this.gBFaceAdder_Enter);
            // 
            // pbCollectedFaces
            // 
            this.pbCollectedFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCollectedFaces.Location = new System.Drawing.Point(17, 19);
            this.pbCollectedFaces.Name = "pbCollectedFaces";
            this.pbCollectedFaces.Size = new System.Drawing.Size(104, 114);
            this.pbCollectedFaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCollectedFaces.TabIndex = 20;
            this.pbCollectedFaces.TabStop = false;
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(279, 359);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(220, 20);
            this.nometxt.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "NOME:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSpeech
            // 
            this.txtSpeech.Location = new System.Drawing.Point(340, 377);
            this.txtSpeech.Name = "txtSpeech";
            this.txtSpeech.Size = new System.Drawing.Size(100, 20);
            this.txtSpeech.TabIndex = 30;
            // 
            // TrainingSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 510);
            this.Controls.Add(this.txtSpeech);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.gBFaceAdder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrainingSetEditor";
            this.Text = "Detectador de rosto";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TrainingSetEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBFaceAdder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectedFaces)).EndInit();
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox gBFaceAdder;
        private System.Windows.Forms.PictureBox pbCollectedFaces;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSpeech;
    }
}

