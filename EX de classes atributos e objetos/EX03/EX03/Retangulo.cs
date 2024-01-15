using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    public class Retangulo
    {
        public double largura;
        public double altura;


        public double Area()
        {

            return largura * altura;
        }


        public double Perimetro()
        {

            return 2 * (largura + altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }

        public override string ToString()
        {
            return   "Area: " + 
                     Area() + 
                     "\nPerimetro: " + 
                     Perimetro() + 
                     "\nDiagonal: " +
                     Diagonal();   
        }

    }
}
