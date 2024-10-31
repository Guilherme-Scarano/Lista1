using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as cinco notas (separadas por espaço e use ponto para decimais):");
        string input = Console.ReadLine();

        string[] notasStr = input.Split(' ');
        float[] notas = Array.ConvertAll(notasStr, s => float.Parse(s, CultureInfo.InvariantCulture));

        Array.Sort(notas);

        float notaFinal = notas[1] + notas[2] + notas[3];

        Console.WriteLine("Nota final da escola de samba: {0}", notaFinal.ToString("0.0", new CultureInfo("pt-BR")));
    }
}