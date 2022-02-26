using System;

namespace interpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "     __  __      __  __ __   __  __ \n"+
                           "  |  __| __||__||__ |__   | |__||__|\n"+
                           "  | |__  __||    __||__|  | |__| __|\n";

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

            
            int leitorString = 4;

            for (int i = 0; i < primeiraCharLinha.Length; i = i + 4)
            {
                for (int j = 0; j < leitorString; j++)
                {
                    linha1 = Convert.ToString(primeiraCharLinha[j]);
                    linha2 = Convert.ToString(segundaCharLinha[j]);
                    linha3 = Convert.ToString(terceiraCharLinha[j]);
                    /*linha1 += "";
                    linha2 += "";
                    linha3 += "";*/
                    
                }
                if (linha1 == "    " && linha2 == "  | " && linha3 == "  | ")
                {
                    Console.WriteLine("1");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }

                else if (linha1 == " __ " && linha2 == " __|" && linha3 == "|__ ")
                {
                    Console.WriteLine("2");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }

                else if (linha1 == " __ " && linha2 == " __|" && linha3 == " __|")
                {
                    Console.WriteLine("3");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }

                else if (linha1 == "    " && linha2 == "|__|" && linha3 == "|   ")
                {
                    Console.WriteLine("4");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }
                else if (linha1 == " __ " && linha2 == "|__ " && linha3 == " __|")
                {
                    Console.WriteLine("5");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }
                else if (linha1 == " __ " && linha2 == "|__ " && linha3 == "|__|")
                {
                    Console.WriteLine("6");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }
                else if (linha1 == "__  " && linha2 == "  | " && linha3 == "  | ")
                {
                    Console.WriteLine("7");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }
                else if (linha1 == " __ " && linha2 == "|__|" && linha3 == "|__|")
                {
                    Console.WriteLine("8");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }
                else if (linha1 == " __ " && linha2 == "|__|" && linha3 == " __|")
                {
                    Console.WriteLine("9");
                    leitorString += 4;
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                }

            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

        }
    }
}
