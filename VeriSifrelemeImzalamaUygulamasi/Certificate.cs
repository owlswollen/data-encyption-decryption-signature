using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    /// <summary>
    /// Kullanilan algoritmalar:
    /// Simetrik sifremeleme: AES256.
    /// Asimetrik sifreleme: RSA 1024-bit key.
    /// Hash: Salted SHA256 - anahtar passphrase'lerinin saklanmasinda, SHA512 - veri imzalama icin.
    /// </summary>

    [Serializable]
    public class Certificate
    {
        // Passphrase ve RSA private key'i sertifikayla birlikte serialize edilmeyip kullanicilarin kendi dizinlerinde tutuldu.
        // RSA gizli anahtarlari AES256 ile sifrelenip bu sifrelemede kullanilan passphrase'ler salted SHA256 ile hash'lendi.
        [NonSerialized]
        public byte[] hashedPassphrase;
        [NonSerialized]
        public byte[] encryptedPrivateKey;
        public byte[] salt;
        public RSAParameters rsaPublicKeyInfo, rsaPrivateKeyInfo;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public string ID { get; set; }

        public Certificate(string name, string email, string comment, string passphrase)
        {
            Name = name;
            Email = email;
            Comment = comment;
            salt = RandomPassphrase(8);
            hashedPassphrase = SHA256Salted.GenerateSaltedHash(Encoding.ASCII.GetBytes(passphrase), salt);

            ValidFrom = DateTime.Today;
            ValidUntil = ValidFrom.AddYears(2);

            using (RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048))
            {
                rsaPublicKeyInfo = cryptoServiceProvider.ExportParameters(false);
                rsaPrivateKeyInfo = cryptoServiceProvider.ExportParameters(true);
            }

            // https://stackoverflow.com/a/42026123/5589417
            ID = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
        }

        // Veri sifreleme
        public byte[][] EncryptFile(byte[] buffer, RSAParameters recipientsRSAPublicKeyInfo)
        {
            byte[] encryptedFile;

            byte[] password = RandomPassphrase(8);
            encryptedFile = AES256.AES_Encrypt(buffer, password);
            byte[] encryptedPassword = RSA.RSAEncrypt(password, recipientsRSAPublicKeyInfo, false);
            byte[][] data = new byte[][] { encryptedFile, encryptedPassword };

            return data;
        }
        
        // Veri desifreleme
        public byte[] DecryptFile(byte[] buffer, byte[] encryptedPassphrase)
        {
            byte[] decryptedPassphrase = RSA.RSADecrypt(encryptedPassphrase, rsaPrivateKeyInfo, false);
            byte[] decrypted = AES256.AES_Decrypt(buffer, decryptedPassphrase);
            return decrypted;
        }

        // Veri imzalama
        // https://stackoverflow.com/q/8437288/5589417
        public byte[] SignData(byte[] originalData)
        {
            byte[] signedBytes = null;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                var encoder = new UTF8Encoding();
                try
                {
                    rsa.ImportParameters(rsaPrivateKeyInfo);
                    Thread.Sleep(1000); // delay
                    signedBytes = rsa.SignData(originalData, CryptoConfig.MapNameToOID("SHA512"));
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
            return signedBytes;
        }

        // Imza dogrulama
        public bool VerifyData(byte[] bytesToVerify, byte[] signedBytes, RSAParameters sendersRSAPublicKeyInfo)
        {
            bool success = false;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                var encoder = new UTF8Encoding();
                try
                {
                    rsa.ImportParameters(sendersRSAPublicKeyInfo);
                    SHA512Managed Hash = new SHA512Managed();
                    byte[] hashedData = Hash.ComputeHash(signedBytes);
                    success = rsa.VerifyData(bytesToVerify, CryptoConfig.MapNameToOID("SHA512"), signedBytes);
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
            return success;
        }

        // RSA private key'lerin dosyaya yazilmasi
        public void SavePrivateKey(string dirName, byte[] passphrase)
        {
            RSAParametersSerializable rsaPrivateKeyInfoSerializable = new RSAParametersSerializable(rsaPrivateKeyInfo);
            rsaPrivateKeyInfoSerializable.Encrypt(passphrase);
            Directory.CreateDirectory(FileDirectory.Create(dirName) + "Keys\\");
            Serialization.WriteToBinaryFile(FileDirectory.Create(dirName) + "Keys\\" + ID, rsaPrivateKeyInfoSerializable, false);
        }

        // RSA private key'lerin dosyadan okunmasi
        public RSAParameters GetPrivateKey(string dirName, Form form)
        {
            RSAParametersSerializable rsaPrivateKeyInfoSerializable = null;

            DirectoryInfo dirInfo = new DirectoryInfo(FileDirectory.Create(dirName) + "Keys\\");
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Name.Equals(ID))
                {
                    rsaPrivateKeyInfoSerializable = Serialization.ReadFromBinaryFile<RSAParametersSerializable>(FileDirectory.Create(dirName) + "Keys\\" + ID);
                }
            }

            Form8Passphrase formPassphrase = new Form8Passphrase(Name);
            bool invalidPass = true;
            int tryCount = 1;
            while (invalidPass && tryCount <= 3)
            {
                formPassphrase.labelTry.Visible = (tryCount == 2 || tryCount == 3) ? true : false;
                formPassphrase.labelTry.Text = "Yanlış parola. Deneme: " + tryCount  + " / 3.";
                formPassphrase.ShowDialog(form);
                byte[] passphrase = null;
                if (formPassphrase.DialogResult == DialogResult.OK)
                {
                    passphrase = Encoding.ASCII.GetBytes(formPassphrase.textBoxPassphrase.Text);
                    byte[] hashedInputPassphrase = SHA256Salted.GenerateSaltedHash(passphrase, salt);
                    if (SHA256Salted.CompareByteArrays(hashedInputPassphrase, hashedPassphrase))
                    {
                        rsaPrivateKeyInfoSerializable.Decrypt(passphrase);
                        invalidPass = false;
                    }
                    else
                    {
                        invalidPass = true;
                        tryCount++;
                    }
                }
                else
                {
                    break;
                } 
            }
            if (tryCount > 3)
            {
                return new RSAParameters();
            }
            return rsaPrivateKeyInfoSerializable.RSAParameters;
        }

        // Rastgele anahtar parolasi uretilmesi
        static Random random = new Random();
        public static byte[] RandomPassphrase(int length)
        {
            string chars = "~!@#$%^&*()_+-[]{}|=./?<>\\abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string temp = "";
            for (int i = 0; i < length; i++)
            {
                temp += chars[random.Next(chars.Length)];
            }
            return Encoding.ASCII.GetBytes(temp);
        }
    }
}
