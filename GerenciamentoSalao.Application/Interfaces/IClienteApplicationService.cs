using GerenciamentoSalao.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IClienteApplicationService
    {
        void Add(ClienteDTO clienteDTO);
        void Update(ClienteDTO clienteDTO);
        void Remove(Guid id);
        IEnumerable<ClienteDTO> GetAll();
        ClienteDTO GetById(Guid id);
    }
}
