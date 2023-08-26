using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex04
{
    internal class AreaTriangulo
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public void Base(double baseValor)
        {
            baseTriangulo = baseValor;
        }

        public void SetAltura(double alturaValor)
        {
            alturaTriangulo = alturaValor;
        }

        public double CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
