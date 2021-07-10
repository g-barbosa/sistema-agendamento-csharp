using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application
{
    public class ServicoApplicationService : IServicoApplicationService
    {
        private readonly IServicoService _service;
        private readonly IMapperServico _mapper;

        public ServicoApplicationService(IServicoService service, IMapperServico mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(ServicoDTO DTO)
        {
            var model = _mapper.MapperDTOToEntity(DTO);
            _service.Add(model);
        }

        public IEnumerable<ServicoDTO> GetAll()
        {
            var models = _service.GetAll();

            return _mapper.MapperListDTO(models);
        }

        public ServicoDTO GetById(Guid id)
        {
            var model = _service.GetById(id);
            if (model == null) throw new Exception("Não foi possível encontrar este serviço");

            return _mapper.MapperEntityToDTO(model);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public void Update(ServicoDTO DTO)
        {
            var model = _service.GetById(DTO.Id);
            model.AlterarPreco(DTO.Preco);
            model.AlterarDescricao(DTO.Descricao);
            _service.Update(model);
        }
    }
}
