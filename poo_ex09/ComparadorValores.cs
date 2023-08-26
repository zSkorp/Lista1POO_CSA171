using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex09
{
    internal class ComparadorValores
    {
        private double valor1;
        private double valor2;

        public void Valores(double v1, double v2)
        {
            valor1 = v1;
            valor2 = v2;
        }

        public void CompararValores()
        {
            if (valor1 > valor2)
            {
                Console.WriteLine("\nO maior valor é: {0}\n", valor1);
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine("\nO maior valor é: {0}\n", valor2);
            }
            else
            {
                Console.WriteLine("\nOs números são idênticos.\n");
            }
        }
    }
}
