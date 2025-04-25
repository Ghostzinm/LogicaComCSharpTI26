using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos_em_esroque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {
    "Camiseta Masculina", "Tênis Esportivo", "Jaqueta de Couro", "Relógio de Pulso", "Mochila Escolar",
    "Fone de Ouvido Bluetooth", "Óculos de Sol", "Caderno de Notas", "Caneta Esferográfica", "Batedeira",
    "Lava-Louças", "Geladeira", "Micro-ondas", "Televisão 4K", "Smartphone", "Tablet", "Computador",
    "Teclado Mecânico", "Mouse Óptico", "Cadeira Gamer", "Cama Box", "Colchão King Size", "Travesseiro",
    "Roupão de Banho", "Toalha de Rosto", "Aspirador de Pó", "Máquina de Café Expresso", "Liquidificador",
    "Sofá de 3 Lugares", "Mesa de Jantar", "Cadeira de Escritório", "Abajur", "Cortina para Sala",
    "Prato de Jantar", "Copos de Vidro", "Talheres de Aço Inoxidável", "Frigideira Antiaderente",
    "Conjunto de Panelas", "Grelha Elétrica", "Garfo de Churrasco", "Espremedor de Frutas", "Caneca Térmica",
    "Suporte para Celular", "Luminária LED", "Carregador Portátil", "Placa de Video", "Câmera Fotográfica",
    "Lente de Câmera", "Kit de Maquiagem", "Perfume Feminino", "Shampoo e Condicionador", "Creme Hidratante"
};

            int[] quantidade = {
    23, 67, 12, 45, 98, 34, 56, 89, 21, 67,
    10, 33, 78, 42, 56, 39, 76, 22, 61, 47,
    58, 90, 39, 80, 24, 52, 67, 16, 73, 28,
    95, 41, 38, 57, 30, 50, 64, 88, 92, 53,
    59, 84, 77, 32, 46, 70, 64, 84, 33, 55};

            int maiorIndex = 0, menorIndex = 0;

            for (int i = 1; i < 50; i++)
            {
                if (quantidade[i] > quantidade[maiorIndex])
                    maiorIndex = i;

                if (quantidade[i] < quantidade[menorIndex])
                    menorIndex = i;
            }

            // Exibindo os resultados
            Console.WriteLine($"\nProduto com maior quantidade: {produtos[maiorIndex]} com {quantidade[maiorIndex]} unidades.");
            Console.WriteLine($"Produto com menor quantidade: {produtos[menorIndex]} com {quantidade[menorIndex]} unidades.");

        }
    }
}
