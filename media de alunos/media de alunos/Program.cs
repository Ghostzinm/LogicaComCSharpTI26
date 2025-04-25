using System;

namespace media_de_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //· "Crie um programa que armazene as notas de 30 alunos e calcule a média da turma."

            string[] alunos = { "Maria Souza", "João Silva", "Pedro Oliveira", "Ana Costa", "Lucas Pereira", "Carla Mendes", "Gabriel Rocha", "Fernanda Almeida", "Thiago Santos", "Juliana Lima", "Rafael Fernandes", "Beatriz Martins", "Felipe Gomes", "Luana Ferreira", "Marcos Ribeiro", "Larissa Almeida", "André Costa", "Camila Oliveira", "Victor Silva", "Larissa Souza", "Leonardo Alves", "Renata Pereira", "Gustavo Carvalho", "Juliana Rocha", "Samuel Dias", "Mariana Costa", "Felipe Rodrigues", "Carolina Mendes", "João Pedro Santos", "Vanessa Silva" };
            double[] notas = { 8, 4, 9, 6, 5, 7, 4, 6, 10, 9, 8, 3, 6, 7, 4, 10, 6, 8, 7, 5, 8, 6, 4, 9, 5, 10, 8, 7, 10, 8 };
            double soma = 0;
            double media = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Nomes\t\t\tNotas \n");
            Console.ResetColor();

            for (int i = 0; i < alunos.Length; i++)
            {

                Console.Write(alunos[i]);
                Console.Write("\t\t");
                Console.WriteLine(notas[i]);

                soma += notas[i];
               

            }
            media = soma / 30;
            Console.WriteLine("\nMédia da turma: " + media);

        }
    }
}
