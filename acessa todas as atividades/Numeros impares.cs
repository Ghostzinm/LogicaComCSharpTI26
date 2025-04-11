using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class Numeros_impares
    {
        public static void AteCem()
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
