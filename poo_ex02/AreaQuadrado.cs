using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex02
{
    internal class AreaQuadrado
    {
        private double lado;

        public void Lado(double ladoValor)
        {
            lado = ladoValor;
        }

        public double CalcularArea()
        {
            return lado * lado;
        }
    }
}
