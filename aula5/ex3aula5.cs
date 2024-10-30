using System;

class Program
{
    static void Main()
    {
        string senhaCorreta = "Digix";
        Console.Write("Digite a senha: ");
        string senhaInformada = Console.ReadLine();

        if (senhaInformada == senhaCorreta)
        {
            Console.WriteLine("Acesso autorizado");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}
