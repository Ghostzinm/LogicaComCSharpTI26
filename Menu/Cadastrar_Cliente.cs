using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Cadastrar_Cliente
    {
        public static void CadCliente()
        {
            Console.WriteLine("\nCadastro de Cliente");
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            // $"{variavel}" é um jeito mais prático de contatenar o valor da váriavel
            Console.WriteLine($"Cliente {nome} Cadastrado com sucesso!");
        }
    }
}
