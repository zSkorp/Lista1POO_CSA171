using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de milhas marítimas para quilômetros");
            Console.Write("\nDigite a quantidade de milhas marítimas: ");
            double milhas = Convert.ToDouble(Console.ReadLine());

            ConversorMilhas conversor = new ConversorMilhas();
            double km = conversor.Converter(milhas);

            Console.WriteLine("\n{0} milhas marítimas equivalem a {1} quilômetros.\n", milhas, km);
        }
    }
}
