using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular área de um quadrado pelo lado");
            Console.Write("\nDigite o valor do lado do quadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            AreaQuadrado quadrado = new AreaQuadrado();
            quadrado.Lado(lado);

            double area = quadrado.CalcularArea();
            Console.WriteLine("\nA área do quadrado é: {0}\n", area);
        }
    }
}
