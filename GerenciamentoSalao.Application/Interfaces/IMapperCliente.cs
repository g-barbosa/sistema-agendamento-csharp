using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDTOToEntity(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes);
        ClienteDTO MapperEntityToDTO(Cliente cliente);
    }
}
