using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.Write("Digite o número de elementos (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] numeros = new int[N];

        for (int i = 0; i < N; i++)
        {
            numeros[i] = random.Next(1, 101);
        }

        Console.WriteLine("Números sorteados: " + string.Join(", ", numeros));

        Console.Write("Digite um número para verificar se está no vetor: ");
        int numeroParaVerificar = int.Parse(Console.ReadLine());

        int posicao = Array.IndexOf(numeros, numeroParaVerificar);

        if (posicao != -1)
        {
            Console.WriteLine($"O número {numeroParaVerificar} está na posição {posicao} do vetor.");
        }
        else
        {
            Console.WriteLine($"O número {numeroParaVerificar} não está no vetor.");
        }
    }
}