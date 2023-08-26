using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex03
{
    internal class AreaQuadrado
    {
        private double diagonal;

        public void Diagonal(double diagonalValor)
        {
            diagonal = diagonalValor;
        }

        public double CalcularLado()
        {
            return diagonal / Math.Sqrt(2);
        }

        public double CalcularArea()
        {
            double lado = CalcularLado();
            return lado * lado;
        }
    }
}
