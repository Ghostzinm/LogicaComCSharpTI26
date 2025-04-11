using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades.Cadastro_de_artista
{
    internal class Calcular_idade
    {
        public static void Idd()
        {
            //declara variavel inteiras
            int ano_nascimento, ano_atual, Idade;

            //console.WriteLine = escreva
            Console.WriteLine("Digite o ano do seu nascimento: ");
            ano_nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            Idade = ano_atual - ano_nascimento;
            Console.WriteLine("Sua Idade é " + Idade + " anos");

        }
    }
}
