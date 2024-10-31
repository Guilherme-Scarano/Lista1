using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a mensagem codificada:");
        string mensagemCodificada = Console.ReadLine();

        var mensagemDecodificada = new System.Text.StringBuilder();

        for (int i = 0; i < mensagemCodificada.Length; i++)
        {
            if (mensagemCodificada[i] == 'p')
            {
                if (i + 1 < mensagemCodificada.Length && char.IsLetter(mensagemCodificada[i + 1]))
                {
                    mensagemDecodificada.Append(mensagemCodificada[i + 1]);
                    i++;
                }
            }
            else
            {
                mensagemDecodificada.Append(mensagemCodificada[i]);
            }
        }

        Console.WriteLine("Mensagem decodificada:");
        Console.WriteLine(mensagemDecodificada.ToString());
    }
}