using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pokemons = { "Pikachu   ","Bulbasaur ", "Charmander", "Squirtle  ", "Eevee     ", "Jigglypuff", "Meowth    ", "Snorlax   ", "Gengar    ", "Charizard " };
            int[] geracao = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            string[] tipagem = {
    "Elétrico         ",
    "Grama / Venenoso ",
    "Fogo             ",
    "Água             ",
    " Normal          ",
    "Normal / Fada    ",
    "Normal           ",
    "Normal           ",
    "Fantasma / Venenoso",
    " Fogo / Voador   "
};

            double[] tamanho = { 0.4, 0.7, 0.6, 0.5, 0.3, 0.5, 0.4, 2.1, 1.5, 1.7 };
            double[] peso = { 6.0, 6.9, 8.5, 9.0, 6.3, 5.5, 4.2, 460, 40.5, 90.5 };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Nome\t\tGeração\t\t\ttipo\t\t\t\ttamanho\t\tpeso\n");
            Console.ResetColor();

            for (int i = 0; i < pokemons.Length; i++)
            {

                Console.Write(pokemons[i]);
                Console.Write("\t\t");
                Console.Write(geracao[i]);
                Console.Write("\t\t");
                Console.Write(tipagem[i]);
                Console.Write("\t\t");
                Console.Write(tamanho[i]);
                Console.Write("\t\t");
                Console.WriteLine(peso[i]);


            }
        }
    }
}
