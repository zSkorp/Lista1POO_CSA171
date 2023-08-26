using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex11
{
    internal class PessoaIMC
    {
        private double peso;
        private double altura;

        public void Peso(double pesoValor)
        {
            peso = pesoValor;
        }

        public void Altura(double alturaValor)
        {
            altura = alturaValor;
        }

        public double CalcularIMC()
        {
            double alturaT = altura * altura;
            return peso / alturaT;
        }

        public void ExibirIMC()
        {
            double imc = CalcularIMC();

            Console.Write("\nÍndice de Massa Corporal: " + imc);
            if (imc < 20)
            {
                Console.WriteLine(" - Abaixo do peso\n");
            }
            else if (imc < 25)
            {
                Console.WriteLine(" - Peso ideal\n");
            }
            else
            {
                Console.WriteLine(" - Acima do peso\n");
            }
        }
    }
}
