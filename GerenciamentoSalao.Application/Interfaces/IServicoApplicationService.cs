using GerenciamentoSalao.Application.DTOS;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IServicoApplicationService
    {
        void Add(ServicoDTO servicoDTO);
        void Update(ServicoDTO servicoDTO);
        void Remove(Guid id);
        IEnumerable<ServicoDTO> GetAll();
        ServicoDTO GetById(Guid id);
    }
}
