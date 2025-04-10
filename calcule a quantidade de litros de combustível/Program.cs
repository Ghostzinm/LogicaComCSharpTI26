using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcule_a_quantidade_de_litros_de_combustível
{
    internal class Program
    {
        static void Main(string[] args)
        /* 12- Faça um algoritmo que calcule a quantidade de litros de combustível gastos em uma viagem, sabendo que o carro faz 12km com um litro. 
         * Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média, distância percorrida e a quantidade de litros utilizados para fazer a viagem.
Fórmula: distância = tempo x velocidade.
*/
        {
            Console.Title = "Valores Inteiros";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"
╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ 


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
╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            double litros, distância;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n digite quantos km tem a viagem");
            distância = double.Parse(Console.ReadLine());

            litros = distância / 12;

            Console.ResetColor();
            Console.WriteLine("voce irar gastar " + (int) (litros) + " Litros aproximadamente nessa viagem");

        }
    }
}
