using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.API.Controllers
{
    [Route("Financas")]
    [Authorize(Roles = "Funcionario")]
    [ApiController]
    public class FinancasController : Controller
    {
        private readonly IFinancasApplicationService _service;

        public FinancasController(IFinancasApplicationService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_service.Get());
        }
    }
}
