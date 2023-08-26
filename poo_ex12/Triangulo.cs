using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex12
{
    internal class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public void Lados(double l1, double l2, double l3)
        {
            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
        }

        public bool Verificar()
        {
            return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
        }

        public string Classificar()
        {
            if (!Verificar())
            {
                return "\nNão forma um triângulo\n";
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                return "\nTriângulo equilátero\n";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "\nTriângulo isósceles\n";
            }
            else
            {
                return "\nTriângulo escaleno\n";
            }
        }
    }
}
