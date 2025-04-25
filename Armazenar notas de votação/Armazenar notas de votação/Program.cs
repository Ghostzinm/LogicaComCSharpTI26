using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armazenar_notas_de_votação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

class Program
        {
            static void Main()
            {
                int[,] notas = new int[10, 5]; // 10 participantes e 5 jurados
                double[] medias = new double[10];

                // Entrada das notas
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Informe as notas para o participante {i + 1}:");
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"Nota do jurado {j + 1}: ");
                        notas[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                // Cálculo das médias
                for (int i = 0; i < 10; i++)
                {
                    double soma = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        soma += notas[i, j];
                    }
                    medias[i] = soma / 5;
                }

                // Exibição das médias
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Média do participante {i + 1}: {medias[i]:F2}");
                }
            }
        }

    }
}
}
