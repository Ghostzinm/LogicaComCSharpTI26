using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verdadeiro_ou_falso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 5- Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma 
    pessoa, leia o seu peso e sua altura e imprima na tela sua condição
    de acordo com a tabela abaixo:
    Fórmula do IMC = peso / (altura) ²
    Tabela Condições IMC
    Abaixo de 18,5 | Abaixo do peso
    Entre 18,6 e 24,9 | Peso ideal (parabéns)
    Entre 25,0 e 29,9 | Levemente acima do peso
    Entre 30,0 e 34,9 | Obesidade grau I
    Entre 35,0 e 39,9 | Obesidade grau II (severa)
    Maior ou igual a 40 | Obesidade grau III (mórbida)*/

            double peso, altura, IMC;

            Console.WriteLine("digite seu peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("digite sua altura");
            altura = double.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            if (IMC > 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (IMC > 18.6 && IMC < 24.9)
            {
                Console.WriteLine("Peso ideal (parabens)");
            }
            else if (IMC > 25 && IMC < 29.9)
            {
                Console.WriteLine("levemente acima do peso");
            }
            else if (IMC > 30 && IMC < 34.9)
            {
                Console.WriteLine("obsidade grau I");
            }
            else if (IMC > 35 && IMC < 39.9)
            {
                Console.WriteLine("Obsidade grau II");
            }
            else if (IMC >= 40)
            {
                Console.WriteLine("Obesidade grau III (mórbida)");
            }
        }
    }
}
