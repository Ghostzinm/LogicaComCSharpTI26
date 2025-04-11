using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_de_Albuns;

namespace acessa_todas_as_atividades.Cadastro_de_artista
{
    internal class banda
    {
        public static void CadBanda()
        {

            int opcoes = 1;

            while (opcoes != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
 _____           _           _                   _                 
/  __ \         | |         | |                 | |                
| /  \/ __ _  __| | __ _ ___| |_ _ __ ___     __| | ___            
| |    / _` |/ _` |/ _` / __| __| '__/ _ \   / _` |/ _ \           
| \__/\ (_| | (_| | (_| \__ \ |_| | | (_) | | (_| |  __/           
 \____/\__,_|\__,_|\__,_|___/\__|_|  \___/   \__,_|\___|           
                                                                                                                                                                                                     
  ___       _   _     _              __  _____                 _       
 / _ \     | | (_)   | |            / /   ___ \               | |      
/ /_\ \_ __| |_ _ ___| |_ __ _     / /  | |_/ / __ _ _ __   __| | __ _ 
|  _  | '__| __| / __| __/ _` |   / /   | ___ \/ _` | '_ \ / _` |/ _` |
| | | | |  | |_| \__ \ || (_| |  / /    | |_/ / (_| | | | | (_| | (_| |
\_| |_/_|   \__|_|___/\__\__,_  /_/     \____/ \__,_|_| |_|\__,_|\__,_|                                                                      
");
                Console.ResetColor();

                Console.WriteLine("\n Menu de cadastro\n");
                Console.WriteLine("1- Cadastrar nome do artista");
                Console.WriteLine("2- Cadastrar nome da banda");
                Console.WriteLine("0- Sair");
                Console.WriteLine("Escolha uma das opções: ");

                while (!int.TryParse(Console.ReadLine(), out opcoes) || opcoes < 0 || opcoes > 3)
                {
                    Console.WriteLine("opção invalida, Digite novamente");
                }

                switch (opcoes)
                {

                    case 1:
                        Cadastro_Artista.Cadastro_de_Artista();
                        break;

                    case 0:
                        sair();
                        break;

                    default:
                        opcaoInvalida();
                        break;

                }
                if (opcoes != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
        }


        static void sair()
        {
            Console.WriteLine("Saindo...");
        }

        static void opcaoInvalida()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALIDO");
        }
    }
}

