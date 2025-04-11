using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class num_pares_ate_100
    {

        public static void Par()
        {
            ////mostre numeros PARES de 0 a 100 (para)

            int contador;

            for (contador = 0; contador < 101; contador = contador + 2)
            {
                Console.WriteLine(" " + contador);
            }
        }
    }
}
