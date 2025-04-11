using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class desconto
    {
        public static void Desc()
        {

            double num1, des, total;
            Console.WriteLine("digite o numero ");
            num1 = double.Parse(Console.ReadLine());

            if (num1 >= 100)
            {
                des = num1 * 0.10;
                total = num1 - des;
                Console.WriteLine(des);
            }
            else
            {
                des = num1 * 0.05;
                total = num1 - des;
                Console.WriteLine(des);

            }
        } 
    }
}
