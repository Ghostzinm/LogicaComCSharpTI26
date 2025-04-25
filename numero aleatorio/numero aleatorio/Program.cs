using System;
using System.Threading;

namespace numero_aleatorio
{
    internal class Program
    {
        public class Ficha
        {
            //propriedades
            public string NomeDoJogador;
            public string NomeDoPersonagem;
            public string raca;
            public string classe;
            public int vida;

            public void Imprimirficha()
            {
                Console.WriteLine("\n");
                Console.WriteLine("================================");
                Console.WriteLine("======FICHA DO PERSONAGEM=======");
                Console.WriteLine("Nome do personagem: " + NomeDoPersonagem);
                Console.WriteLine("Raça: " + raca);
                Console.WriteLine("Classe: " + classe);
                Console.WriteLine("Vida: " + vida);
                Console.WriteLine("================================");
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int d6jogador = random.Next(1, 6);
            int d6inimigo = random.Next(1, 6);


            Ficha PersonagePrincipal = new Ficha(); //intanciar novo obj 


            PersonagePrincipal.NomeDoJogador = "gts";
            PersonagePrincipal.NomeDoPersonagem = "Aldir";
            PersonagePrincipal.raca = "elfo";
            PersonagePrincipal.classe = "guerreiro";
            PersonagePrincipal.vida = 100;


            Console.WriteLine("=====AVENTURA COMEÇA=====");
            PersonagePrincipal.Imprimirficha();
            Console.WriteLine("Voce esta bebendo em uma tarverna");
            Console.WriteLine("\nUma pesooa esbarra em voce. O que vc faz? \n[ 1 ] Se vira\n[ 2 ] Continua como se nada fosse ");

            string decisao = Console.ReadLine();

            if (decisao == "1")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("agora começa");
                Ficha inimigo = new Ficha();
                inimigo.NomeDoJogador = "NPC";
                inimigo.NomeDoPersonagem = "Baltazar";
                inimigo.raca = "humano";
                inimigo.classe = "ladrão";
                inimigo.vida = 50;

                while (inimigo.vida > 0 && PersonagePrincipal.vida > 0)
                {
                    //rolar os dados
                    d6jogador = random.Next(1, 6);
                    d6inimigo = random.Next(1, 6);


                    //*comparar valor dos dados
                    if (d6jogador > d6inimigo)
                    {

                        //*se p inimigo ganhou, dar dano no jogador

                        inimigo.vida -= 10;
                        Console.WriteLine("boa acertei");
                    }
                    else if (d6jogador < d6inimigo)
                    {
                        //*se o jogador ganhou, dar dano no Inimigo
                        PersonagePrincipal.vida -= 10;
                        Console.WriteLine("ai\n");
                        Console.WriteLine("voce tomou dano, quer fugir da luta? [s] [n]");
                        string fugir = Console.ReadLine();

                        if (fugir == "s")
                        {
                            Console.WriteLine("PARABENS VOCE FUGIU DA BRIGA");
                            break;
                        }
                       

                    }

                    //exibir vida do jogador 
                    Console.WriteLine("vida do jogador: " + PersonagePrincipal.vida);
                    Console.WriteLine("vida do inimigo: " + inimigo.vida);
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }

                //se a vida do jogador chegar a 0 mostrar "VOCE PERDEU"
                if (PersonagePrincipal.vida == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"
          )             (       (   (                
       ( /(   (         )\ )    )\ ))\ )             
 (   ( )\())  )\  (    (()/((  (()/(()/(  (      (   
 )\  )((_)\ (((_) )\    /(_))\  /(_))(_)) )\     )\  
((_)((_)((_))\___((_)  (_))((_)(_))(_))_ ((_) _ ((_) 
\ \ / // _ ((/ __| __| | _ \ __| _ \|   \| __| | | | 
 \ V /| (_) | (__| _|  |  _/ _||   /| |) | _|| |_| | 
  \_/  \___/ \___|___| |_| |___|_|_\|___/|___|\___/  
                                                     
");
                } else if (inimigo.vida == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
 _    ______  ____________   _________    _   ____  ______  __  __
| |  / / __ \/ ____/ ____/  / ____/   |  / | / / / / / __ \/ / / /
| | / / / / / /   / __/    / / __/ /| | /  |/ / /_/ / / / / / / / 
| |/ / /_/ / /___/ /___   / /_/ / ___ |/ /|  / __  / /_/ / /_/ /  
|___/\____/\____/_____/   \____/_/  |_/_/ |_/_/ /_/\____/\____/   
                                                                  
");
                    Console.ResetColor();

            }


            else
            {
                Console.WriteLine("continua bebendo");
            }
        }





    }
}

