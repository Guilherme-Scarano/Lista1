using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de lançamentos do dado (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] lancamentos = new int[N];

        Console.WriteLine("Digite os resultados dos lançamentos (números de 1 a 6):");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Lançamento {i + 1}: ");
            lancamentos[i] = int.Parse(Console.ReadLine());
        }

        int[] contagemFaces = new int[6];

        foreach (int resultado in lancamentos)
        {
            if (resultado >= 1 && resultado <= 6)
            {
                contagemFaces[resultado - 1]++;
            }
            else
            {
                Console.WriteLine($"Resultado inválido: {resultado}. Apenas números de 1 a 6 são permitidos.");
            }
        }

        Console.WriteLine("\nNúmero de ocorrências de cada face do dado:");
        for (int i = 0; i < contagemFaces.Length; i++)
        {
            Console.WriteLine($"Face {i + 1}: {contagemFaces[i]} ocorrências");
        }
    }
}