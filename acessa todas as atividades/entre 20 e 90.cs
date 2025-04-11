using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class entre_20_e_90
    {
        public static void Entre()
        {

            //Contrua um algoritimo que indique se um numero esta entre 20 e 90
            int numero;

            Console.WriteLine("digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero > 20 && numero < 90)
            {
                Console.WriteLine("Numero esta entre 20 e 90");
            }
            else
            {
                Console.WriteLine("Numero nao esta entre 20 e 90");
            }
        }
    }
}
