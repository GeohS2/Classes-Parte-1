using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transacao T1 = new Transacao();
            Console.Write("Preço do produto: ");
            T1.PrecoProduto1 = double.Parse(Console.ReadLine());
            Console.Write("Valor Pago: ");
            T1.ValorPago1 = double.Parse(Console.ReadLine());
           // T1.GravarDados(aux1, aux2);

            T1.MostrarDados();
            Console.Write(T1.MostrarDados());
            Console.ReadKey();
        }
    }
}
