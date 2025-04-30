using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todos_numeros_impares_ate_100__for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int impar;

            for (impar = 1; impar < 100; impar++)
            {
                impar = impar + 4 / 2;
                Console.WriteLine("Números impars: " + impar);

            }
        }
    }
}
