using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_de_0_a_100_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;

            while (contador < 100)  {
                contador = contador + 2;
                Console.WriteLine(contador);
            }

        }
    }
}
