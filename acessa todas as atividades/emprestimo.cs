using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class emprestimo
    {
        public static void Prest()
        {
            double salario, prestacao;

            Console.WriteLine("digite o seu salario ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("valor da prestação ");
            prestacao = double.Parse(Console.ReadLine());
            if (prestacao > salario * 30 / 100)
                Console.WriteLine("emprestimo negado ");
            else { Console.WriteLine("saldo aceito"); }
        }
    }
}
