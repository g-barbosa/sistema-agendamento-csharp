using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Funcionario")]
        public ActionResult<IEnumerable<string>> Get(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        [Authorize(Roles = "Funcionario")]
        public ActionResult Post([FromBody] ServicoDTO ServicoDTO)
        {
            try
            {
                if (ServicoDTO == null)
                    return NotFound();

                _service.Add(ServicoDTO);
                return Ok("Serviço Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Authorize(Roles = "Funcionario")]
        public ActionResult Put([FromBody] ServicoDTO ServicoDTO)
        {
            try
            {
                if (ServicoDTO == null)
                    return NotFound();
                _service.Update(ServicoDTO);
                return Ok("Serviço atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Funcionario")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _service.Remove(id);
                return Ok("Serviço removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
