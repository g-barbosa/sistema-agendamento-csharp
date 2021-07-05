using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoSalao.Infra.CrossCutting.Map
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDTOToEntity(ClienteDTO clienteDTO)
        {
            var cliente = new Cliente()
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Telefone = clienteDTO.Telefone,
                Login = clienteDTO.Login
            };

            return cliente;
        }

        public ClienteDTO MapperEntityToDTO(Cliente cliente)
        {
            var clienteDTO = new ClienteDTO()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Login = cliente.Login,
                Telefone = cliente.Telefone,
            };

            return clienteDTO;
        }

        public IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(cliente => MapperEntityToDTO(cliente));
            return dto;
        }
    }
}
