using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult> Get()
        {
            return Ok(await _service.Get());
        }
    }
}
