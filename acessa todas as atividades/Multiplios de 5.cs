using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class Multiplios_de_5
    {
        public static void Multi()
        {

            double num1, num3, num5;

            Console.WriteLine("digite o numero ");
            num1 = double.Parse(Console.ReadLine());



            if (num1 % 5 == 0)
            {
                Console.WriteLine("numero é multiplo de 5 ");
            }
            if (num1 % 3 == 0)
            {
                Console.WriteLine("numero é multiplo de 3 ");
            }
            else
            {
                Console.WriteLine("ne nao ");
            }


        }
    }
}
