using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex13
{
    internal class TrianguloRetangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public void Lados(double a, double b, double c)
        {
            ladoA = a;
            ladoB = b;
            ladoC = c;
        }

        public bool Verificar()
        {
            double maiorLado = MaiorLado();
            double margem = 0.000001;
            double catetos = Quadrado(ladoA) + Quadrado(ladoB) + Quadrado(ladoC) - Quadrado(maiorLado);

            return resultado(catetos, Quadrado(maiorLado), margem);
        }

        private double MaiorLado()
        {
            double maior = ladoA;
            if (ladoB > maior)
                maior = ladoB;
            if (ladoC > maior)
                maior = ladoC;
            return maior;
        }

        private double Quadrado(double valor)
        {
            return valor * valor;
        }

        private bool resultado(double valor1, double valor2, double margem)
        {
            return Math.Abs(valor1 - valor2) < margem;
        }
    }
}
