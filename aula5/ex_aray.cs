using System;

namespace aula5
     {
        internal class program
        {
           
           public static void Main(string[] args)
        {       
                
                
                
        
        int [] numeros = new int [10];


        for(int i == 0; i<= 10; i++)
        {

            System.Console.WriteLine("digite o numero {0}: " i+1);
            numeros[i] = int.Parse(Console.ReadLine());

        }

        int menor = numeros[0];
        int maior = numeros[0];



          foreach (int num in numeros)
            {
                if (num < menor)
                    menor = num;

                if (num > maior)
                    maior = num;
                    
                    
             }

         Console.WriteLine("Maior número: " + maior);
         Console.WriteLine("Menor número: " + menor);





        }
     }
        