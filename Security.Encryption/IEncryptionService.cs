using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Encryption
{
    public interface IEncryptionService
    {
        string CreateSalt();
        string EncryptPassword(string password, string salt);
    }
}
