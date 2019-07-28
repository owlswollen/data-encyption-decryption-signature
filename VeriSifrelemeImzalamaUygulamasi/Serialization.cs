using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace VeriSifrelemeImzalamaUygulamasi
{
    // Sertifiklarin serialization islemleri icin
    class Serialization
    {
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }

    // RSA gizli anahtarinin sifrelenme ve serialization islemleri icin
    [Serializable]
    public class RSAParametersSerializable : ISerializable
    {
        private RSAParameters rsaParameters;

        public RSAParameters RSAParameters
        {
            get
            {
                return rsaParameters;
            }
        }

        public RSAParametersSerializable(RSAParameters rsaParameters)
        {
            this.rsaParameters = rsaParameters;
        }

        private RSAParametersSerializable()
        {
        }

        public byte[] D { get { return rsaParameters.D; } set { rsaParameters.D = value; } }

        public byte[] DP { get { return rsaParameters.DP; } set { rsaParameters.DP = value; } }

        public byte[] DQ { get { return rsaParameters.DQ; } set { rsaParameters.DQ = value; } }

        public byte[] Exponent { get { return rsaParameters.Exponent; } set { rsaParameters.Exponent = value; } }

        public byte[] InverseQ { get { return rsaParameters.InverseQ; } set { rsaParameters.InverseQ = value; } }

        public byte[] Modulus { get { return rsaParameters.Modulus; } set { rsaParameters.Modulus = value; } }

        public byte[] P { get { return rsaParameters.P; } set { rsaParameters.P = value; } }

        public byte[] Q { get { return rsaParameters.Q; } set { rsaParameters.Q = value; } }

        public RSAParametersSerializable(SerializationInfo information, StreamingContext context)
        {
            rsaParameters = new RSAParameters()
            {
                D = (byte[])information.GetValue("D", typeof(byte[])),
                DP = (byte[])information.GetValue("DP", typeof(byte[])),
                DQ = (byte[])information.GetValue("DQ", typeof(byte[])),
                Exponent = (byte[])information.GetValue("Exponent", typeof(byte[])),
                InverseQ = (byte[])information.GetValue("InverseQ", typeof(byte[])),
                Modulus = (byte[])information.GetValue("Modulus", typeof(byte[])),
                P = (byte[])information.GetValue("P", typeof(byte[])),
                Q = (byte[])information.GetValue("Q", typeof(byte[]))
            };
        }

        public void Encrypt(byte[] passphrase)
        {
            D = AES256.AES_Encrypt(D, passphrase);
            DP = AES256.AES_Encrypt(DP, passphrase);
            DQ = AES256.AES_Encrypt(DQ, passphrase);
            Exponent = AES256.AES_Encrypt(Exponent, passphrase);
            InverseQ = AES256.AES_Encrypt(InverseQ, passphrase);
            Modulus = AES256.AES_Encrypt(Modulus, passphrase);
            P = AES256.AES_Encrypt(P, passphrase);
            Q = AES256.AES_Encrypt(Q, passphrase);
        }

        public void Decrypt(byte[] passphrase)
        {
            D = AES256.AES_Decrypt(D, passphrase);
            DP = AES256.AES_Decrypt(DP, passphrase);
            DQ = AES256.AES_Decrypt(DQ, passphrase);
            Exponent = AES256.AES_Decrypt(Exponent, passphrase);
            InverseQ = AES256.AES_Decrypt(InverseQ, passphrase);
            Modulus = AES256.AES_Decrypt(Modulus, passphrase);
            P = AES256.AES_Decrypt(P, passphrase);
            Q = AES256.AES_Decrypt(Q, passphrase);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("D", rsaParameters.D);
            info.AddValue("DP", rsaParameters.DP);
            info.AddValue("DQ", rsaParameters.DQ);
            info.AddValue("Exponent", rsaParameters.Exponent);
            info.AddValue("InverseQ", rsaParameters.InverseQ);
            info.AddValue("Modulus", rsaParameters.Modulus);
            info.AddValue("P", rsaParameters.P);
            info.AddValue("Q", rsaParameters.Q);
        }
    }
}
