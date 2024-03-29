﻿using tabuleiro;

namespace xadrez_console.jogoDeXadrez
{
    internal class PosicaoXadrez
    {
        public int Linha { get; set; }
        public char Coluna { get; set; }

        public PosicaoXadrez(int linha, char coluna)
        {
            Linha = linha;
            Coluna = coluna;

        }

        public Position toPosition()
        {
            return new Position(8 - Linha, Coluna - 'a');
        }
        

        public override string ToString()
        {
            return " " + Linha + "," + Coluna;
        }
    }
}
