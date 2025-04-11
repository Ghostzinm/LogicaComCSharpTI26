using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class numero_perfeito
    {
        public static void Perfeito()
        {/*Escreva um programa que verifique se um número inteiro fornecido pelo usuário é um número perfeito. Definição de número perfeito: Um número é considerado perfeito se a soma de seus divisores próprios (divisores que são menores do que o próprio número) for igual ao próprio número. Por exemplo, o número 6 é perfeito, pois seus divisores próprios (1, 2 e 3) somam 6 (1 + 2 + 3 = 6).

Instruções:

1- Solicite ao usuário que insira um número inteiro.
2- Calcule a soma dos divisores próprios desse número.
3- Verifique se a soma dos divisores é igual ao número fornecido.
4- Caso a soma seja igual ao número, imprima que o número é perfeito. Caso contrário, informe que o número não é perfeito.

Exemplo de execução:

1- Entrada: 6
2- Saída: "6 é um número perfeito."

Exemplo de execução (caso o número não seja perfeito):

1- Entrada: 8
2- Saída: "8 não é um número perfeito."*/

            int num, soma = 0, i;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                                ╔════════════════════════════════════════════════════════════════════════════════════╗
                                ║                                                                                    ║ 
                                ║   _   _                                 ______          __     _ _                 ║  
                                ║  | \ | |                                | ___ \        / _|   (_) |                ║
                                ║  |  \| |_   _ _ __ ___   ___ _ __ ___   | |_/ /__ _ __| |_ ___ _| |_ ___           ║  
                                ║  | . ` | | | | '_ ` _ \ / _ \ '__/ _ \  |  __/ _ \ '__|  _/ _ \ | __/ _ \          ║
                                ║  | |\  | |_| | | | | | |  __/ | | (_) | | | |  __/ |  | ||  __/ | || (_) |         ║   
                                ║  \_| \_/\__,_|_| |_| |_|\___|_|  \___/  \_|  \___|_|  |_| \___|_|\__\___/          ║
                                ║                                                                                    ║                                                                       
                                ║                                                                                    ║             
                                ╚════════════════════════════════════════════════════════════════════════════════════╝");

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    soma += i;
                }
            }

            if (soma == num)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{num} é um número perfeito.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{num} não é um número perfeito.");
            }
        }
    }
}

