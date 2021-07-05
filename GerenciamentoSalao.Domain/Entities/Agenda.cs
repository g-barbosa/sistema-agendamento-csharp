using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Agenda : Entity
    {
        public DateTime Data { get; private set; }
        public Guid FuncionarioId { get; private set; }
        public Guid ClienteId { get; private set; }

        public Funcionario Funcionario { get; private set; }
        public Cliente Cliente { get; private set; }

        protected Agenda() { }

        public Agenda(DateTime data, Guid funcionarioId, Guid clienteId)
        {
            Data = data;
            FuncionarioId = funcionarioId;
            ClienteId = clienteId;
        }

        public void AlterarData(DateTime data)
        {
            Data = data;
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            FuncionarioId = funcionario.Id;
            Funcionario = funcionario;
        }
    }
}
