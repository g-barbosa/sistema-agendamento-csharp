using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoSalao.Infra.CrossCutting.Map
{
    public class MapperFuncionario : IMapperFuncionario
    {
        public Funcionario MapperDTOToEntity(FuncionarioDTO DTO)
        {
            var model = new Funcionario(
                DTO.Nome,
                DTO.Telefone,
                DTO.Login,
                DTO.Password,
                DTO.Entrada,
                DTO.Saida);

            return model;
        }

        public FuncionarioDTO MapperEntityToDTO(Funcionario model)
        {
            var DTO = new FuncionarioDTO()
            {
                Id = model.Id,
                Nome = model.Nome,
                Login = model.Login,
                Telefone = model.Telefone,
            };

            return DTO;
        }

        public IEnumerable<FuncionarioDTO> MapperListDTO(IEnumerable<Funcionario> models)
        {
            var dto = models.Select(model => MapperEntityToDTO(model));
            return dto;
        }
    }
}
