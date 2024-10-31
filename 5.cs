using System;

class Program
{
    static void Main()
    {
        const int tamanhoMaximo = 50;

        char[] dna = new char[tamanhoMaximo];
        int n;

        Console.Write("Digite o número de bases do DNA (máximo de 50): ");
        n = int.Parse(Console.ReadLine());

        if (n > tamanhoMaximo || n < 1)
        {
            Console.WriteLine("Número de bases inválido. Deve ser entre 1 e 50.");
            return;
        }

        Console.WriteLine("Digite as bases do DNA (A, T, C, G):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Base {i + 1}: ");
            char baseDNA = char.ToUpper(Console.ReadLine()[0]);

            if (baseDNA == 'A' || baseDNA == 'T' || baseDNA == 'C' || baseDNA == 'G')
            {
                dna[i] = baseDNA;
            }
            else
            {
                Console.WriteLine("Base inválida. Apenas A, T, C e G são permitidas.");
                i--;
            }
        }

        char[] complementar = GerarComplementar(dna, n);

        Console.WriteLine("Vetor DNA: " + new string(dna, 0, n));
        Console.WriteLine("Vetor complementar: " + new string(complementar, 0, n));
    }

    static char[] GerarComplementar(char[] dna, int n)
    {
        char[] complementar = new char[n];

        for (int i = 0; i < n; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    complementar[i] = 'T';
                    break;
                case 'T':
                    complementar[i] = 'A';
                    break;
                case 'C':
                    complementar[i] = 'G';
                    break;
                case 'G':
                    complementar[i] = 'C';
                    break;
            }
        }

        return complementar;
    }
}