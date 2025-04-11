using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class boolean
    {

        public static void Bool()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"
╔══════════════════════════════════════════════════════════════════════════════════╗ 
║   _______  _______  _______  ___      _______  _______  __    _                  ║
║  |  _    ||       ||       ||   |    |       ||   _   ||  |  | |                 ║
║  | |_|   ||   _   ||   _   ||   |    |    ___||  |_|  ||   |_| |                 ║
║  |       ||  | |  ||  | |  ||   |    |   |___ |       ||       |                 ║
║  |  _   | |  |_|  ||  |_|  ||   |___ |    ___||       ||  _    |                 ║
║  | |_|   ||       ||       ||       ||   |___ |   _   || | |   |                 ║
║  |_______||_______||_______||_______||_______||__| |__||_|  |__|                 ║
╚══════════════════════════════════════════════════════════════════════════════════╝
");

            bool valor1, valor2;

            Console.WriteLine("Digite true para (Verdadeiro) ou false para (Falso): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro true para (Verdadeiro) ou false para (Falso): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 == true && valor2 == true)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
    }
}
