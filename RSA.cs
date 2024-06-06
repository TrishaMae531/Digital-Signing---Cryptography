using System;
using System.Security.Cryptography;
using System.Text;

public class RsaService
{
    public (string privateKey, string publicKey) GenerateKeys()
    {
        using (RSA rsa = RSA.Create())
        {
            string privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());
            string publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
            return (privateKey, publicKey);
        }
    }

    public string SignData(string privateKey, string message)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportRSAPrivateKey(Convert.FromBase64String(privateKey), out _);
            byte[] data = Encoding.UTF8.GetBytes(message);
            byte[] signature = rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            return Convert.ToBase64String(signature);
        }
    }

    public bool VerifySignature(string publicKey, string message, string signature)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportRSAPublicKey(Convert.FromBase64String(publicKey), out _);
            byte[] data = Encoding.UTF8.GetBytes(message);
            byte[] signatureBytes = Convert.FromBase64String(signature);
            return rsa.VerifyData(data, signatureBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        }
    }
}
