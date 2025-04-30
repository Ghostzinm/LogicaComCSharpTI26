using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_pares_de_0_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////mostre numeros PARES de 0 a 100 (para)

            int contador;
              
            for(contador = 0; contador < 101; contador = contador + 2){
                Console.WriteLine(" " + contador);
            }
         }
    }

}
