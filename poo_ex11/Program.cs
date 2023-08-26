using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular IMC\n");
            Console.Write("Digite o peso da pessoa (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da pessoa (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            PessoaIMC pessoa = new PessoaIMC();
            pessoa.Peso(peso);
            pessoa.Altura(altura);

            pessoa.ExibirIMC();
        }
    }
}
