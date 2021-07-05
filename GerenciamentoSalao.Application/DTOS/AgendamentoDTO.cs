﻿using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.DTOS
{
    public class AgendamentoDTO : IDTORoot
    {
        public Guid Id { get; set; }
        public Guid ProdutoId { get; set; }
        public Guid ServicoId { get; set; }
        public Guid AgendaId { get; set; }

        public Produto Produto { get; private set; }
        public Servico Servico { get; private set; }
        public Agenda Agenda { get; private set; }
    }
}
