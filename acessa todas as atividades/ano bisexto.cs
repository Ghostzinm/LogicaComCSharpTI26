using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class ano_bisexto
    {
        public static void AnoBi()
        {

            double ano;

            Console.WriteLine("digite se ano bb ");
            ano = double.Parse(Console.ReadLine());


            if (ano % 4 == 0 || ano % 100 == 0 && ano % 400 == 0)
            {
                Console.WriteLine("é bissexto");
            }
            else
            {
                Console.WriteLine("não é bissexto");
            }
        }
    }
}
