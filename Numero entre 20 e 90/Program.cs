using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Numero_entre_20_e_90
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Contrua um algoritimo que indique se um numero esta entre 20 e 90
            int numero;

            Console.WriteLine("digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            if(numero > 20 && numero < 90){
                Console.WriteLine("Numero esta entre 20 e 90");
             } else {
                 Console.WriteLine("Numero nao esta entre 20 e 90");
             }                   
        }
    }
}
