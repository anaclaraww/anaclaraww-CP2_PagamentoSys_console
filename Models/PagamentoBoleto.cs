namespace CP2_PagamentoSys_console.Models;

public class PagamentoBoleto : PagamentoBase
{
    public string CodigoBarras { get; set; } = string.Empty;

    public override string ProcessarPagamento()
    {
        return $"Processando pagamento de {Valor:C} via Boleto " +
               $"(Cod Barra: {CodigoBarras}) na data {Data:dd/MM/yyyy}.";
    }

}
