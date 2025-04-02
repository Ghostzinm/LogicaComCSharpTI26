using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsos_para_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9- Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.
Fórmula: C = (5 * ( F-32) / 9)
*/

            double F, C, cauculo;

            Console.WriteLine("dgite temperatura em Fahrenheit");
            F = double.Parse(Console.ReadLine());

            C = 5 * (F - 32) / 9;

            Console.WriteLine(F + "º em Fahrenheits é " + C + "º em Celsius");


        }
    }
}
