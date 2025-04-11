using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class Celsos_Fahrenheit
    {
       public static void Temp()
        {
            /*9- Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.
Fórmula: C = (5 * ( F-32) / 9)
*/

            Console.Title = "Valores Inteiros";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(@"
╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ 


  _ _ _                       _                            _               _   __          _ 
 | (_) |                     | |                          | |             | | /_/         | |
 | |_| |_ _ __ ___  ___    __| | ___    ___ ___  _ __ ___ | |__  _   _ ___| |_ ___   _____| |
 | | | __| '__/ _ \/ __|  / _` |/ _ \  / __/ _ \| '_ ` _ \| '_ \| | | / __| __| \ \ / / _ \ |
 | | | |_| | | (_) \__ \ | (_| |  __/ | (_| (_) | | | | | | |_) | |_| \__ \ |_| |\ V /  __/ |
 |_|_|\__|_|  \___/|___/  \__,_|\___|  \___\___/|_| |_| |_|_.__/ \__,_|___/\__|_| \_/ \___|_|
                                                                                             
     
                   _                                                             _                            
                  | |                                                           (_)                           
      __ _  __ _ ___| |_ ___  ___    ___ _ __ ___    _   _ _ __ ___   __ _  __   ___  __ _  __ _  ___ _ __ ___  
     / _` |/ _` / __| __/ _ \/ __|  / _ \ '_ ` _ \  | | | | '_ ` _ \ / _` | \ \ / / |/ _` |/ _` |/ _ \ '_ ` _ \ 
    | (_| | (_| \__ \ || (_) \__ \ |  __/ | | | | | | |_| | | | | | | (_| |  \ V /| | (_| | (_| |  __/ | | | | |
     \__, |\__,_|___/\__\___/|___/  \___|_| |_| |_|  \__,_|_| |_| |_|\__,_|   \_/ |_|\__,_|\__, |\___|_| |_| |_|
      __/ |                                                                                 __/ |               
     |___/                                                                                 |___/                
                                                                                        

                                                                                                                       
║                                                                              
╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 9- Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.\r\nFórmula: C = (5 * ( F-32) / 9) ");
            Console.ResetColor();

            double F, C, cauculo;

            Console.WriteLine("dgite temperatura em Fahrenheit");
            F = double.Parse(Console.ReadLine());

            C = 5 * (F - 32) / 9;

            Console.WriteLine(F + "º em Fahrenheits é " + C + "º em Celsius");


        }
    }
}
