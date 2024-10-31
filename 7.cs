using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de elementos (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[N];
        int[] vetor2 = new int[N];
        int[] resultado = new int[N];

        Console.WriteLine("Digite os elementos do primeiro vetor:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos do segundo vetor:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        Console.WriteLine("Vetor resultante da multiplicação:");
        Console.WriteLine(string.Join(", ", resultado));
    }
}