using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IAccountApplicationService
    {
        dynamic Login(string login, string password);
    }
}
