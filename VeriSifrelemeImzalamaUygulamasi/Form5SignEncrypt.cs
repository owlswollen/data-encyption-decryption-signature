using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form5SignEncrypt : Form
    {
        private string filepath;
        string fileName;
        string signedEncryptedDirectory;
        string extension;
        string outputPath;

        List<Certificate> currentUsers;
        List<Certificate> currentImportedUsers;

        public string signedFolder, signedPathToOutput;
        public Form5SignEncrypt(string filepath, List<Certificate> currentUsers, List<Certificate> currentImportedUsers)
        {
            InitializeComponent();

            this.filepath = filepath;
            if (filepath.Equals(""))
            {
                Close();
            }
            fileName = filepath.Split('\\').Last();
            string dirName = "";
            string[] temp = fileName.Split('.');
            for (int i = 0; i < temp.Length - 2; i++)
            {
                dirName += temp[i] + ".";
            }
            dirName += temp[temp.Length - 2];
            signedEncryptedDirectory = FileDirectory.Create("Recipient\\ReceivedFiles\\" + dirName + "\\");
            outputPath = signedEncryptedDirectory + fileName;
            CheckBoxControl();

            this.currentUsers = currentUsers;
            this.currentImportedUsers = currentImportedUsers;
        }

        Certificate importedRecipient = null;
        Certificate sender = null;

        // Sifrelenecek / imzalanacak dosyanin kayit yerinin secilmesi
        private void buttonFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Kaydet",
                InitialDirectory = signedEncryptedDirectory,
                FileName = fileName + extension,
                //Filter = ""
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = saveFileDialog.FileName;
            }
        }

        int encryptionSuccess = 0;
        int signingSuccess = 0;
        private void buttonSignEncrypt_Click(object senderObject, EventArgs e)
        {
            if (textBoxPath.Text.Equals(""))
            {
                MessageBox.Show("Bir çıktı dosyası belirtiniz.");
                return;
            }
            outputPath = textBoxPath.Text.Remove(textBoxPath.Text.LastIndexOf('.'));
            signedEncryptedDirectory = outputPath.Remove(outputPath.LastIndexOf('\\')) + "\\";
            if (File.Exists(textBoxPath.Text))
            {
                MessageBox.Show("Bu dizinde aynı isimli dosyalar mevcut. Lütfen başka bir dizin seçiniz.");
                return;
            }

            importedRecipient = currentImportedUsers[comboBoxRecipient.SelectedIndex];
            sender = currentUsers[comboBoxSender.SelectedIndex];
            // Gonderen ve alici sertifika id'leri, alicinin kendi sertifiklari ve import ettigi sertifiklar arasindan 
            // hangileriyle islem yapilacaginin belirlenmesi icin sifrelenen dosyalarla birlikte gonderiliyor.
            try
            {
                File.WriteAllText(signedEncryptedDirectory + "sender.txt", sender.ID);
                File.WriteAllText(signedEncryptedDirectory + "recipient.txt", importedRecipient.ID);
            }
            catch
            {
                MessageBox.Show("Kullanıcı dizini bulunamadı.");
            }

            byte[] originalData = null;
            try
            {
                originalData = File.ReadAllBytes(filepath);
            }
            catch
            {
                MessageBox.Show("Seçilen dosya bulunamadı.");
                return;
            }

            // Veriyi sifrele
            if (checkBoxEncrypt.Checked && !checkBoxSign.Checked)
            {
                try
                {
                    byte[][] encryptedData = sender.EncryptFile(originalData, importedRecipient.rsaPrivateKeyInfo);
                    File.WriteAllBytes(outputPath + ".enc", encryptedData[0]);
                    File.WriteAllBytes(signedEncryptedDirectory + "password", encryptedData[1]);
                    encryptionSuccess = 1;
                }
                catch
                {
                    encryptionSuccess = -1;
                }
                signingSuccess = 0;

            }
            // Veriyi imzala
            if (checkBoxSign.Checked && !checkBoxEncrypt.Checked)
            {
                try
                {
                    sender.rsaPrivateKeyInfo = sender.GetPrivateKey("Sender\\", this);
                    byte[] signedData = sender.SignData(originalData);

                    File.WriteAllBytes(outputPath + ".sig", signedData);
                    File.Copy(filepath, outputPath);

                    signingSuccess = 1;
                }
                catch
                {
                    signingSuccess = -1;
                }
                encryptionSuccess = 0;
 
            }
            // Sifrele & imzala
            if (checkBoxSign.Checked && checkBoxEncrypt.Checked)
            {
                try
                {
                    sender.rsaPrivateKeyInfo = sender.GetPrivateKey("Sender\\", this);
                    byte[] signedData = sender.SignData(originalData);
                    File.WriteAllBytes(outputPath + ".sig", signedData);

                    signingSuccess = 1;
                }
                catch
                {
                    signingSuccess = -1;
                }

                try
                {
                    byte[][] encryptedData = sender.EncryptFile(originalData, importedRecipient.rsaPublicKeyInfo);
                    File.WriteAllBytes(outputPath + ".enc", encryptedData[0]);
                    File.WriteAllBytes(signedEncryptedDirectory + "password", encryptedData[1]);

                    encryptionSuccess = 1;
                }
                catch
                {
                    encryptionSuccess = -1;
                }
            }

            Form7Results formResults = new Form7Results();
            ShowResults(formResults.labelTitle, formResults.labelResult, formResults.labelStrikeout, formResults.panel, formResults.progressBar, formResults.buttonOpenFile);
            formResults.Show();
            Close();
        }

        private void checkBoxSign_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxControl();
        }
        private void checkBoxEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxControl();
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            textBoxPath.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBoxControl()
        {
            if (checkBoxSign.Checked)
            {
                extension = ".sig";
            }
            else if (checkBoxEncrypt.Checked)
            {
                extension = ".enc";
            }
            else
            {
                extension = "";
            }
            textBoxPath.Text = outputPath + extension;
        }

        // Islem sonuclari
        private void ShowResults(Label labelTitle, Label labelResult, Label labelStrikeout, Panel panel, ProgressBar progressBar, Button buttonOpenFile)
        {
            if (encryptionSuccess == 1 && signingSuccess == 1)
            {
                labelTitle.Text = "Şifreleme ve imzalama tamamlandı.";
                labelResult.Text = fileName + " → " + fileName + ".enc:\nŞifreleme ve imzalama tamamlandı.\n";
            }
            if (encryptionSuccess == 1 && (signingSuccess == 0 || signingSuccess == -1))
            {
                labelTitle.Text = "Şifreleme tamamlandı.";
                labelResult.Text = fileName + " → " + fileName + ".enc:\nŞifreleme tamamlandı.\n";
                if (signingSuccess == -1)
                {
                    labelResult.Text += "\nİmza oluşturulamadı.\n";
                }
            }
            if (signingSuccess == 1 && (encryptionSuccess == 0 || encryptionSuccess == -1))
            {
                labelTitle.Text = "İmzalama tamamlandı.";
                labelResult.Text = fileName + " → " + fileName + ".sig:\nİmzalama tamamlandı.\n";
                if (encryptionSuccess == -1)
                {
                    labelResult.Text += "\nŞifreleme başarısız.\n";
                }
            }
            if (encryptionSuccess == -1 && signingSuccess == 0)
            {
                labelTitle.Text = "Şifreleme başarısız.";
                labelStrikeout.Text = fileName + " → " + fileName + ".enc";
            }
            if (encryptionSuccess == 0 && signingSuccess == -1)
            {
                labelTitle.Text = "İmzalama başarısız.";
                labelStrikeout.Text = fileName + " → " + fileName + ".sig";
            }
            if (encryptionSuccess == -1 && signingSuccess == -1)
            {
                labelTitle.Text = "Şifreleme ve imzalama başarısız.\n";
                labelStrikeout.Text = fileName + " → " + fileName + ".enc";
            }

            buttonOpenFile.Visible = false;
            if (encryptionSuccess == 1 || signingSuccess == 1)
            {
                progressBar.Value = 1;
                panel.BackColor = Color.MediumBlue;
                labelResult.ForeColor = Color.White;
                labelResult.Visible = true;
                labelStrikeout.Visible = false;
            }
            else
            {
                progressBar.Value = 0;
                panel.BackColor = Color.White;
                labelResult.Visible = false;
                labelStrikeout.Visible = true;
                labelStrikeout.ForeColor = Color.Black;
            }
        }
    }
}
