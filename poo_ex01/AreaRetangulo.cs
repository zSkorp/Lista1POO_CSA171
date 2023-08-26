using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex01
{
    internal class AreaRetangulo
    {
        private double baseR;
        private double alturaR;

        public void Base(double baseValor)
        {
            baseR = baseValor;
        }

        public void Altura(double alturaValor)
        {
            alturaR = alturaValor;
        }

        public double CalcularArea()
        {
            return baseR * alturaR;
        }
    }
}
