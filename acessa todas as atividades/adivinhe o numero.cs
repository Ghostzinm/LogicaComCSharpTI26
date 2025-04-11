using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class adivinhe_o_numero
    {
        public static void Jogo()
        {

            int num1, num2, contador;

            Console.WriteLine("digite um numero entre 1 a 10: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o numero escolhido: ");
            num2 = int.Parse(Console.ReadLine());

            for (contador = 1; num1 != num2; contador++)
            {
                Console.WriteLine("numero incorreto, digite numero novamente: ");
                num2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Parabens voce aceretou depois de: " + contador);

        }
    }
}
