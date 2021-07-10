using Autofac;
using GerenciamentoSalao.Application;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.DomainObjects;
using GerenciamentoSalao.Domain.Core.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Services;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using GerenciamentoSalao.Infra.CrossCutting.Map;
using GerenciamentoSalao.Infra.Data.Repositories;

namespace GerenciamentoSalao.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ClienteApplicationService>().As<IClienteApplicationService>();
            builder.RegisterType<ProdutoApplicationService>().As<IProdutoApplicationService>();
            builder.RegisterType<FuncionarioApplicationService>().As<IFuncionarioApplicationService>();
            builder.RegisterType<ServicoApplicationService>().As<IServicoApplicationService>();
            builder.RegisterType<AgendaApplicationService>().As<IAgendaApplicationService>();
            builder.RegisterType<AgendamentoApplicationService>().As<IAgendamentoApplicationService>();

            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<FuncionarioService>().As<IFuncionarioService>();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();
            builder.RegisterType<ServicoService>().As<IServicoService>();
            builder.RegisterType<AgendaService>().As<IAgendaService>();
            builder.RegisterType<AgendamentoService>().As<IAgendamentoService>();
            builder.RegisterType<AccountClienteService>().As<IAccountClienteService>();
            builder.RegisterType<AccountFuncionarioService>().As<IAccountFuncionarioService>();

            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<FuncionarioRepository>().As<IFuncionarioRepository>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();
            builder.RegisterType<ServicoRepository>().As<IServicoRepository>();
            builder.RegisterType<AgendaRepository>().As<IAgendaRepository>();
            builder.RegisterType<AgendamentoRepository>().As<IAgendamentoRepository>();

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            builder.RegisterType<MapperServico>().As<IMapperServico>();
            builder.RegisterType<MapperFuncionario>().As<IMapperFuncionario>();
            builder.RegisterType<MapperAgenda>().As<IMapperAgenda>();
            builder.RegisterType<MapperAgendamento>().As<IMapperAgendamento>();

            builder.RegisterType<Cryptography>().As<ICryptography>();
            #endregion
        }
    }
}
