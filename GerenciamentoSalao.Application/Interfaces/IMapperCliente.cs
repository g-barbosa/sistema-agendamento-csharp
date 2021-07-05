using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System.Collections.Generic;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDTOToEntity(ClienteDTO DTO);
        IEnumerable<ClienteDTO> MapperListDTO(IEnumerable<Cliente> entities);
        ClienteDTO MapperEntityToDTO(Cliente entity);
    }
}
