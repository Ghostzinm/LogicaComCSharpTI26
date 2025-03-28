using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todos_o_numero_impares_ate_100_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int impar = 1;

            while (impar < 100)
            {
                Console.WriteLine("Números impar: " + impar);
                impar = impar + 4 / 2;
            }
        }
    }
}