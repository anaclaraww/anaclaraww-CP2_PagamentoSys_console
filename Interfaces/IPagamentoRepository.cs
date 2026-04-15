using CP2_PagamentoSys_console.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CP2_PagamentoSys_console.Interfaces
{
    public interface IPagamentoRepository
    {
        void Salvar(PagamentoBase pagamento);
    }
}
