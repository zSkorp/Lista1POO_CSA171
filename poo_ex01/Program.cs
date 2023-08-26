using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Calcular área de um retângulo\n");
                Console.Write("Digite a base do retângulo: ");
                double baseR = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura do retângulo: ");
                double alturaR = Convert.ToDouble(Console.ReadLine());

                AreaRetangulo retangulo = new AreaRetangulo();
                retangulo.Base(baseR);
                retangulo.Altura(alturaR);

                double area = retangulo.CalcularArea();
                Console.WriteLine("\nA área do retângulo é: {0}\n", area);
            }
        }
    }
}
