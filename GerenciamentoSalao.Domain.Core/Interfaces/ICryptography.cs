using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Domain.Core.Interfaces
{
    public interface ICryptography
    {
        string Encrypt(string value);
        bool Verify(string crypted, string value);
    }
}
