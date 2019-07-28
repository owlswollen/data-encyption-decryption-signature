using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form6VerifyDecrypt : Form
    {
        string filepath;
        string outputPath;
        string signedEncryptedDir;
        string verifiedDecryptedDir;
        string fileName;

        List<Certificate> currentUsers;
        List<Certificate> currentImportedUsers;

        public Form6VerifyDecrypt(string filepath, List<Certificate> currentUsers, List<Certificate> currentImportedUsers)
        {
            InitializeComponent();

            this.filepath = filepath;
            string[] pathSplit = filepath.Split('\\').Last().Split('.');
            fileName = "";
            for (int i = 0; i < pathSplit.Length - 2; i++)
            {
                fileName += pathSplit[i] + ".";
            }
            fileName += pathSplit[pathSplit.Length - 2];
            string[] temp = filepath.Split('\\');
            signedEncryptedDir = FileDirectory.Create("Recipient\\ReceivedFiles\\") + temp[temp.Length - 2] + "\\";
            verifiedDecryptedDir = FileDirectory.Create("Recipient\\VerifiedDecryptedFiles\\");
            outputPath = verifiedDecryptedDir + fileName;
            textBoxPath.Text = outputPath;

            this.currentUsers = currentUsers;
            this.currentImportedUsers = currentImportedUsers;
        }

        // Desifrelenecek / dogrulanacak dosyanin kayit yerinin secilmesi
        private void buttonFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Kaydet",
                InitialDirectory = verifiedDecryptedDir,
                FileName = fileName,
                //Filter = "" //
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = saveFileDialog.FileName;
            }
        }

        Certificate recipient = null;
        Certificate importedSender = null;
        byte[] encryptedData = null;
        byte[] encryptedPassphrase = null;
        int verificationSuccess = 0;
        int decryptionSuccess = 0;
        bool fileFound = false;
        private void buttonVerifyDecrypt_Click(object senderObject, EventArgs e)
        {
            outputPath = textBoxPath.Text;
            if (outputPath.Equals(""))
            {
                MessageBox.Show("Bir çıktı dosyası belirtiniz.");
                return;
            }
            if (File.Exists(outputPath))
            {
                MessageBox.Show("Aynı isimde başka bir dosya mevcut. Lütfen başka bir isim seçiniz.");
                return;
            }

            // Gonderen ve alici id'lerinin alinarak hangi sertifikalara ait oldugunun belirlenmesi
            try
            {
                string recipientID = File.ReadAllText(signedEncryptedDir + "recipient.txt");
                foreach (Certificate user in currentUsers)
                {
                    if (user.ID.Equals(recipientID))
                    {
                        recipient = user;
                        break;
                    }
                }
                string importedSenderID = File.ReadAllText(signedEncryptedDir + "sender.txt");
                foreach (Certificate user in currentImportedUsers)
                {
                    if (user.ID.Equals(importedSenderID))
                    {
                        importedSender = user;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kullanıcı sertifikaları bulunamadı.");
                return;
            }

            // Dosyalari desifreleme ve dogrulama
            if (File.Exists(signedEncryptedDir + fileName + ".enc") && File.Exists(signedEncryptedDir + fileName + ".sig"))
            {
                fileFound = true;
                try
                {
                    recipient.rsaPrivateKeyInfo = recipient.GetPrivateKey("Recipient\\", this);
                    encryptedData = File.ReadAllBytes(signedEncryptedDir + fileName + ".enc");
                    encryptedPassphrase = File.ReadAllBytes(signedEncryptedDir + "password");

                    byte[] decryptedData = recipient.DecryptFile(encryptedData, encryptedPassphrase);
                    File.WriteAllBytes(outputPath, decryptedData);

                    byte[] signedBytes = File.ReadAllBytes(signedEncryptedDir + fileName + ".sig");

                    decryptionSuccess = 1;
                    try
                    {
                        verificationSuccess = recipient.VerifyData(decryptedData, signedBytes, importedSender.rsaPublicKeyInfo) ? 1 : -1;
                        if (verificationSuccess == -1)
                        {
                            MessageBox.Show("Dosya doğrulanamadı.");
                        }
                        else if (decryptionSuccess == -1)
                        {
                            MessageBox.Show("Dosya deşifrelenemedi.");
                        }
                    }
                    catch
                    {
                        verificationSuccess = -1;
                        MessageBox.Show("Dosya doğrulanamadı.");
                    }
                }
                catch
                {
                    decryptionSuccess = -1;
                    verificationSuccess = -1;
                }
            }
            // Sadece desifreleme
            if (File.Exists(signedEncryptedDir + fileName + ".enc") && !File.Exists(signedEncryptedDir + fileName + ".sig"))
            {
                fileFound = true;
                try
                {
                    recipient.rsaPrivateKeyInfo = recipient.GetPrivateKey("Recipient\\", this);
                    encryptedData = File.ReadAllBytes(filepath);
                    encryptedPassphrase = File.ReadAllBytes(signedEncryptedDir + "password");

                    byte[] decryptedData = recipient.DecryptFile(encryptedData, encryptedPassphrase);
                    File.WriteAllBytes(outputPath, decryptedData);

                    decryptionSuccess = 1;
                }
                catch
                {
                    decryptionSuccess = -1;

                }
                verificationSuccess = 0;
            }
            // Sadece imza dogrulama
            if (!File.Exists(signedEncryptedDir + fileName + ".enc") && File.Exists(signedEncryptedDir + fileName + ".sig"))
            {
                fileFound = true;
                try
                {
                    byte[] bytesToVerify = File.ReadAllBytes(signedEncryptedDir + fileName); 
                    byte[] signedBytes = File.ReadAllBytes(filepath);
                    verificationSuccess = recipient.VerifyData(bytesToVerify, signedBytes, importedSender.rsaPublicKeyInfo) ? 1 : -1;
                    if (verificationSuccess == 1)
                    {
                        File.WriteAllBytes(outputPath, bytesToVerify);
                    }
                }
                catch
                {
                    verificationSuccess = -1;
                }
                decryptionSuccess = 0;
            }

            if (!fileFound)
            {
                decryptionSuccess = -1;
                verificationSuccess = -1;
            }

            Form7Results formResults = new Form7Results();
            ShowResults(formResults.labelTitle, formResults.labelResult, formResults.labelStrikeout, formResults.panel, formResults.progressBar, formResults.buttonOpenFile);
            formResults.buttonOpenFile.Visible = true;
            formResults.ShowDialog();
            if (formResults.DialogResult == DialogResult.OK)
            {
                try
                {
                    System.Diagnostics.Process.Start(outputPath);
                }
                catch
                {
                    MessageBox.Show("Dosya açılamıyor.");
                }
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(outputPath);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            textBoxPath.Text = "";
        }

        // Islem sonuclari
        private void ShowResults(Label labelTitle, Label labelResult, Label labelStrikeout, Panel panel, ProgressBar progressBar, Button buttonOpenFile)
        {
            if (decryptionSuccess == 1 && verificationSuccess == 1)
            {
                labelTitle.Text = "Deşifreleme ve doğrulama tamamlandı.";
                labelResult.Text = fileName + ".enc → " + fileName + ":\nDeşifreleme ve doğrulama tamamlandı.\n";
                labelResult.Text += "İmzalayan: " + importedSender.Name + "\n\n";
                labelResult.Text += "İmza oluşturulma zamanı: " + DateTime.Now + "\n";
                labelResult.Text += "Sertifika:\n";
                labelResult.Text += importedSender.Name + " (" + importedSender.ID + ")\n";
                labelResult.Text += "İmza geçerli ve güvenilir bir sertifika tarafından oluşturulmuştur.";
            }
            if (decryptionSuccess == 1 && (verificationSuccess == 0 || verificationSuccess == -1))
            {
                labelTitle.Text = "Deşifreleme tamamlandı.";
                labelResult.Text = fileName + ".enc → " + fileName + ":\nDeşifreleme tamamlandı.\n\n";
                labelResult.Text += "Not: Dosya imzalı değil.";
            }
            if (verificationSuccess == 1 && (decryptionSuccess == 0 || decryptionSuccess == -1))
            {
                labelTitle.Text = "Doğrulama tamamlandı.";
                labelResult.Text = fileName + ".enc → " + fileName + ":\nDoğrulama tamamlandı.\n\n";
                labelResult.Text += "Not: Deşifreleme başarısız.";
            }
            if (decryptionSuccess == 0 && verificationSuccess == 1)
            {
                labelTitle.Text = "Doğrulama tamamlandı.";
                labelResult.Text = fileName + ".sig → " + fileName + ":\nDoğrulama tamamlandı.\n";
                labelResult.Text += "İmzalayan: " + importedSender.Name + "\n\n";
                labelResult.Text += "İmza oluşturulma zamanı: " + DateTime.Now + "\n";
                labelResult.Text += "Sertifika:\n";
                labelResult.Text += importedSender.Name + " (" + importedSender.ID + ")\n";
                labelResult.Text += "İmza geçerli ve güvenilir bir sertifika tarafından oluşturulmuştur.";
            }
            if (decryptionSuccess == -1 && verificationSuccess == -1)
            {
                labelTitle.Text = "Deşifreleme ve doğrulama başarısız.";
                labelStrikeout.Text = fileName + ".enc → " + fileName;
            }
            if (decryptionSuccess == 0 && verificationSuccess == -1)
            {
                labelTitle.Text = "Doğrulama başarısız.";
                labelStrikeout.Text = fileName + ".sig → " + fileName;
            }
            if (decryptionSuccess == -1 && verificationSuccess == 0)
            {
                labelTitle.Text = "Deşifreleme başarısız.";
                labelStrikeout.Text = fileName + ".enc → " + fileName;
            }

            buttonOpenFile.Visible = true;
            if (decryptionSuccess == 1 || verificationSuccess == 1)
            {
                progressBar.Value = 1;
                panel.BackColor = Color.FromArgb(192, 255, 192);
                labelResult.ForeColor = Color.Green;
                buttonOpenFile.Enabled = true;
                labelResult.Visible = true;
                labelStrikeout.Visible = false;
            }
            else
            {
                progressBar.Value = 0;
                panel.BackColor = Color.White;
                labelStrikeout.ForeColor = Color.Black;
                buttonOpenFile.Enabled = false;
                labelResult.Visible = false;
                labelStrikeout.Visible = true;
            }
        }
    }
}
