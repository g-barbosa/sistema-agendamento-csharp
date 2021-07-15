using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
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
        private readonly IAccountApplicationService _clienteService;
        private readonly IAccountApplicationService _funcionarioService;
        public AccountController(IAccountApplicationService clienteService, IAccountApplicationService funcionarioService)
        {
            _clienteService = clienteService;
            _funcionarioService = funcionarioService;
        }

        [HttpPost]
        [Route("cliente-login")]
        public ActionResult ClienteLogin([FromBody] string login, string password)
        {
            return _clienteService.Login(login, password);
        }

        [HttpPost]
        [Route("funcionario-login")]
        public ActionResult FuncionarioLogin([FromBody] string login, string password)
        {
            return _funcionarioService.Login(login, password);
        }
    }
}
