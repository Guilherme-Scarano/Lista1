using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de caracteres que deseja inserir: ");
        int tamanho = int.Parse(Console.ReadLine());

        char[] caracteres = new char[tamanho];

        Console.WriteLine("Digite os caracteres:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Caractere {i + 1}: ");
            caracteres[i] = Console.ReadLine()[0];
        }

        Console.WriteLine($"Quantidade de elementos no vetor: {caracteres.Length}");

        Console.WriteLine("Vetor em ordem inversa:");
        for (int i = tamanho - 1; i >= 0; i--)
        {
            Console.Write(caracteres[i] + " ");
        }
    }
}