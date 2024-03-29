﻿
using System;
using tabuleiro;

namespace xadrez_console
{
    internal class tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
     
                }
                Console.WriteLine();
            }

           
            Console.WriteLine("  A B C D E F G H");
        }

        public static void ColocarPeca(Peca peca) 
        {
            if (peca.cor == Cor.Branco)
            {
                Console.WriteLine(peca);
            }
            else if (peca.cor == Cor.Preto)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(peca);
                Console.ForegroundColor= aux;
            }
            else 
            {
                Console.WriteLine("Erro");
            }
        }
        
    }
}
