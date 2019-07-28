namespace VeriSifrelemeImzalamaUygulamasi
{
    partial class Form7Results
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.labelStrikeout = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.progressBar);
            this.groupBox.Controls.Add(this.labelTitle);
            this.groupBox.Controls.Add(this.buttonFinish);
            this.groupBox.Controls.Add(this.buttonOpenFile);
            this.groupBox.Controls.Add(this.panel2);
            this.groupBox.Location = new System.Drawing.Point(12, 46);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(562, 397);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(36, 66);
            this.progressBar.Maximum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(491, 30);
            this.progressBar.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(33, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "empty";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(417, 344);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(112, 33);
            this.buttonFinish.TabIndex = 6;
            this.buttonFinish.Text = "Bitir";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(318, 344);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(93, 33);
            this.buttonOpenFile.TabIndex = 5;
            this.buttonOpenFile.Text = "Aç";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Visible = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel);
            this.panel2.Location = new System.Drawing.Point(36, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 236);
            this.panel2.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.MediumBlue;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.labelStrikeout);
            this.panel.Controls.Add(this.labelResult);
            this.panel.Location = new System.Drawing.Point(19, 23);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(450, 188);
            this.panel.TabIndex = 0;
            // 
            // labelStrikeout
            // 
            this.labelStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStrikeout.ForeColor = System.Drawing.Color.Teal;
            this.labelStrikeout.Location = new System.Drawing.Point(17, 14);
            this.labelStrikeout.Name = "labelStrikeout";
            this.labelStrikeout.Size = new System.Drawing.Size(415, 159);
            this.labelStrikeout.TabIndex = 1;
            this.labelStrikeout.Text = "label2";
            this.labelStrikeout.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResult.ForeColor = System.Drawing.Color.Teal;
            this.labelResult.Location = new System.Drawing.Point(16, 14);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(415, 159);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sonuçlar";
            // 
            // Form7Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox);
            this.Name = "Form7Results";
            this.Text = "Sonuçlar";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonFinish;
        public System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Button buttonOpenFile;
        public System.Windows.Forms.Label labelResult;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Label labelStrikeout;
    }
}