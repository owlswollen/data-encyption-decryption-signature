namespace VeriSifrelemeImzalamaUygulamasi
{
    partial class Form8Passphrase
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
            this.textBoxPassphrase = new System.Windows.Forms.TextBox();
            this.buttonTogglePassphrase = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBack = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelTry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPassphrase
            // 
            this.textBoxPassphrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassphrase.Location = new System.Drawing.Point(82, 67);
            this.textBoxPassphrase.Name = "textBoxPassphrase";
            this.textBoxPassphrase.PasswordChar = '●';
            this.textBoxPassphrase.Size = new System.Drawing.Size(139, 15);
            this.textBoxPassphrase.TabIndex = 16;
            this.textBoxPassphrase.TextChanged += new System.EventHandler(this.textBoxPassphrase_TextChanged);
            // 
            // buttonTogglePassphrase
            // 
            this.buttonTogglePassphrase.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTogglePassphrase.BackgroundImage = global::VeriSifrelemeImzalamaUygulamasi.Properties.Resources.eye1;
            this.buttonTogglePassphrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTogglePassphrase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTogglePassphrase.FlatAppearance.BorderSize = 0;
            this.buttonTogglePassphrase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonTogglePassphrase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonTogglePassphrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTogglePassphrase.Location = new System.Drawing.Point(224, 68);
            this.buttonTogglePassphrase.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTogglePassphrase.Name = "buttonTogglePassphrase";
            this.buttonTogglePassphrase.Size = new System.Drawing.Size(15, 13);
            this.buttonTogglePassphrase.TabIndex = 17;
            this.buttonTogglePassphrase.UseVisualStyleBackColor = false;
            this.buttonTogglePassphrase.Click += new System.EventHandler(this.buttonTogglePassphrase_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Parola:";
            // 
            // textBoxBack
            // 
            this.textBoxBack.Location = new System.Drawing.Point(79, 63);
            this.textBoxBack.Name = "textBoxBack";
            this.textBoxBack.Size = new System.Drawing.Size(167, 22);
            this.textBoxBack.TabIndex = 19;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(105, 100);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(69, 30);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "Devam";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(176, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(70, 30);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "İptal";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Location = new System.Drawing.Point(23, 18);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(223, 42);
            this.labelUserName.TabIndex = 23;
            // 
            // labelTry
            // 
            this.labelTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTry.ForeColor = System.Drawing.Color.Red;
            this.labelTry.Location = new System.Drawing.Point(19, 142);
            this.labelTry.Name = "labelTry";
            this.labelTry.Size = new System.Drawing.Size(227, 23);
            this.labelTry.TabIndex = 24;
            this.labelTry.Text = "label2";
            this.labelTry.Visible = false;
            // 
            // Form8Passphrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 174);
            this.Controls.Add(this.textBoxPassphrase);
            this.Controls.Add(this.buttonTogglePassphrase);
            this.Controls.Add(this.labelTry);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxBack);
            this.Name = "Form8Passphrase";
            this.Text = "Parola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxPassphrase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBack;
        public System.Windows.Forms.Button buttonTogglePassphrase;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUserName;
        public System.Windows.Forms.Label labelTry;
    }
}