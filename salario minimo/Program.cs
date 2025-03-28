using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de 
um usuário, calcule quantos salários mínimos esse
usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 
1.518,00).*/

            double salario_Minimo = 1518.00, salario_Usuario, quantidade;

            Console.WriteLine("digite seu salario: ");
            salario_Usuario = double.Parse(Console.ReadLine());

            quantidade = salario_Usuario / salario_Minimo;
            Console.WriteLine("voce ganha " + quantidade + " salarios minimos \n valor do salario minimo: 1.518,00");



        }
    }
}
