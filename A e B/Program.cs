﻿using System;


/*Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B 
forem iguais, deverá somar os dois valores,
caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos 
deve-se atribuir o resultado a uma variável C e
imprimir seu valor na tela*/

namespace A_e_B
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Title = "Valores Inteiros";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(@"
╔════════════════════════════════════════════════════════════════════════════════════╗ 
║             _                        _____       _            _                    ║
║ /\   /\__ _| | ___  _ __ ___  ___    \_   \_ __ | |_ ___ _ __(_)_ __ ___  ___      ║
║ \ \ / / _` | |/ _ \| '__/ _ \/ __|    / /\/ '_ \| __/ _ \ '__| | '__/ _ \/ __|     ║
║  \ V / (_| | | (_) | | |  __/\__ \ /\/ /_ | | | | ||  __/ |  | | | | (_) \__ \     ║
║   \_/ \__,_|_|\___/|_|  \___||___/ \____/ |_| |_|\__\___|_|  |_|_|  \___/|___/     ║                                                                              
╚════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B \r\nforem iguais, deverá somar os dois valores,\r\ncaso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos \r\ndeve-se atribuir o resultado a uma variável C e\r\nimprimir seu valor na tela");
            Console.ResetColor();
            int a, b, total;


            Console.WriteLine("digite um numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite mais um numero");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                total = a + b;
                Console.WriteLine(total);

            }
            else
            {
                total = a * b;
                Console.WriteLine(total);
            }
        }
    }
}
