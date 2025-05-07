using System;
using System.Security.Cryptography;

namespace Lab06
{
    public class RSA_Algorithm
    {
        public RSACryptoServiceProvider rsa;

        // Function to generate RSA key pair
        public void GenerateKeys()
        {
            rsa = new RSACryptoServiceProvider(2048);
        }

        // Function to get RSA public key parameters
        public RSAParameters GetPublicKey()
        {
            return rsa.ExportParameters(false);
        }

        // Function to get RSA private key parameters
        public RSAParameters GetPrivateKey()
        {
            return rsa.ExportParameters(true);
        }

        // Function to encrypt data using RSA public key
        public byte[] EncryptData(byte[] data, RSAParameters publicKey)
        {
            rsa.ImportParameters(publicKey);
            return rsa.Encrypt(data, true);
        }

        // Function to decrypt data using RSA private key
        public byte[] DecryptData(byte[] data, RSAParameters privateKey)
        {
            rsa.ImportParameters(privateKey);
            return rsa.Decrypt(data, true);
        }
    }
}
