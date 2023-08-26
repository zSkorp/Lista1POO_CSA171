using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex07
{
    internal class ConversorDolar
    {
        private double cotacaoDolar;

        public void SetCotacaoDolar(double cotacao)
        {
            cotacaoDolar = cotacao;
        }

        public double ConverterDolaresParaReais(double quantidadeDolares)
        {
            return quantidadeDolares * cotacaoDolar;
        }
    }
}
