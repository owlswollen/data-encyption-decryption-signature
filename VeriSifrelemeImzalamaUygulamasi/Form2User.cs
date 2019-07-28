using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form2User : Form
    {
        private bool isSender;
        private DataGridView dataGridViewUser, dataGridViewImported;

        private string directoryName;
        private string filePath;
        private string importedFilePath;
        private Certificate user = null;
        public List<Certificate> users = null;
        public List<Certificate> importedUsers = null;

        public Form2User(bool isSender)
        {
            InitializeComponent();

            this.isSender = isSender;
            if (isSender)
            {
                groupBoxSender.Visible = true;
                groupBoxRecipient.Visible = false;
                dataGridViewUser = dataGridViewSender;
                dataGridViewImported = dataGridViewSenderImported;
                this.Text = "Gönderen";
                directoryName = "Sender\\";
                filePath = FileDirectory.Create("Sender\\") + "Senders.txt";
                importedFilePath = FileDirectory.Create("Sender\\") + "ImportedRecipients.txt";
            }
            else
            {
                groupBoxSender.Visible = false;
                groupBoxRecipient.Visible = true;
                dataGridViewUser = dataGridViewRecipient;
                dataGridViewImported = dataGridViewRecipientImported;
                this.Text = "Alıcı";
                directoryName = "Recipient\\";
                filePath = FileDirectory.Create("Recipient\\") + "Recipients.txt";
                importedFilePath = FileDirectory.Create("Recipient\\") + "ImportedSenders.txt";
            }

            // Aktif kullanicinin (gonderen / alici) sertifikalarinin listelenmesi ve passphrase'lerinin dosyadan okunmasi 
            users = File.Exists(filePath) ? Serialization.ReadFromBinaryFile<List<Certificate>>(filePath) : new List<Certificate>();

            importedUsers = File.Exists(importedFilePath) ? Serialization.ReadFromBinaryFile<List<Certificate>>(importedFilePath) : new List<Certificate>();
            foreach (Certificate cert in users)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(FileDirectory.Create(directoryName) + "Passphrases\\"); // try catch
                FileInfo[] files = dirInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.Name.Equals(cert.ID))
                    {
                        cert.hashedPassphrase = File.ReadAllBytes(FileDirectory.Create(directoryName) + "Passphrases\\" + cert.ID);
                        break;
                    }
                }

                int dgvColumnIndex = isSender ? 0 : 5;
                ListCertsOnDataGrid(cert, dataGridViewUser, dgvColumnIndex);
            }
            foreach (Certificate cert in importedUsers)
            {
                int dgvColumnIndex = isSender ? 10 : 15;
                ListCertsOnDataGrid(cert, dataGridViewImported, dgvColumnIndex);
            }
        }

        // Sifrelenecek / imzalanacak dosyanin ve imzalayan & alici sertifikalarinin secilmesi
        private void buttonSignEncrypt_Click(object sender, EventArgs e) //
        {
            string filepathToEncrypt = "";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Şifrelemek / İmzalamak İçin Dosya Seçiniz",
                Filter = "All files(*.*) | *.*",
                InitialDirectory = @"C:\"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepathToEncrypt = openFileDialog.FileName;
                Form5SignEncrypt formSignEncrypt = new Form5SignEncrypt(filepathToEncrypt, users, importedUsers);
                formSignEncrypt.Show(this);
                ListCertsOnComboBox(users, formSignEncrypt.comboBoxSender);
                ListCertsOnComboBox(importedUsers, formSignEncrypt.comboBoxRecipient);
            }
        }

        // Imzalayan & alici sertifikalarinin listelenmesi
        private void ListCertsOnComboBox(List<Certificate> users, ComboBox comboBox)
        {
            foreach (Certificate cert in users)
            {
                string userInfo = cert.Name;
                if (!cert.Comment.Equals(""))
                {
                    userInfo += " (" + cert.Name + ")";
                }
                if (!cert.Email.Equals(""))
                {
                    userInfo += " <" + cert.Email + ">";
                }
                userInfo += " (Oluşturulma: " + cert.ValidFrom + ")";
                comboBox.Items.Add(userInfo);
                comboBox.SelectedIndex = 0;
            }
        }

        // Desifrelenecek / dogrulanacak dosyanin secilmesi
        private void buttonVerifyDecrypt_Click(object sender, EventArgs e)
        {
            string filepathToDecrypt = "";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Deşifrelemek / Doğrulamak İçin Dosya Seçiniz",
                Filter = "(*.enc, *.sig) | *.enc; *.sig",
                InitialDirectory = FileDirectory.Create(@"Recipient\ReceivedFiles")
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepathToDecrypt = openFileDialog.FileName;
                Form6VerifyDecrypt formVerifyDecrypt = new Form6VerifyDecrypt(filepathToDecrypt, users, importedUsers);
                formVerifyDecrypt.Show(this);
            }
        }

        // Yeni anahtar olusturma islemleri
        Form3PersonalDetails formPersonalDetails;
        private void buttonNewKeypair_Click(object sender, EventArgs e)
        {
            formPersonalDetails = new Form3PersonalDetails();
            formPersonalDetails.FormClosed += formPersonalDetails_FormClosed;
            formPersonalDetails.Show(this);
        }

        private void formPersonalDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formPersonalDetails.DialogResult == DialogResult.OK)
            {
                string name = formPersonalDetails.textBoxName.Text;
                string email = formPersonalDetails.textBoxEmail.Text;
                string comment = formPersonalDetails.textBoxComment.Text;
                string passphrase = formPersonalDetails.textBoxPassphrase.Text; 
                user = new Certificate(name, email, comment, passphrase);
                users.Add(user);
                Serialization.WriteToBinaryFile(filePath, users, false);
                user.SavePrivateKey(directoryName, Encoding.ASCII.GetBytes(passphrase));
                Directory.CreateDirectory(FileDirectory.Create(directoryName) + "Passphrases\\");
                File.WriteAllBytes(FileDirectory.Create(directoryName) + "Passphrases\\" + user.ID, user.hashedPassphrase);

                int dgvColumnIndex = isSender ? 0 : 5;
                ListCertsOnDataGrid(user, dataGridViewUser, dgvColumnIndex);
            }
        }

        // Sertifiklarain data grid'lerde listelenmesi
        private void ListCertsOnDataGrid(Certificate user, DataGridView dataGridView, int columnIndex)
        {
            int index = dataGridView.Rows.Add();
            dataGridView.Rows[index].Cells["Column" + columnIndex++].Value = user.Name;
            if (!user.Comment.Equals(""))
            {
                dataGridView.Rows[index].Cells["Column" + (columnIndex - 1)].Value += " (" + user.Comment + ")";
            }
            dataGridView.Rows[index].Cells["Column" + columnIndex++].Value = user.Email;
            dataGridView.Rows[index].Cells["Column" + columnIndex++].Value = user.ValidFrom.ToString("dd.MM.yyyy");
            dataGridView.Rows[index].Cells["Column" + columnIndex++].Value = user.ValidUntil.ToString("dd.MM.yyyy");
            dataGridView.Rows[index].Cells["Column" + columnIndex++].Value = user.ID;
        }

        // Gonderenin sertifikalarini disa aktarmasi
        private void buttonSenderExport_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(FileDirectory.Create("Recipient\\") + "ReceivedCertificates\\");
            ExportCertificate(dataGridViewSender, users);
        }

        // Gonderenin mevcut sertifiklari ice aktarmasi
        private void buttonSenderImport_Click(object sender, EventArgs e)
        {
            try
            {
                Certificate user = ImportCertificate();
                if (user != null)
                {
                    importedUsers.Add(user);
                    Serialization.WriteToBinaryFile(FileDirectory.Create("Sender\\") + "ImportedRecipients.txt", importedUsers, false);
                    int columnIndex = isSender ? 10 : 15;
                    ListCertsOnDataGrid(user, dataGridViewImported, columnIndex);
                }
            }
            catch
            {
                return;
            }
        }

        // Alicinin sertifiklarini disa aktarmasi
        private void buttonRecipientExport_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(FileDirectory.Create("Sender\\") + "ReceivedCertificates\\");
            ExportCertificate(dataGridViewRecipient, users);
        }

        // Alicinin mevcut sertifikalari ice aktarmasi
        private void buttonRecipientImport_Click(object sender, EventArgs e)
        {
            try
            {
                Certificate user = ImportCertificate();
                if (user != null)
                {
                    importedUsers.Add(user);
                    Serialization.WriteToBinaryFile(FileDirectory.Create("Recipient\\") + "ImportedSenders.txt", importedUsers, false);
                    int columnIndex = isSender ? 10 : 15;
                    ListCertsOnDataGrid(user, dataGridViewImported, columnIndex);
                }
            }
            catch
            {
                return;
            }
        }

        // Secilen sertifikayi disa aktar
        private void ExportCertificate(DataGridView dataGridView, List<Certificate> users)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            string sendTo = isSender ? "Recipient\\" : "Sender\\";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Dışa Aktar",
                InitialDirectory = FileDirectory.Create(sendTo) + "ReceivedCertificates\\",
                FileName = users[index].ID + ".asc",
                //Filter = "(*.asc) | *.asc"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Serialization.WriteToBinaryFile(saveFileDialog.FileName, users[index], false);
            }
        }

        // Secilen sertifikayi ice aktar
        private Certificate ImportCertificate()
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "İçe Aktar",
                Filter = "(*.asc) | *.asc",
                InitialDirectory = FileDirectory.Create(directoryName) + "ReceivedCertificates\\",
            };
            Certificate user = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                user = Serialization.ReadFromBinaryFile<Certificate>(openFileDialog.FileName);
            }
            return user;
        }

        // Farkli sertifika tipleri icin var olan seceneklerin belirlenmesi
        private void tabControlSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSenderExport.Enabled = (tabControlSender.SelectedTab == tabPageSenderMyCerts) ? true : false;
        }

        private void tabControlRecipient_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRecipientExport.Enabled = (tabControlRecipient.SelectedTab == tabPageRecipientMyCerts) ? true : false;
        }
    }
}