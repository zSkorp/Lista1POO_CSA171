using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de dólar para real\n");
            Console.Write("Digite a cotação do dólar: ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            double qtdDolares = Convert.ToDouble(Console.ReadLine());

            ConversorDolar conversor = new ConversorDolar();
            conversor.SetCotacaoDolar(cotacaoDolar);

            double valorEmReais = conversor.ConverterDolaresParaReais(qtdDolares);
            Console.WriteLine("\nO valor correspondente em reais é: R${0}\n", valorEmReais);
        }
    }
}
