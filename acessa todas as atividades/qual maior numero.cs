using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class qual_maior_numero
    {
       public static void Num()
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
