using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.API.Controllers
{
    [Route("Funcionario")]
    [ApiController]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioApplicationService _service;

        public FuncionarioController(IFuncionarioApplicationService service)
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
        public ActionResult Post([FromBody] FuncionarioDTO funcionarioDTO)
        {
            try
            {
                if (funcionarioDTO == null)
                    return NotFound();

                _service.Add(funcionarioDTO);
                return Ok("Funcionario Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] FuncionarioDTO funcionarioDTO)
        {
            try
            {
                if (funcionarioDTO == null)
                    return NotFound();
                _service.Update(funcionarioDTO);
                return Ok("Funcionário atualizado com sucesso!");
            }
            catch(Exception ex)
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
                return Ok("Funcionário removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
