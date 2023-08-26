using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular área de um triângulo\n");
            Console.Write("Digite o valor da base do triângulo: ");
            double baseT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaT = Convert.ToDouble(Console.ReadLine());

            AreaTriangulo triangulo = new AreaTriangulo();
            triangulo.Base(baseT);
            triangulo.SetAltura(alturaT);

            double area = triangulo.CalcularArea();
            Console.WriteLine("\nA área do triângulo é: {0}\n", area);
        }
    }
}
