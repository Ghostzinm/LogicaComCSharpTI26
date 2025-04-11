using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class Positivo_ou_negativo
    {
       public static void Num()
        {
            double num1;

            Console.WriteLine("digite numero desejado: ");
            num1 = double.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine(" seu numero é positivo hehe ");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("seu bumero é negativo bb ");
            }
            else
            {
                Console.WriteLine("seu numero é 0 b");
            }

        }
    }
}
