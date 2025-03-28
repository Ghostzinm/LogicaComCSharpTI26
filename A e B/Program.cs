using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B 
forem iguais, deverá somar os dois valores,
caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos 
deve-se atribuir o resultado a uma variável C e
imprimir seu valor na tela*/

            int a, b, total;

            Console.WriteLine("digite um numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite mais um numero");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                total = a + b;
                Console.WriteLine(total);

            }
            else
            {
                total = a * b;
                Console.WriteLine(total);
            }
        }
    }
}
