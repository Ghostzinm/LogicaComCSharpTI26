using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idd;

            Console.WriteLine("Digite sua idade: ");
            idd = int.Parse(Console.ReadLine());
            if (idd >= 18)
            {
                Console.WriteLine("voce é maior de idade");
            } else {
                Console.WriteLine("voce é menor de idade");
            }
        }
    }
}
