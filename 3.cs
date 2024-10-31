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

        double menor = MenorElemento(vetor);

        Console.WriteLine("O menor elemento do vetor é: " + menor);
    }

    static double MenorElemento(double[] vetor)
    {
        double menor = vetor[0];

        foreach (double numero in vetor)
        {
            if (numero < menor)
            {
                menor = numero;
            }
        }

        return menor;
    }
}