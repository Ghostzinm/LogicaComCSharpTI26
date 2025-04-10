using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Cadastro_Funcionario
    {
        public static void cadastroDeFuncionario()
        {
            Console.WriteLine("Cadastro de Funcionários");
            Console.WriteLine("Digite o nome do funcionário");
            string nomeFuncionario = Console.ReadLine();
            Console.WriteLine($"Funcionário {nomeFuncionario} Cadastrado com sucesso!!");
        }
    }
}
