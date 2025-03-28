using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste_de_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que leia um valor qualquer e imprima na tela com um 
reajuste de 5%.*/

            double valor, ajuste, sobra;

            Console.WriteLine("digite um valor");
            valor = double.Parse(Console.ReadLine());

            sobra = valor * 0.05;
            ajuste = valor + sobra;
            Console.WriteLine(ajuste);

        }
    }
}
