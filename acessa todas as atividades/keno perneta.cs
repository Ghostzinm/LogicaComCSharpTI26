using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class keno_perneta
    {
        public static void Perna()
        {
            double pd, pe;

            Console.WriteLine("keno, digite o tamanho da sua perna direita: ");
            pd = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("keno, digite o tamanho da sua perna esquerda: ");
            pe = Convert.ToDouble(Console.ReadLine());

            if (pe > pd)
            {
                Console.WriteLine("ala o cara é cotoco da perna direita kakakakak lol ");
            };

            if (pd > pe)
            {
                Console.WriteLine("ala o cara é cotoco da perna esquerda kakakakak lol");
            }
            else
            {
                Console.WriteLine("normal");
            };

        }
    }
}
