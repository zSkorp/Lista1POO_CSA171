using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex08
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

        public double CalcularValor()
        {
            return Math.Max(valor1, valor2);
        }
    }
}
