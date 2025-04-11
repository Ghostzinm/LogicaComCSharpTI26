using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class pesca
    {
       public static void Multa()
        {
            double peso, sobra;

            Console.WriteLine("Digite o peso pescado: ");
            peso = double.Parse(Console.ReadLine());
            sobra = (peso - 50) * 4;
            Console.WriteLine(sobra);
        }
    }
}
