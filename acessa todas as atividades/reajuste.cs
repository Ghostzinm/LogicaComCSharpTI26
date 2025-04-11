using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class reajuste
    {
        public static void Cinco()
        {
            /* Faça um algoritmo que leia um valor qualquer e imprima na tela com um 
reajuste de 5%.*/

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"
╔════════════════════════════════════════════════════════════════════════════════════╗ 
║ 
                _           _             _        _____ _   __
               (_)         | |           | |      |  ___(_) / /
 _ __ ___  __ _ _ _   _ ___| |_ ___    __| | ___  |___ \   / / 
| '__/ _ \/ _` | | | | / __| __/ _ \  / _` |/ _ \     \ \ / /  
| | |  __/ (_| | | |_| \__ \ ||  __/ | (_| |  __/ /\__/ // / _ 
|_|  \___|\__,_| |\__,_|___/\__\___|  \__,_|\___| \____//_/ (_)
              _/ |                                             
             |__/                                              
║                                                                              
╚════════════════════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5 %.");
            Console.ResetColor();

            double valor, ajuste, sobra;

            Console.WriteLine("\n digite um valor: ");
            valor = double.Parse(Console.ReadLine());

            sobra = valor * 0.05;
            ajuste = valor + sobra;
            Console.WriteLine(ajuste);

        }
    }
}
