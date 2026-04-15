
using CP2_PagamentoSys_console.Models;

namespace CP2_PagamentoSys_console.Interfaces;

public interface IProcessaPagamentoService
{
    void ProcessarCartao();
    void ProcessarBoleto();
}
