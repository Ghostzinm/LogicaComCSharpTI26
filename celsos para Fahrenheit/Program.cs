using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsos_para_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9- Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.
Fórmula: C = (5 * ( F-32) / 9)
*/

            Console.Title = "Valores Inteiros";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"
╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ 

                                                                                       (                                              
   (                              )                   (                                )\ )        )                  )            )  
   )\             )     (  (   ( /(  (  (           ( )\                  ) (      )  (()/(   ) ( /( (     (       ( /(   (  (  ( /(  
 (((_)  (   (    /((   ))\ )(  )\())))\ )(     (   ))((_|   (    `  )  ( /( )(  ( /(   /(_)| /( )\()))(   ))\ (    )\()) ))\ )\ )\()) 
 )\___  )\  )\ )(_))\ /((_|()\(_))//((_|()\    )\ /((_) )\  )\   /(/(  )(_)|()\ )(_)) (_))_)(_)|(_)\(()\ /((_))\ )((_)\ /((_|(_|_))/  
((/ __|((_)_(_/(_)((_|_))  ((_) |_(_))  ((_)  ((_|_))| ((_)((_) ((_)_\((_)_ ((_|(_)_  | |_((_)_| |(_)((_|_)) _(_/(| |(_|_))  (_) |_   
 | (__/ _ \ ' \)) V // -_)| '_|  _/ -_)| '_| / _|/ -_) (_-< _ \ | '_ \) _` | '_/ _` | | __/ _` | ' \| '_/ -_) ' \)) ' \/ -_) | |  _|  
  \___\___/_||_| \_/ \___||_|  \__\___||_|   \__|\___|_/__|___/ | .__/\__,_|_| \__,_| |_| \__,_|_||_|_| \___|_||_||_||_\___| |_|\__|  
                                                                |_|                                                                   
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
