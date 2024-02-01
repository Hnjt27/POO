using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];

        }

        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }

        public Peca peca(Position pos)
        {
            return pecas[pos.Line, pos.Column];
        }

        public void ColocarPeca(Peca p, Position pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peça nessa posição");
            }
            else
            {
                pecas[pos.Line, pos.Column] = p;
                p.position = pos;
            }
        }

        public bool PosicaoValida(Position pos)
        {

            if (pos.Line > 7 || pos.Line < 0 || pos.Column > 7 || pos.Column < 0)
            {
                return false;
            }
            return true;

        }

        public void ValidarPosicao(Position pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição invalida");
            }
        }

        public bool existePeca(Position pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;

        }

    }

 }
