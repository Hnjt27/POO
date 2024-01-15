using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    public class Aluno
    {
        public string nome = "";
        public double nota1;
        public double nota2;
        public double nota3;


        public double CalcMedia()
        {
            return nota1 + nota2 + nota3;
        }

        public double Res()
        {
            return 60 - CalcMedia() ;
        }

    }
}
