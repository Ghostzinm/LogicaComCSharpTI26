using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia_mais_frio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] semana = { "domingo", "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sabado" };
            double[] temp = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Informe a temperatura do dia {i + 1} (em °C): ");
                temp[i] = Convert.ToDouble(Console.ReadLine());
            }

            int diaQuente = 0, diaFrio = 0;
            double tempQuente = temp[0], tempFria = temp[0];

            for (int i = 1; i < 7; i++)
            {
                if (temp[i] > tempQuente)
                {
                    tempQuente = temp[i];
                    diaQuente = i;
                }
                if (temp[i] < tempFria)
                {
                    tempFria = temp[i];
                    diaFrio = i;
                }
            }

            // Exibindo os resultados
            Console.WriteLine($"\nO dia mais quente foi o dia {diaQuente + 1} com {tempQuente}°C.");
            Console.WriteLine($"\nO dia mais frio foi o dia {diaFrio + 1} com {tempFria}°C.");
        }
    }
}
