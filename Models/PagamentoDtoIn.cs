using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I/OBS: implementacao futura - No console nao fez muito sentido
namespace CP2_PagamentoSys_console.Models
{
    public class PagamentoDtoIn
    {
        public decimal Valor { get; set; }
        public string MetodoPagamento { get; set; }
        public string NumeroPedido { get; set; }
    }
}
