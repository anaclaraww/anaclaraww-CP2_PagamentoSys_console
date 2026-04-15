using CP2_PagamentoSys_console.Repositories;
using CP2_PagamentoSys_console.Services;
using CP2_PagamentoSys_console.ComponentesUI;

var repository = new PagamentoRepository();
var service = new ProcessarPagamentoService(repository);

string opcao;

do
{
    MenuConsole.ExibirMenu();
    opcao = Console.ReadLine() ?? string.Empty;

    switch (opcao)
    {
        case "1":
            service.ProcessarCartao();
            break;
        case "2":
            service.ProcessarBoleto();
            break;
        case "3":
            Console.WriteLine("Encerrando o sistema. Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.\n");
            break;
    }
} while (opcao != "3");