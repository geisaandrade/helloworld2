using System;
using tabuleiro;


namespace MyXadrex
{
    class Tela
    {
        public static void DisplayTabuleiro(Tabuleiro tab)
        {
            for (int i= 0; i<tab.linhas; i++)
            {
                for( int j=0; j<tab.colunas; j++)
                {
                    if(tab.peca(i,j)==null)
                    {
                        Console.Write("- "); ///errei ao escrever writeline inves de write
                    }
                    else

                    {
                        Console.Write(tab.peca(i, j) + "  ");
                    }

                    
                }
                Console.WriteLine();
            }


        }

    }
}
