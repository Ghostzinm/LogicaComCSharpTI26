using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impa_ou_par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.WriteLine("Digite um numero: ");
            num1 = double.Parse(Console.ReadLine());
            if(num1 % 2 == 1){
                Console.WriteLine("Este numero é impar");
    }
            else{
                Console.WriteLine("Este numero é par");
    }
        }
    }
}
