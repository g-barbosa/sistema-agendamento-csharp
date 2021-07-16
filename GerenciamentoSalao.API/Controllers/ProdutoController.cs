﻿using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Funcionario")]
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
        public ActionResult Post([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();

                _service.Add(ProdutoDTO);
                return Ok("Produto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Authorize(Roles = "Funcionario")]
        public ActionResult Put([FromBody] ProdutoDTO ProdutoDTO)
        {
            try
            {
                if (ProdutoDTO == null)
                    return NotFound();
                _service.Update(ProdutoDTO);
                return Ok("Produto atualizado com sucesso!");
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
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
