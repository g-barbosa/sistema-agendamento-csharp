using GerenciamentoSalao.Domain.Core.Interfaces;

namespace GerenciamentoSalao.Domain.Core.DomainObjects
{
    public class Cryptography : ICryptography
    {
        public string Encrypt(string value)
        {
            var encryptedValue = BCrypt.Net.BCrypt.HashPassword(value);
            return encryptedValue;
        }

        public bool Verify(string crypted, string value)
        {
            bool isValid = BCrypt.Net.BCrypt.Verify(value, crypted);
            return isValid;
        }
    }
}
