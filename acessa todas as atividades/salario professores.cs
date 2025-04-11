using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessa_todas_as_atividades
{
    internal class salario_professores
    {
         public static void Sal()
        {/*11- Faça um algoritmo que efetue o cálculo do salário líquido de um professor. As informações fornecidas serão:
          * valor da hora aula, número de aulas lecionadas no mês e percentual de desconto do INSS. Imprima na tela o salário líquido final.*/

            double salario, Horas, NumeroDeAulas, desconto, dia, mes;

            Console.WriteLine("digite valor da hora aula: ");
            Horas = double.Parse(Console.ReadLine());

            Console.WriteLine("digite número de aulas lecionadas no mês: ");
            NumeroDeAulas = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o percentual de desconto do INSS");
            desconto = double.Parse(Console.ReadLine());

            dia = Horas * 8;
            mes = dia * NumeroDeAulas;

            salario = dia + mes - desconto;

            Console.WriteLine("seu salario liquido é: " + salario);

        }
    }
}
