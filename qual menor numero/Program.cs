using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qual_menor_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.WriteLine("escreva um numero ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("escreva um numero ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("escreva um numero ");
            num3 = double.Parse(Console.ReadLine());

            if(num1 < num2 && num1 <num3){
                Console.WriteLine("o menor numero é o numero: " + num1);
            }
            if(num2 < num1 && num2 <num3){
                Console.WriteLine("o menor numero é o numero: " + num2);
            }
            if(num3 < num2 && num3 <num1){
                Console.WriteLine("o menor numero é o numero: " + num3);
            }

        }
    }
}
