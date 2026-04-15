using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2_PagamentoSys_console.ComponentesUI;

internal class MenuConsole
{
    internal static void ExibirMenu()
    {
        Console.WriteLine("***** Sistema de Processamento de Pagamentos *****");
        Console.WriteLine("**********  Escolha a forma de pagamento  **********");
        Console.WriteLine("1 - Cartão");
        Console.WriteLine("2 - Boleto");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
    }
}
