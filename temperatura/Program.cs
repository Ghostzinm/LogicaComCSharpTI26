using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double temperatura;

            Console.WriteLine("Digite a temperatura em Celcius: ");
            temperatura = double.Parse(Console.ReadLine());


             if(temperatura < 15){
                Console.WriteLine("Está frio 🥶");
    }
            else if(temperatura >= 15 && temperatura <= 25){
                Console.WriteLine("Está ameno 😎");
    }
            else{
                Console.WriteLine("Está quente 🥵");
    }
        }
    }
}
