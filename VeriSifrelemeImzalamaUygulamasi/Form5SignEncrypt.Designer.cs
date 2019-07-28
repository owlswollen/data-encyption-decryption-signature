namespace VeriSifrelemeImzalamaUygulamasi
{
    partial class Form5SignEncrypt
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
            this.comboBoxSender = new System.Windows.Forms.ComboBox();
            this.checkBoxSign = new System.Windows.Forms.CheckBox();
            this.comboBoxRecipient = new System.Windows.Forms.ComboBox();
            this.checkBoxEncrypt = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonSignEncrypt = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSender
            // 
            this.comboBoxSender.FormattingEnabled = true;
            this.comboBoxSender.Location = new System.Drawing.Point(15, 32);
            this.comboBoxSender.Name = "comboBoxSender";
            this.comboBoxSender.Size = new System.Drawing.Size(432, 24);
            this.comboBoxSender.TabIndex = 3;
            // 
            // checkBoxSign
            // 
            this.checkBoxSign.AutoSize = true;
            this.checkBoxSign.Checked = true;
            this.checkBoxSign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSign.Location = new System.Drawing.Point(32, 80);
            this.checkBoxSign.Name = "checkBoxSign";
            this.checkBoxSign.Size = new System.Drawing.Size(70, 21);
            this.checkBoxSign.TabIndex = 2;
            this.checkBoxSign.Text = "İmzala";
            this.checkBoxSign.UseVisualStyleBackColor = true;
            this.checkBoxSign.CheckedChanged += new System.EventHandler(this.checkBoxSign_CheckedChanged);
            // 
            // comboBoxRecipient
            // 
            this.comboBoxRecipient.FormattingEnabled = true;
            this.comboBoxRecipient.Location = new System.Drawing.Point(15, 31);
            this.comboBoxRecipient.Name = "comboBoxRecipient";
            this.comboBoxRecipient.Size = new System.Drawing.Size(432, 24);
            this.comboBoxRecipient.TabIndex = 1;
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.AutoSize = true;
            this.checkBoxEncrypt.Checked = true;
            this.checkBoxEncrypt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEncrypt.Location = new System.Drawing.Point(117, 80);
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Size = new System.Drawing.Size(70, 21);
            this.checkBoxEncrypt.TabIndex = 0;
            this.checkBoxEncrypt.Text = "Şifrele";
            this.checkBoxEncrypt.UseVisualStyleBackColor = true;
            this.checkBoxEncrypt.CheckedChanged += new System.EventHandler(this.checkBoxEncrypt_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonFile);
            this.groupBox3.Controls.Add(this.buttonRemove);
            this.groupBox3.Controls.Add(this.textBoxPath);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(24, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 77);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çıktı";
            // 
            // buttonFile
            // 
            this.buttonFile.BackgroundImage = global::VeriSifrelemeImzalamaUygulamasi.Properties.Resources.file;
            this.buttonFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFile.Location = new System.Drawing.Point(416, 27);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(30, 30);
            this.buttonFile.TabIndex = 4;
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRemove.BackgroundImage = global::VeriSifrelemeImzalamaUygulamasi.Properties.Resources.remove1;
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Location = new System.Drawing.Point(390, 35);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(15, 15);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPath.Location = new System.Drawing.Point(15, 35);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(375, 15);
            this.textBoxPath.TabIndex = 20;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(14, 32);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(396, 22);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // buttonSignEncrypt
            // 
            this.buttonSignEncrypt.Location = new System.Drawing.Point(214, 374);
            this.buttonSignEncrypt.Name = "buttonSignEncrypt";
            this.buttonSignEncrypt.Size = new System.Drawing.Size(149, 44);
            this.buttonSignEncrypt.TabIndex = 5;
            this.buttonSignEncrypt.Text = "Şifrele / İmzala";
            this.buttonSignEncrypt.UseVisualStyleBackColor = true;
            this.buttonSignEncrypt.Click += new System.EventHandler(this.buttonSignEncrypt_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(377, 374);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 44);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "İptal";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Şifrele / İmzala";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxRecipient);
            this.groupBox2.Location = new System.Drawing.Point(23, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alıcı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSender);
            this.groupBox1.Location = new System.Drawing.Point(23, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gönderen";
            // 
            // Form5SignEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 447);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBoxEncrypt);
            this.Controls.Add(this.checkBoxSign);
            this.Controls.Add(this.buttonSignEncrypt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5SignEncrypt";
            this.Text = "Dosya Şifreleme / İmzalama";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxSign;
        private System.Windows.Forms.CheckBox checkBoxEncrypt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxSender;
        public System.Windows.Forms.ComboBox comboBoxRecipient;
        public System.Windows.Forms.Button buttonSignEncrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}