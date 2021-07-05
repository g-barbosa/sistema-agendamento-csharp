using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.API.Controllers
{
    [Route("Servico")]
    [ApiController]
    public class ServicoController : Controller
    {
        private readonly IServicoApplicationService _service;

        public ServicoController(IServicoApplicationService service)
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
        public ActionResult Post([FromBody] ServicoDTO ServicoDTO)
        {
            try
            {
                if (ServicoDTO == null)
                    return NotFound();

                _service.Add(ServicoDTO);
                return Ok("Funcionario Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ServicoDTO ServicoDTO)
        {
            try
            {
                if (ServicoDTO == null)
                    return NotFound();
                _service.Update(ServicoDTO);
                return Ok("Funcionário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ServicoDTO ServicoDTO)
        {
            try
            {
                if (ServicoDTO == null)
                    return NotFound();
                _service.Remove(ServicoDTO);
                return Ok("Funcionário removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
