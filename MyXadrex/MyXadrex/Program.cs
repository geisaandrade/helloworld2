using System;
using tabuleiro;

namespace MyXadrex
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posiçao: " + P);

            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.ReadLine();
        }
    }
}
