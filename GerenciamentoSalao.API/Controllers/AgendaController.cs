using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.API.Controllers
{
    [Route("Agenda")]
    [ApiController]
    public class AgendaController : Controller
    {
        private readonly IAgendaApplicationService _service;

        public AgendaController(IAgendaApplicationService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] AgendaDTO agendaDto)
        {
            try
            {
                if (agendaDto == null)
                    return NotFound();

                _service.Add(agendaDto);
                return Ok("Funcionario Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] AgendaDTO agendaDto)
        {
            try
            {
                if (agendaDto == null)
                    return NotFound();
                _service.Update(agendaDto);
                return Ok("Funcionário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] AgendaDTO agendaDto)
        {
            try
            {
                if (agendaDto == null)
                    return NotFound();
                _service.Remove(agendaDto);
                return Ok("Funcionário removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
