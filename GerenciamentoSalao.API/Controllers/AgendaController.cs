using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.API.Controllers
{
    [Route("Agenda")]
    [Authorize]
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
                return Ok("Agenda Cadastrado com sucesso!");
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
                return Ok("Agenda atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _service.Remove(id);
                return Ok("Agenda removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
