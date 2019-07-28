namespace VeriSifrelemeImzalamaUygulamasi
{
    partial class Form4Warning
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPickNewOne = new System.Windows.Forms.Button();
            this.buttonTakeThisOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uyarı: Güvenli olmayan bir anahtar parolası girdiniz.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anahtar parolası en az 8 karakter uzunluğunda olmalı ve en az 1 rakam ya da özel " +
    "karakter içermelidir.";
            // 
            // buttonPickNewOne
            // 
            this.buttonPickNewOne.Location = new System.Drawing.Point(101, 90);
            this.buttonPickNewOne.Name = "buttonPickNewOne";
            this.buttonPickNewOne.Size = new System.Drawing.Size(134, 37);
            this.buttonPickNewOne.TabIndex = 2;
            this.buttonPickNewOne.Text = "Yeni parola al";
            this.buttonPickNewOne.UseVisualStyleBackColor = true;
            this.buttonPickNewOne.Click += new System.EventHandler(this.buttonPickNewOne_Click);
            // 
            // buttonTakeThisOne
            // 
            this.buttonTakeThisOne.Location = new System.Drawing.Point(241, 91);
            this.buttonTakeThisOne.Name = "buttonTakeThisOne";
            this.buttonTakeThisOne.Size = new System.Drawing.Size(143, 36);
            this.buttonTakeThisOne.TabIndex = 3;
            this.buttonTakeThisOne.Text = "Eskisiyle devam et";
            this.buttonTakeThisOne.UseVisualStyleBackColor = true;
            this.buttonTakeThisOne.Click += new System.EventHandler(this.buttonTakeThisOne_Click);
            // 
            // Form4Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 143);
            this.Controls.Add(this.buttonTakeThisOne);
            this.Controls.Add(this.buttonPickNewOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4Warning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uyarı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPickNewOne;
        private System.Windows.Forms.Button buttonTakeThisOne;
    }
}