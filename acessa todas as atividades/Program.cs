using System;
using acessa_todas_as_atividades;
using acessa_todas_as_atividades.Cadastro_de_artista;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        // Crie  um sistema de menu em cada opção cadastre um item,
        //  Controlando o acesso do teclado
        {
            int opcao = 1;

            while (opcao != 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
 ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
 ████╗░████║██╔════╝████╗░██║██║░░░██║
 ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
 ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
 ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
 ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");
                Console.ResetColor();
                Console.WriteLine("\n Menu de cadastro\n");
                Console.WriteLine("1- Verificar se voce é maior de idade");
                Console.WriteLine("2- Comparar A e B");
                Console.WriteLine("3- Adivinhe o Numero");
                Console.WriteLine("4- Ano bisexto");
                Console.WriteLine("5-boolean");
                Console.WriteLine("6- Cadastro de artista/banda");
                Console.WriteLine("7- combustivel por litro ");
                Console.WriteLine("8- Calcular idade");
                Console.WriteLine("9- Tranformar de Celsos para Fahrenheit");
                Console.WriteLine("10- Desconto");
                Console.WriteLine("11- eleitores");
                Console.WriteLine("12- empretimo");
                Console.WriteLine("13- Par ou Impar");
                Console.WriteLine("14- Perneta");
                Console.WriteLine("15- Reajuste");
                Console.WriteLine("16- Qual o maior numero ");
                Console.WriteLine("17- Meida");
                Console.WriteLine("18- Multiplos de 5");
                Console.WriteLine("19- Entre 20 e 90");
                Console.WriteLine("20- Todos os Numero pares até 100");
                Console.WriteLine("21- Numero Perfeito");
                Console.WriteLine("22- Peca de multa");
                Console.WriteLine("23- Positivo ou Negativo");
                Console.WriteLine("24- Qual numero é maior (versão 3 numeros)");
                Console.WriteLine("25- Qual tipo de triangulo");
                Console.WriteLine("26- Salario de professor");
                Console.WriteLine("27- Quantos salarios minimos");
                Console.WriteLine("28- Temperatura");
                Console.WriteLine("29- Pagamento");
                Console.WriteLine("30- Numeros impares");
                Console.WriteLine("31 - Cadastro de CLiente");
                Console.WriteLine("32- Cadastro de Fornecedor");
                Console.WriteLine("0- Sair");
                Console.WriteLine("Escolha uma das opções: ");

                // A exclamação "!" transforma o conteúdo em falso, O TryParse serve para verificar se o conteúdo da variável é um texto.
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção Inválida, Digite novamente");
                }
                switch (opcao)
                {
                    case 1:
                        Atividade1.Mais18();
                        break;
    
                    case 2:
                        comparar_A_e_B.Comparar();
                        break;

                    case 3:
                        adivinhe_o_numero.Jogo();
                        break;

                    case 4:
                        ano_bisexto.AnoBi();
                        break;

                    case 5:
                        boolean.Bool();
                        break;

                    case 6:
                        banda.CadBanda();
                        break;

                    case 7:
                        Combustivel.CombL();
                        break;

                    case 8:
                        Calcular_idade.Idd();
                        break;

                    case 9:
                        Celsos_Fahrenheit.Temp();
                        break;

                    case 10:
                        desconto.Desc();
                        break;

                    case 11:
                         eleitores.idd();
                        break;

                    case 12:
                        emprestimo.Prest();
                        break;

                    case 13:
                        impa_ou_par.Qual();
                        break;

                    case 14:
                        keno_perneta.Perna();
                        break;

                    case 15:
                        reajuste.Cinco();
                        break;

                    case 16:
                        qual_maior_numero.Num();
                        break;

                    case 17:
                        media.Nota();
                        break;

                    case 18:
                        Multiplios_de_5.Multi();
                        break;

                    case 19:
                        entre_20_e_90.Entre();
                        break;

                    case 20:
                        num_pares_ate_100.Par();
                        break;

                    case 21:
                        numero_perfeito.Perfeito();
                        break;

                    case 22:
                        pesca.Multa();
                        break;

                    case 23:
                        Positivo_ou_negativo.Num();
                        break;

                    case 24:
                        qual_maior_numero_entre_os_3.Num();
                        break;

                    case 25:
                        qual_tipo_de_triangulo.Triagulo();
                        break;

                    case 26:
                        salario_professores.Sal();
                        break;

                    case 27:
                        quantos_Salarios_minimos.Sal();
                        break;

                    case 28:
                        Temperatura.Celso();
                        break;

                    case 29:
                        Pagamento.Tips();
                        break;

                    case 30:
                        Numeros_impares.AteCem();
                        break;


                    case 0:
                        sair();
                        break;

                    default:
                        opcaoInvalida();
                        break;
                }
                if (opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
        // Função para organizar o código, Ele busca o código em lugares separados, serve para deixar o seu código principal mais organizado.


        static void sair()
        {
            Console.WriteLine("Saindo...");
        }
        static void opcaoInvalida()
        {
            Console.WriteLine("Opção Inválida, digite novamente");
        }




    }
}