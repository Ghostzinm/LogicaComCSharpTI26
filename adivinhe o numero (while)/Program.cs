







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinhe_o_numero__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, contador = 0;

            Console.WriteLine("digite um numero entre 1 a 10: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("digite o numero escolhido: ");
            num2 = int.Parse(Console.ReadLine());

            while(num1 != num2){
                contador = contador + 1;
               Console.WriteLine("numero incorreto, digite numero novamente: ");
                num2 = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Parabens voce acertou depois de: " + contador);
        }
    }
}
