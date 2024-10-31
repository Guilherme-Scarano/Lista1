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

        int quantidadeImpares = ContarImpares(vetor);

        Console.WriteLine("A quantidade de valores ímpares no vetor é: " + quantidadeImpares);
    }

    static int ContarImpares(int[] vetor)
    {
        int contador = 0;

        foreach (int numero in vetor)
        {
            if (numero % 2 != 0)
            {
                contador++;
            }
        }

        return contador;
    }
}