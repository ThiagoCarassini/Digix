using System;

class Program
{
    static void teste()
    {
        int numero;
        int menor = int.MaxValue; 
        int maior = int.MinValue;  

        while (true)
        {
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == -1)
                break;

            if (numero > 0)
            {
                if (numero < menor)
                    menor = numero;

                if (numero > maior)
                    maior = numero;
            }
            else
            {
                Console.WriteLine("Por favor, digite apenas números inteiros positivos.");
            }
        }

        if (maior != int.MinValue && menor != int.MaxValue)
        {
            Console.WriteLine($"Menor número: {menor}");
            Console.WriteLine($"Maior número: {maior}");
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi inserido.");
        }
    }
}
