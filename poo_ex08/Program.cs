using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparador de valores\n");
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            ComparadorValores comparador = new ComparadorValores();
            comparador.Valores(valor1, valor2);

            double maiorValor = comparador.CalcularValor();
            Console.WriteLine("\nO maior valor é: {0}\n", maiorValor);
        }
    }
}
