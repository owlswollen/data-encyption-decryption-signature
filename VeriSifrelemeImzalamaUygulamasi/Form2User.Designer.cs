namespace VeriSifrelemeImzalamaUygulamasi
{
    partial class Form2User
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
            this.tabControlSender = new System.Windows.Forms.TabControl();
            this.tabPageSenderMyCerts = new System.Windows.Forms.TabPage();
            this.dataGridViewSender = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageSenderImported = new System.Windows.Forms.TabPage();
            this.dataGridViewSenderImported = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSender = new System.Windows.Forms.GroupBox();
            this.buttonSenderExport = new System.Windows.Forms.Button();
            this.buttonSenderImport = new System.Windows.Forms.Button();
            this.buttonSenderVerifyDecrypt = new System.Windows.Forms.Button();
            this.buttonSenderSignEncrypt = new System.Windows.Forms.Button();
            this.groupBoxRecipient = new System.Windows.Forms.GroupBox();
            this.tabControlRecipient = new System.Windows.Forms.TabControl();
            this.tabPageRecipientMyCerts = new System.Windows.Forms.TabPage();
            this.dataGridViewRecipient = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageRecipientImported = new System.Windows.Forms.TabPage();
            this.dataGridViewRecipientImported = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRecipientSignEncrypt = new System.Windows.Forms.Button();
            this.buttonRecipientVerifyDecrypt = new System.Windows.Forms.Button();
            this.buttonRecipientExport = new System.Windows.Forms.Button();
            this.buttonRecipientImport = new System.Windows.Forms.Button();
            this.buttonRecipientNewKeypair = new System.Windows.Forms.Button();
            this.buttonSenderNewKeypair = new System.Windows.Forms.Button();
            this.tabControlSender.SuspendLayout();
            this.tabPageSenderMyCerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSender)).BeginInit();
            this.tabPageSenderImported.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSenderImported)).BeginInit();
            this.groupBoxSender.SuspendLayout();
            this.groupBoxRecipient.SuspendLayout();
            this.tabControlRecipient.SuspendLayout();
            this.tabPageRecipientMyCerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipient)).BeginInit();
            this.tabPageRecipientImported.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipientImported)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSender
            // 
            this.tabControlSender.Controls.Add(this.tabPageSenderMyCerts);
            this.tabControlSender.Controls.Add(this.tabPageSenderImported);
            this.tabControlSender.Location = new System.Drawing.Point(0, 85);
            this.tabControlSender.Name = "tabControlSender";
            this.tabControlSender.SelectedIndex = 0;
            this.tabControlSender.Size = new System.Drawing.Size(900, 230);
            this.tabControlSender.TabIndex = 1;
            this.tabControlSender.Tag = "";
            this.tabControlSender.SelectedIndexChanged += new System.EventHandler(this.tabControlSender_SelectedIndexChanged);
            // 
            // tabPageSenderMyCerts
            // 
            this.tabPageSenderMyCerts.Controls.Add(this.dataGridViewSender);
            this.tabPageSenderMyCerts.Location = new System.Drawing.Point(4, 25);
            this.tabPageSenderMyCerts.Name = "tabPageSenderMyCerts";
            this.tabPageSenderMyCerts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSenderMyCerts.Size = new System.Drawing.Size(892, 201);
            this.tabPageSenderMyCerts.TabIndex = 0;
            this.tabPageSenderMyCerts.Text = "Sertifikalarım";
            this.tabPageSenderMyCerts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSender
            // 
            this.dataGridViewSender.AllowUserToAddRows = false;
            this.dataGridViewSender.AllowUserToOrderColumns = true;
            this.dataGridViewSender.AllowUserToResizeRows = false;
            this.dataGridViewSender.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSender.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewSender.EnableHeadersVisualStyles = false;
            this.dataGridViewSender.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSender.Name = "dataGridViewSender";
            this.dataGridViewSender.RowTemplate.Height = 24;
            this.dataGridViewSender.Size = new System.Drawing.Size(892, 201);
            this.dataGridViewSender.TabIndex = 0;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Ad";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "E-posta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Geçerlilik Baslangıcı";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Geçerlilik Bitişi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Anahtar Kimliği";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // tabPageSenderImported
            // 
            this.tabPageSenderImported.Controls.Add(this.dataGridViewSenderImported);
            this.tabPageSenderImported.Location = new System.Drawing.Point(4, 25);
            this.tabPageSenderImported.Name = "tabPageSenderImported";
            this.tabPageSenderImported.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSenderImported.Size = new System.Drawing.Size(892, 201);
            this.tabPageSenderImported.TabIndex = 1;
            this.tabPageSenderImported.Text = "Diğer Sertifikalar";
            this.tabPageSenderImported.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSenderImported
            // 
            this.dataGridViewSenderImported.AllowUserToAddRows = false;
            this.dataGridViewSenderImported.AllowUserToOrderColumns = true;
            this.dataGridViewSenderImported.AllowUserToResizeRows = false;
            this.dataGridViewSenderImported.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewSenderImported.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSenderImported.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSenderImported.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSenderImported.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridViewSenderImported.EnableHeadersVisualStyles = false;
            this.dataGridViewSenderImported.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSenderImported.Name = "dataGridViewSenderImported";
            this.dataGridViewSenderImported.RowTemplate.Height = 24;
            this.dataGridViewSenderImported.Size = new System.Drawing.Size(892, 201);
            this.dataGridViewSenderImported.TabIndex = 1;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ad";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "E-posta";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Geçerlilik Baslangıcı";
            this.Column12.Name = "Column12";
            this.Column12.Width = 110;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Geçerlilik Bitişi";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Anahtar Kimliği";
            this.Column14.Name = "Column14";
            // 
            // groupBoxSender
            // 
            this.groupBoxSender.Controls.Add(this.buttonSenderNewKeypair);
            this.groupBoxSender.Controls.Add(this.buttonSenderExport);
            this.groupBoxSender.Controls.Add(this.buttonSenderImport);
            this.groupBoxSender.Controls.Add(this.buttonSenderVerifyDecrypt);
            this.groupBoxSender.Controls.Add(this.buttonSenderSignEncrypt);
            this.groupBoxSender.Controls.Add(this.tabControlSender);
            this.groupBoxSender.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSender.Name = "groupBoxSender";
            this.groupBoxSender.Size = new System.Drawing.Size(900, 320);
            this.groupBoxSender.TabIndex = 1;
            this.groupBoxSender.TabStop = false;
            // 
            // buttonSenderExport
            // 
            this.buttonSenderExport.Location = new System.Drawing.Point(366, 9);
            this.buttonSenderExport.Name = "buttonSenderExport";
            this.buttonSenderExport.Size = new System.Drawing.Size(90, 70);
            this.buttonSenderExport.TabIndex = 5;
            this.buttonSenderExport.Text = "Dışa Aktar";
            this.buttonSenderExport.UseVisualStyleBackColor = true;
            this.buttonSenderExport.Click += new System.EventHandler(this.buttonSenderExport_Click);
            // 
            // buttonSenderImport
            // 
            this.buttonSenderImport.Location = new System.Drawing.Point(276, 9);
            this.buttonSenderImport.Name = "buttonSenderImport";
            this.buttonSenderImport.Size = new System.Drawing.Size(90, 70);
            this.buttonSenderImport.TabIndex = 4;
            this.buttonSenderImport.Text = "İçe Aktar";
            this.buttonSenderImport.UseVisualStyleBackColor = true;
            this.buttonSenderImport.Click += new System.EventHandler(this.buttonSenderImport_Click);
            // 
            // buttonSenderVerifyDecrypt
            // 
            this.buttonSenderVerifyDecrypt.Enabled = false;
            this.buttonSenderVerifyDecrypt.Location = new System.Drawing.Point(186, 9);
            this.buttonSenderVerifyDecrypt.Name = "buttonSenderVerifyDecrypt";
            this.buttonSenderVerifyDecrypt.Size = new System.Drawing.Size(90, 70);
            this.buttonSenderVerifyDecrypt.TabIndex = 3;
            this.buttonSenderVerifyDecrypt.Text = "Deşifrele / Doğrula";
            this.buttonSenderVerifyDecrypt.UseVisualStyleBackColor = true;
            this.buttonSenderVerifyDecrypt.Click += new System.EventHandler(this.buttonVerifyDecrypt_Click);
            // 
            // buttonSenderSignEncrypt
            // 
            this.buttonSenderSignEncrypt.Location = new System.Drawing.Point(96, 9);
            this.buttonSenderSignEncrypt.Name = "buttonSenderSignEncrypt";
            this.buttonSenderSignEncrypt.Size = new System.Drawing.Size(90, 70);
            this.buttonSenderSignEncrypt.TabIndex = 2;
            this.buttonSenderSignEncrypt.Text = "Şifrele / İmzala";
            this.buttonSenderSignEncrypt.UseVisualStyleBackColor = true;
            this.buttonSenderSignEncrypt.Click += new System.EventHandler(this.buttonSignEncrypt_Click);
            // 
            // groupBoxRecipient
            // 
            this.groupBoxRecipient.Controls.Add(this.buttonRecipientNewKeypair);
            this.groupBoxRecipient.Controls.Add(this.tabControlRecipient);
            this.groupBoxRecipient.Controls.Add(this.buttonRecipientSignEncrypt);
            this.groupBoxRecipient.Controls.Add(this.buttonRecipientVerifyDecrypt);
            this.groupBoxRecipient.Controls.Add(this.buttonRecipientExport);
            this.groupBoxRecipient.Controls.Add(this.buttonRecipientImport);
            this.groupBoxRecipient.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRecipient.Name = "groupBoxRecipient";
            this.groupBoxRecipient.Size = new System.Drawing.Size(900, 320);
            this.groupBoxRecipient.TabIndex = 2;
            this.groupBoxRecipient.TabStop = false;
            this.groupBoxRecipient.Visible = false;
            // 
            // tabControlRecipient
            // 
            this.tabControlRecipient.Controls.Add(this.tabPageRecipientMyCerts);
            this.tabControlRecipient.Controls.Add(this.tabPageRecipientImported);
            this.tabControlRecipient.Location = new System.Drawing.Point(0, 85);
            this.tabControlRecipient.Name = "tabControlRecipient";
            this.tabControlRecipient.SelectedIndex = 0;
            this.tabControlRecipient.Size = new System.Drawing.Size(900, 230);
            this.tabControlRecipient.TabIndex = 1;
            this.tabControlRecipient.Tag = "";
            this.tabControlRecipient.SelectedIndexChanged += new System.EventHandler(this.tabControlRecipient_SelectedIndexChanged);
            // 
            // tabPageRecipientMyCerts
            // 
            this.tabPageRecipientMyCerts.Controls.Add(this.dataGridViewRecipient);
            this.tabPageRecipientMyCerts.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecipientMyCerts.Name = "tabPageRecipientMyCerts";
            this.tabPageRecipientMyCerts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecipientMyCerts.Size = new System.Drawing.Size(892, 201);
            this.tabPageRecipientMyCerts.TabIndex = 0;
            this.tabPageRecipientMyCerts.Text = "Sertifikalarım";
            this.tabPageRecipientMyCerts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecipient
            // 
            this.dataGridViewRecipient.AllowUserToAddRows = false;
            this.dataGridViewRecipient.AllowUserToOrderColumns = true;
            this.dataGridViewRecipient.AllowUserToResizeRows = false;
            this.dataGridViewRecipient.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewRecipient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecipient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRecipient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewRecipient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewRecipient.EnableHeadersVisualStyles = false;
            this.dataGridViewRecipient.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRecipient.Name = "dataGridViewRecipient";
            this.dataGridViewRecipient.RowTemplate.Height = 24;
            this.dataGridViewRecipient.Size = new System.Drawing.Size(892, 201);
            this.dataGridViewRecipient.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "E-posta";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Geçerlilik Başlangıcı";
            this.Column7.Name = "Column7";
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Geçerlilik Bitişi";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Anahtar Kimliği";
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // tabPageRecipientImported
            // 
            this.tabPageRecipientImported.Controls.Add(this.dataGridViewRecipientImported);
            this.tabPageRecipientImported.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecipientImported.Name = "tabPageRecipientImported";
            this.tabPageRecipientImported.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecipientImported.Size = new System.Drawing.Size(892, 201);
            this.tabPageRecipientImported.TabIndex = 1;
            this.tabPageRecipientImported.Text = "Diğer Sertifikalar";
            this.tabPageRecipientImported.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecipientImported
            // 
            this.dataGridViewRecipientImported.AllowUserToAddRows = false;
            this.dataGridViewRecipientImported.AllowUserToOrderColumns = true;
            this.dataGridViewRecipientImported.AllowUserToResizeRows = false;
            this.dataGridViewRecipientImported.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewRecipientImported.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecipientImported.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRecipientImported.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewRecipientImported.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dataGridViewRecipientImported.EnableHeadersVisualStyles = false;
            this.dataGridViewRecipientImported.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRecipientImported.Name = "dataGridViewRecipientImported";
            this.dataGridViewRecipientImported.RowTemplate.Height = 24;
            this.dataGridViewRecipientImported.Size = new System.Drawing.Size(892, 201);
            this.dataGridViewRecipientImported.TabIndex = 1;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Ad";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "E-posta";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Geçerlilik Başlangıcı";
            this.Column17.Name = "Column17";
            this.Column17.Width = 110;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Geçerlilik Bitişi";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Anahtar Kimliği";
            this.Column19.Name = "Column19";
            // 
            // buttonRecipientSignEncrypt
            // 
            this.buttonRecipientSignEncrypt.Enabled = false;
            this.buttonRecipientSignEncrypt.Location = new System.Drawing.Point(96, 11);
            this.buttonRecipientSignEncrypt.Name = "buttonRecipientSignEncrypt";
            this.buttonRecipientSignEncrypt.Size = new System.Drawing.Size(90, 70);
            this.buttonRecipientSignEncrypt.TabIndex = 8;
            this.buttonRecipientSignEncrypt.Text = "Şifrele / İmzala";
            this.buttonRecipientSignEncrypt.UseVisualStyleBackColor = true;
            this.buttonRecipientSignEncrypt.Click += new System.EventHandler(this.buttonSignEncrypt_Click);
            // 
            // buttonRecipientVerifyDecrypt
            // 
            this.buttonRecipientVerifyDecrypt.Location = new System.Drawing.Point(186, 11);
            this.buttonRecipientVerifyDecrypt.Name = "buttonRecipientVerifyDecrypt";
            this.buttonRecipientVerifyDecrypt.Size = new System.Drawing.Size(90, 70);
            this.buttonRecipientVerifyDecrypt.TabIndex = 9;
            this.buttonRecipientVerifyDecrypt.Text = "Deşifrele / Doğrula";
            this.buttonRecipientVerifyDecrypt.UseVisualStyleBackColor = true;
            this.buttonRecipientVerifyDecrypt.Click += new System.EventHandler(this.buttonVerifyDecrypt_Click);
            // 
            // buttonRecipientExport
            // 
            this.buttonRecipientExport.Location = new System.Drawing.Point(366, 11);
            this.buttonRecipientExport.Name = "buttonRecipientExport";
            this.buttonRecipientExport.Size = new System.Drawing.Size(90, 70);
            this.buttonRecipientExport.TabIndex = 11;
            this.buttonRecipientExport.Text = "Dışa Aktar";
            this.buttonRecipientExport.UseVisualStyleBackColor = true;
            this.buttonRecipientExport.Click += new System.EventHandler(this.buttonRecipientExport_Click);
            // 
            // buttonRecipientImport
            // 
            this.buttonRecipientImport.Location = new System.Drawing.Point(276, 11);
            this.buttonRecipientImport.Name = "buttonRecipientImport";
            this.buttonRecipientImport.Size = new System.Drawing.Size(90, 70);
            this.buttonRecipientImport.TabIndex = 10;
            this.buttonRecipientImport.Text = "İçe Aktar";
            this.buttonRecipientImport.UseVisualStyleBackColor = true;
            this.buttonRecipientImport.Click += new System.EventHandler(this.buttonRecipientImport_Click);
            // 
            // buttonRecipientNewKeypair
            // 
            this.buttonRecipientNewKeypair.Location = new System.Drawing.Point(6, 11);
            this.buttonRecipientNewKeypair.Name = "buttonRecipientNewKeypair";
            this.buttonRecipientNewKeypair.Size = new System.Drawing.Size(90, 70);
            this.buttonRecipientNewKeypair.TabIndex = 12;
            this.buttonRecipientNewKeypair.Text = "Yeni Anahtar";
            this.buttonRecipientNewKeypair.UseVisualStyleBackColor = true;
            this.buttonRecipientNewKeypair.Click += new System.EventHandler(this.buttonNewKeypair_Click);
            // 
            // buttonSenderNewKeypair
            // 
            this.buttonSenderNewKeypair.Location = new System.Drawing.Point(6, 9);
            this.buttonSenderNewKeypair.Name = "buttonSenderNewKeypair";
            this.buttonSenderNewKeypair.Size = new System.Drawing.Size(90, 70);
            this.buttonSenderNewKeypair.TabIndex = 13;
            this.buttonSenderNewKeypair.Text = "Yeni Anahtar";
            this.buttonSenderNewKeypair.UseVisualStyleBackColor = true;
            this.buttonSenderNewKeypair.Click += new System.EventHandler(this.buttonNewKeypair_Click);
            // 
            // Form2User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 346);
            this.Controls.Add(this.groupBoxRecipient);
            this.Controls.Add(this.groupBoxSender);
            this.Name = "Form2User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tabControlSender.ResumeLayout(false);
            this.tabPageSenderMyCerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSender)).EndInit();
            this.tabPageSenderImported.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSenderImported)).EndInit();
            this.groupBoxSender.ResumeLayout(false);
            this.groupBoxRecipient.ResumeLayout(false);
            this.tabControlRecipient.ResumeLayout(false);
            this.tabPageRecipientMyCerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipient)).EndInit();
            this.tabPageRecipientImported.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipientImported)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSender;
        private System.Windows.Forms.TabPage tabPageSenderMyCerts;
        private System.Windows.Forms.TabPage tabPageSenderImported;
        private System.Windows.Forms.DataGridView dataGridViewSender;
        private System.Windows.Forms.GroupBox groupBoxSender;
        private System.Windows.Forms.GroupBox groupBoxRecipient;
        private System.Windows.Forms.TabControl tabControlRecipient;
        private System.Windows.Forms.TabPage tabPageRecipientMyCerts;
        private System.Windows.Forms.DataGridView dataGridViewRecipient;
        private System.Windows.Forms.TabPage tabPageRecipientImported;
        private System.Windows.Forms.DataGridView dataGridViewSenderImported;
        private System.Windows.Forms.DataGridView dataGridViewRecipientImported;
        private System.Windows.Forms.Button buttonSenderExport;
        private System.Windows.Forms.Button buttonSenderImport;
        private System.Windows.Forms.Button buttonSenderVerifyDecrypt;
        private System.Windows.Forms.Button buttonSenderSignEncrypt;
        private System.Windows.Forms.Button buttonRecipientSignEncrypt;
        private System.Windows.Forms.Button buttonRecipientVerifyDecrypt;
        private System.Windows.Forms.Button buttonRecipientExport;
        private System.Windows.Forms.Button buttonRecipientImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button buttonSenderNewKeypair;
        private System.Windows.Forms.Button buttonRecipientNewKeypair;
    }
}