using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System.Collections.Generic;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperServico
    {
        Servico MapperDTOToEntity(ServicoDTO DTO);
        IEnumerable<ServicoDTO> MapperListDTO(IEnumerable<Servico> entities);
        ServicoDTO MapperEntityToDTO(Servico entity);
    }
}
