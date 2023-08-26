using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular terreno retangular\n");
            Console.Write("Digite o valor da base do retângulo: ");
            double baseR = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do retângulo: ");
            double alturaR = Convert.ToDouble(Console.ReadLine());

            AreaRetangulo retangulo = new AreaRetangulo();
            retangulo.Base(baseR);
            retangulo.Altura(alturaR);

            double area = retangulo.CalcularArea();
            Console.WriteLine("\nA área do retângulo é: {0}", area);

            if (area > 100)
            {
                Console.WriteLine("\nO terreno é grande\n");
            }
            else
            {
                Console.WriteLine("\nO terreno é pequeno\n");
            }
        }
    }
}
