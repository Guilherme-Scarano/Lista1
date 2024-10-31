using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de elementos (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] numeros = new int[N];

        Console.WriteLine("Digite os elementos do vetor:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite um valor para verificar quantas vezes aparece no vetor: ");
        int valorParaVerificar = int.Parse(Console.ReadLine());

        int contador = 0;
        foreach (int numero in numeros)
        {
            if (numero == valorParaVerificar)
            {
                contador++;
            }
        }

        Console.WriteLine("Elementos do vetor:");
        Console.WriteLine(string.Join(", ", numeros));

        Console.WriteLine($"O valor {valorParaVerificar} aparece {contador} vezes no vetor.");
    }
}