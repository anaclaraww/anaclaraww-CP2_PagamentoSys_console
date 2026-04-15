using CP2_PagamentoSys_console.Interfaces;
using CP2_PagamentoSys_console.Models;

namespace CP2_PagamentoSys_console.Repositories
{
    internal class PagamentoRepository : IPagamentoRepository
    {
        private readonly List<PagamentoBase> _pagamentos = new();

        public void Salvar(PagamentoBase pagamento)
        {
            _pagamentos.Add(pagamento);
        }
    }
}
