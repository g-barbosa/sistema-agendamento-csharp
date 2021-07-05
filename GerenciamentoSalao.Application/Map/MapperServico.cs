using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoSalao.Infra.CrossCutting.Map
{
    public class MapperServico : IMapperServico
    {
        public Servico MapperDTOToEntity(ServicoDTO DTO)
        {
            var model = new Servico(
                DTO.Descricao,
                DTO.Preco);

            return model;
        }

        public ServicoDTO MapperEntityToDTO(Servico model)
        {
            var DTO = new ServicoDTO()
            {
                Id = model.Id,
                Descricao = model.Descricao,
                Preco = model.Preco,
            };

            return DTO;
        }

        public IEnumerable<ServicoDTO> MapperListDTO(IEnumerable<Servico> models)
        {
            var dto = models.Select(model => MapperEntityToDTO(model));
            return dto;
        }
    }
}
