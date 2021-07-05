using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; private set; }
    }
}
