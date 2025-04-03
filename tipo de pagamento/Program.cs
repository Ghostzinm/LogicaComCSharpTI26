using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_de_pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6-	Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento
 pelo comprador e imprima na tela o valor final do produto a ser pago. Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.
 
 Tabela de Código de Condições de Pagamento
 
 1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
 2 - À Vista no cartão de crédito, recebe 10% de desconto
 3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
 4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%
*/

            Console.Title = "Valores Inteiros";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"
╔════════════════════════════════════════════════════════════════════════════════════╗ 

     ___                                __     
    / _ \___ ____ ____ ___ _  ___ ___  / /____ 
   / ___/ _ `/ _ `/ _ `/  ' \/ -_) _ \/ __/ _ \
  /_/   \_,_/\_, /\_,_/_/_/_/\__/_//_/\__/\___/
            /___/                              
║                                                                              
╚════════════════════════════════════════════════════════════════════════════════════╝");
           
            Console.ResetColor();

            double valor, valor_total, opção, desconto;

            Console.WriteLine("\n coloque o valor do produto");
            valor = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════╗ " +
                "\n Escolha o metodo de pagamento: \n " +
                "1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto\r\n " +
                "2 - À Vista no cartão de crédito, recebe 10% de desconto\r\n " +
                "3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros\r\n " +
                "4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%\n" +
                "╚════════════════════════════════════════════════════════════════════════════════════════════════╝");
            opção = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (opção == 1)
                {
                    desconto = valor * 0.15;
                    valor_total = valor - desconto;
                    Console.WriteLine(valor_total);
                }
                else if (opção == 2)
                {
                    desconto = valor * 0.10;
                    valor_total = valor - desconto;
                    Console.WriteLine(valor_total);
                }

                else if (opção == 3)
                {

                    Console.WriteLine(valor);
                }
                else if (opção == 4)
                {
                    desconto = valor * 0.10;
                    valor_total = valor + desconto;
                    Console.WriteLine(valor);

                }
                else
                {
                    Console.WriteLine("uma forma de pagamento invalida ");
                }
        }
    }
}
