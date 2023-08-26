using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex06
{
    internal class ConversorMilhas
    {
        private const double milhasmetro = 1852;
        private const double metroskm = 0.001;

        public double Converter(double milhas)
        {
            double metros = milhas * milhasmetro;
            double km = metros * metroskm;
            return km;
        }
    }
}
