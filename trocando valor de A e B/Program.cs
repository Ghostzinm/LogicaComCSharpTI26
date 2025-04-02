using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trocando_valor_de_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7-  Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.*/

            double A, B;

            Console.WriteLine("digite um valor: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("digite um valor: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("invertendo valor....  ");

            Console.WriteLine("valoer de A é " + B + " e o valor de B " + A);
        }
    }
}
