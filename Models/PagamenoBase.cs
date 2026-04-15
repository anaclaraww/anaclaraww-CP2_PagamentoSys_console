using CP2_PagamentoSys_console.Interfaces;

namespace CP2_PagamentoSys_console.Models
{
    public abstract class PagamentoBase : IPagamento
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

        public abstract string ProcessarPagamento();
    }
}
