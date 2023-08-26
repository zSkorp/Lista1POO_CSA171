using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificar se valores formam um triângulo retângulo\n");
            Console.Write("Digite o valor do lado A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            TrianguloRetangulo triangulo = new TrianguloRetangulo();
            triangulo.Lados(a, b, c);

            if (triangulo.Verificar())
            {
                Console.WriteLine("\nOs valores formam um triângulo retângulo.\n");
            }
            else
            {
                Console.WriteLine("\nOs valores não formam um triângulo retângulo.\n");
            }
        }
    }
}
