using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho do vetor (n): ");
        int n = int.Parse(Console.ReadLine());

        double[] vetor = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor inserido:");
        Console.WriteLine(string.Join(", ", vetor));

        double maior = MaiorElemento(vetor);

        Console.WriteLine("O maior elemento do vetor é: " + maior);
    }

    static double MaiorElemento(double[] vetor)
    {
        double maior = vetor[0];

        foreach (double numero in vetor)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        return maior;
    }
}