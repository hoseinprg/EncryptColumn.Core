using System;
namespace EncryptColumn.Core.Interfaces
{
    public interface IEncryptionProvider
    {
        string Encrypt(string dataToEncrypt);
        string Decrypt(string dataToDecrypt);
    }
}
