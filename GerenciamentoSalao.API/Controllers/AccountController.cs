using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.DTO;
using GerenciamentoSalao.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.API.Controllers
{
    [Route("Account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountClienteApplicationService _clienteService;
        private readonly IAccountFuncionarioApplicationService _funcionarioService;
        public AccountController(IAccountClienteApplicationService clienteService, IAccountFuncionarioApplicationService funcionarioService)
        {
            _clienteService = clienteService;
            _funcionarioService = funcionarioService;
        }

        [HttpPost]
        [Route("cliente-login")]
        public ActionResult ClienteLogin([FromBody] LoginDTO DTO)
        {
            return Ok(_clienteService.Login(DTO));
        }

        [HttpPost]
        [Route("funcionario-login")]
        public ActionResult FuncionarioLogin([FromBody] LoginDTO DTO)
        {
            return Ok(_funcionarioService.Login(DTO));
        }
    }
}
