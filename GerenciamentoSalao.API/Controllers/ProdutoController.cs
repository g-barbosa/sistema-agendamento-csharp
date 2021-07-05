using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.API.Controllers
{
    [Route("Produto")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoApplicationService _service;

        public ProdutoController(IProdutoApplicationService service)
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
        public ActionResult Post([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();

                _service.Add(ProdutoDTO);
                return Ok("Funcionario Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();
                _service.Update(ProdutoDTO);
                return Ok("Funcionário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();
                _service.Remove(ProdutoDTO);
                return Ok("Funcionário removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
