using System;

namespace aula4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float valor = 0, valor2 = 0;
            int tempo, investimento, i;

            Console.WriteLine("Insira o valor do investimento: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Por quantos meses?");
            tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o tipo de investimento (1, 2 ou 3)?");
            investimento = int.Parse(Console.ReadLine());

            if (investimento == 1)
            {
                for (i = 0; i < tempo; i++)
                {
                    valor *= (float)1.25; // o f é para transformar o número em float
                }
                Console.WriteLine($"Valor após {tempo} meses: {valor}");
            }
            else if (investimento == 2)
            {
                for (i = 0; i < tempo; i++)
                {
                    // tem que transformar o número em float porque quando atribui um número a uma variável, ela assume o tipo do número
                    valor *= (float)1.42;
                }
                Console.WriteLine($"Valor após {tempo} meses: {valor}");
            }
            else if (investimento == 3)
            {
                for (i = 0; i < tempo; i++)
                {
                    valor *= (float)1.25;
                }
                valor2 = valor * (float)1.5;

                Console.WriteLine($"Você tem 5% de chance de perder: {valor2}");
                Console.WriteLine($"Você tem 95% de chance de ganhar: {valor}");
            }
            else
            {
                Console.WriteLine("Tipo de investimento inválido.");
            }
        }
    }
}