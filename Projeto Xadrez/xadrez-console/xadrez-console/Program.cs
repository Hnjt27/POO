using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using jogoDeXadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Rei(Cor.Preto, tab), new Position(3, 4));
                tab.ColocarPeca(new Rei(Cor.Branco, tab), new Position(2, 2));


                tela.imprimirTabuleiro(tab);


                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
