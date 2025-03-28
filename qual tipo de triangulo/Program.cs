using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qual_tipo_de_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;

            Console.WriteLine("Digite um dos lados do triângulo: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado do triângulo: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            lado3 = double.Parse(Console.ReadLine());

            if(lado1 == lado2  && lado1 == lado3 || lado2 == lado1  && lado2 == lado3 || lado3 == lado2  && lado3 == lado1){
                Console.WriteLine("O triângulo é um equilátero.");
    }
            else if(lado1 == lado2  && lado1 != lado3 || lado1 == lado3  && lado1 != lado2 || lado2 == lado1  && lado2 != lado3 || lado2 == lado3  && lado2 != lado1){
                Console.WriteLine("O triângulo é um isósceles.");
    }
            else{
                Console.WriteLine("O triângulo é um escaleno.");
    }
        }
    }
}
