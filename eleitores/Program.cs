using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleitores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idd;

            Console.WriteLine("Digite sua idade: ");
            idd = int.Parse(Console.ReadLine());


            if (idd < 16)
            {
                Console.WriteLine("Você não é um eleitor");
            }
            else if (idd >= 16 && idd <= 18)
            {
                Console.WriteLine("Você é um eleitor opcional");
            }
            else if (idd > 18 && idd <= 65)
            {
                Console.WriteLine("Você é um eleitor obrigatório");
            }
            else
            {
                Console.WriteLine("Você é um eleitor facultativo");
            }
        }
    }
}
