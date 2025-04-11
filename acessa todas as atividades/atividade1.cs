using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class Atividade1
    {
        public static void Mais18()
        {
            int idd;

            Console.WriteLine("Digite sua idade: ");
            idd = int.Parse(Console.ReadLine());
            if (idd >= 18)
            {
                Console.WriteLine("voce é maior de idade");
            }
            else
            {
                Console.WriteLine("voce é menor de idade");
            }
        }
    }
}
