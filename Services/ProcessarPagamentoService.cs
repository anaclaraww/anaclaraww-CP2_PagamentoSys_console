using CP2_PagamentoSys_console.Interfaces;
using CP2_PagamentoSys_console.Models;

namespace CP2_PagamentoSys_console.Services;

internal class ProcessarPagamentoService : IProcessaPagamentoService
{
    private readonly IPagamentoRepository _repository;

    public ProcessarPagamentoService(IPagamentoRepository repository)
    {
        _repository = repository;
    }

    public void ProcessarCartao()
    {
        decimal valor = LerValor();

        Console.Write("Informe o número do cartão: ");
        string numeroCartao = Console.ReadLine() ?? string.Empty;

        var pagamento = new PagamentoCartao
        {
            Valor = valor,
            NumeroCartao = numeroCartao
        };

        _repository.Salvar(pagamento);
        Console.WriteLine($"\n{pagamento.ProcessarPagamento()}\n");
    }

    public void ProcessarBoleto()
    {
        decimal valor = LerValor();

        Console.Write("Informe o código de barras: ");
        string codigoBarras = Console.ReadLine() ?? string.Empty;

        var pagamento = new PagamentoBoleto
        {
            Valor = valor,
            CodigoBarras = codigoBarras
        };

        _repository.Salvar(pagamento);
        Console.WriteLine($"\n{pagamento.ProcessarPagamento()}\n");
    }

    private static decimal LerValor()
    {
        decimal valor;
        while (true)
        {
            Console.Write("Informe o valor do pagamento: R$ ");
            string entrada = (Console.ReadLine() ?? string.Empty)
                .Replace(".", ","); 

            if (decimal.TryParse(entrada,
                    System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.GetCultureInfo("pt-BR"),
                    out valor) && valor > 0)
                break;

            Console.WriteLine("Valor inválido. Tente novamente.");
        }
        return valor;
    }
}