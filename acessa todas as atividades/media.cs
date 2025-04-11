using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class media
    {
       public static void Nota()
        {
            double nota1, nota2, nota3, nota4, nota_total;

            Console.WriteLine("nota de ciencioas: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("nota de portugues: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("nota de geografia: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("nota de matematica: ");
            nota4 = double.Parse(Console.ReadLine());
            nota_total = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(" nota final " + nota_total);
            if (nota_total >= 7)
                Console.WriteLine(" aprovado ");
            else
            {
                Console.WriteLine(" reprovado");
            }

        }
    }
}
