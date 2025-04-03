using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcule_a_quantidade_de_litros_de_combustível
{
    internal class Program
    {
        static void Main(string[] args)
        /* 12- Faça um algoritmo que calcule a quantidade de litros de combustível gastos em uma viagem, sabendo que o carro faz 12km com um litro. Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média, distância percorrida e a quantidade de litros utilizados para fazer a viagem.
Fórmula: distância = tempo x velocidade.
*/
        {
            double tempo, velocidade, litros, distância;

            Console.WriteLine("digite quantos km tem a viagem");
            distância = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a velocidade media");
            velocidade = double.Parse(Console.ReadLine());

            distância = tempo * velocidade;

            litros = distância / 12;

        }
    }
}
