using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_ou_menor_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Digite um numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O numero maior é: " + num1);
                Console.WriteLine("O numero menor é: " + num2);
            }
            else
            {
                Console.WriteLine("O numero maior é: " + num2);
                Console.WriteLine("o numero maior é: " + num1);
            }
        }
    }
}
