using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classificador de triângulos\n");
            Console.Write("Digite o primeiro lado do triângulo: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo lado do triângulo: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro lado do triângulo: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo();
            triangulo.Lados(a, b, c);

            string classificacao = triangulo.Classificar();
            Console.WriteLine(classificacao);
        }
    }
}
