using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, sobra;

            Console.WriteLine("Digite o peso pescado: ");
            peso = double.Parse(Console.ReadLine());
            sobra = (peso - 50) * 4;
            Console.WriteLine(sobra);
        }
    }
}
