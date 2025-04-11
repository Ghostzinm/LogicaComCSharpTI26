using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class qual_maior_numero_entre_os_3
    {
        public static void Num()
        {

            double num1, num2, num3;

            Console.Write("digite um numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("digite um numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("digite um numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("o maior numero é: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("o maior numero é: " + num2);
            }
            else
            {
                Console.WriteLine("o maior numero é: " + num3);
            }
        }
    }
}
