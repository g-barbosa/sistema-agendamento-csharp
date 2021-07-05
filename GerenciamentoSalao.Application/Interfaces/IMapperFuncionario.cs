using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System.Collections.Generic;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperFuncionario
    {
        Funcionario MapperDTOToEntity(FuncionarioDTO DTO);
        IEnumerable<FuncionarioDTO> MapperListDTO(IEnumerable<Funcionario> entities);
        FuncionarioDTO MapperEntityToDTO(Funcionario entity);
    }
}
