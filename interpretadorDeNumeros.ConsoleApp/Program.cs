using System;

namespace interpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "     __  __        __   __ __   __   __\n" +
                           "  |  __| __| |__| |__  |__   | |__| |__|\n" +
                           "  | |__  __| |     __| |__|  | |__|  __|\n";

            System.IO.StringReader leitor = new System.IO.StringReader(texto);

            string primeiraLinha = leitor.ReadLine();
            char[] primeiraCharLinha = primeiraLinha.ToCharArray();

            string segundaLinha = leitor.ReadLine();
            char[] segundaCharLinha = segundaLinha.ToCharArray();

            string terceiraLinha = leitor.ReadLine();
            char[] terceiraCharLinha = terceiraLinha.ToCharArray();

            string linha1 = "";
            string linha2 = "";
            string linha3 = "";

            int contador = 0;
            int leitorString = 4;

            for (int i = 0; i < primeiraCharLinha.Length; i = i + 4)
            {
                for (int j = contador; j < leitorString; j++)
                {
                    linha1 = Convert.ToString(primeiraCharLinha[i]);
                    linha2 = Convert.ToString(segundaCharLinha[i]);
                    linha3 = Convert.ToString(terceiraCharLinha[i]);
                    contador++;
                }
                if (linha1 == "   " && linha2 == "  | " && linha3 == "  | ")
                    Console.WriteLine("1");
                leitorString += 4;

            }

            Console.ReadKey();

        }
    }
}
