namespace CP2_PagamentoSys_console.Models;

public class PagamentoCartao : PagamentoBase
{
    public string NumeroCartao { get; set; } = string.Empty;

    public override string ProcessarPagamento()
    {
        return $"Processando pagamento de {Valor:C} via Cartão " +
               $"(Número: {NumeroCartao}) na data {Data:dd/MM/yyyy}.";
    }
}
