using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06
{
    public static class Conversordemoeda
    {
        public static double dolar = 3.10;
        public static double qtdcompra;
        public static double reais;


        public static double conversao(double qtdcompra){

            qtdcompra = qtdcompra + (qtdcompra * 6 / 100);
            return reais = qtdcompra * dolar;
        }
    }
}
