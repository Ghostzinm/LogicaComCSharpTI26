using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Albuns
{
    internal class Cadastro_Artista
    {
        public static void Cadastro_de_Artista()
        {
            Console.WriteLine("Digite o nome do artista/ banda");
            string artista = Console.ReadLine();

            Console.WriteLine("Digite o nome do album");
            string album = Console.ReadLine();

            Console.WriteLine($"O album {album} do(a) {artista} foi cadastrado com sucesso");
        }

    }
}
