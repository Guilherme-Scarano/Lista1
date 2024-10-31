using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho do vetor (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int soma = SomaElementos(vetor);

        Console.WriteLine("A soma dos elementos do vetor é: " + soma);
    }

    static int SomaElementos(int[] vetor)
    {
        int soma = 0;

        foreach (int numero in vetor)
        {
            soma += numero;
        }

        return soma;
    }
}