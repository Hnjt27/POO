using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    internal class Peca
    {
        public Position position { get; set; }
        public Cor cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca(Cor cor, Tabuleiro tab )
        { 
            this.position = null;
            this.cor = cor; 
            this.tab = tab;
            QtdMovimentos = 0;
        
        }
    }
}
