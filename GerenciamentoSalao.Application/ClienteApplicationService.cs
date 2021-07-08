using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteService _clienteService;
        private readonly IMapperCliente _mapperCliente;

        public ClienteApplicationService(IClienteService clienteService, IMapperCliente mapperCliente)
        {
            _clienteService = clienteService;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDTO clienteDTO)
        {
            var cliente = _mapperCliente.MapperDTOToEntity(clienteDTO);
            _clienteService.Add(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = _clienteService.GetAll();

            return _mapperCliente.MapperListDTO(clientes);
        }

        public ClienteDTO GetById(Guid id)
        {
            var cliente = _clienteService.GetById(id);
            return _mapperCliente.MapperEntityToDTO(cliente);
        }

        public void Remove(ClienteDTO clienteDTO)
        {
            var cliente = _mapperCliente.MapperDTOToEntity(clienteDTO);
            _clienteService.Remove(cliente);
        }

        public void Update(ClienteDTO clienteDTO)
        {
            var cliente = _mapperCliente.MapperDTOToEntity(clienteDTO);
            _clienteService.Update(cliente);
        }
    }
}
