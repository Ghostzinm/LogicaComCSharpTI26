using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Cadastro_Produto
    {
        public static void cadastroDeProduto()
        {
            Console.WriteLine("\nCadastro do Produto");
            Console.WriteLine("Digite o nome do produto");
            int Produto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produto {Produto} Cadastrado com sucesso!!");
        }
    }
}
