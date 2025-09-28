//Aprendendo novos comandos, e entendendo como cada um funciona.

using System;

    namespace Frases
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.Write("Olá, ");
                Console.WriteLine("Como vai?");
                Console.WriteLine("Pressione uma tecla para continuar..");
                Console.ReadKey();
                Console.WriteLine("Obrigado e até a proxima.");
                Console.WriteLine("Pressione uma tecla para finalizar..");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
                Console.Clear();

            }
        

        } 
    }

