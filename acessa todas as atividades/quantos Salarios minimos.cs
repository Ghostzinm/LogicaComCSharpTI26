using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class quantos_Salarios_minimos
    {
        public static void Sal()
        {
            /*Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de 
um usuário, calcule quantos salários mínimos esse
usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 
1.518,00).*/


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@"
╔═════════════════════════════════════════════════════════════════════════════════╗ 
║                                                                                 ║
  
 __    __    _      __    ___   _   ___       _      _   _      _   _      ___  
( (`  / /\  | |    / /\  | |_) | | / / \     | |\/| | | | |\ | | | | |\/| / / \ 
_)_) /_/--\ |_|__ /_/--\ |_| \ |_| \_\_/     |_|  | |_| |_| \| |_| |_|  | \_\_/ 
                                                                                                                                                                                                                                             
║                                                                                   ║                                                                              
╚═══════════════════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n 2- Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse \r\nusuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).\r\n");

            Console.ResetColor();
            double salario_Minimo = 1518.00, salario_Usuario, quantidade;

            Console.WriteLine("\n digite seu salario: ");
            salario_Usuario = double.Parse(Console.ReadLine());

            quantidade = (int)(salario_Usuario / salario_Minimo);
            Console.WriteLine("voce ganha " + quantidade + " salarios minimos \n valor do salario minimo: 1.518,00");



        }
    }
}
