using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX010
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of lines the matrix should have: ");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns the matrix should have: ");
            int c = int.Parse(Console.ReadLine());

            double[,] mat = new double[l, c];

            for (int i = 0; i < l; i++) {

                Console.WriteLine("Digite os valores da matriz");
                string[] vect = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++) {

                    mat[i,j] = int.Parse(vect[j]);

                }

            }

            Console.WriteLine("Digite o numero que deseja pesquisar dentro da matriz: ");
            int searchNum = int.Parse(Console.ReadLine());

            int searchLin = mat.GetLength(0);
            int searchCol = mat.GetLength(1);

           
           
            for (int i = 0; i < searchLin; i++)
            {
                for (int j = 0; j < searchCol; j++)
                {
             
                    if (searchNum == mat[i,j])
                    {
                        
                        Console.WriteLine(i + " " + j);

                        int up = i - 1;
                        int down = i + 1;
                        int left = j - 1;
                        int right = j + 1;

                        if (up < 0 || up >= searchCol)
                        {
                            Console.WriteLine("O valor acima do " + searchNum + " está fora da matrix");
                        }
                        else 
                        {
                            Console.WriteLine("O valor acima do " + searchNum + " é " + mat[up, j]);
                        }

                        if (down < 0 || down >= searchCol)
                        {
                            
                            Console.WriteLine("O valor abaixo do " + searchNum + " está fora da matriz");
                        }
                        else
                        {
                            Console.WriteLine("O valor abaixo do " + searchNum + " é " + mat[down, j]);
                        }

                        if (left < 0 || left >= searchLin)
                        {
                            Console.WriteLine("O valor a esquerda do " + searchNum + " está fora da matriz");
                        }
                        else
                        {
                            Console.WriteLine("O valor a esquerda do " + searchNum + " é " + mat[i, left]);
                        }

                        if (right < 0 || right >= searchLin)
                        {
                            Console.WriteLine("O valor a direita do " + searchNum + " está fora da matriz ");
                        }
                        else
                        {
                            Console.WriteLine("O valor a direita do " + searchNum + " é " + mat[i, right]);
                        }
                    }
          
                 
                }
            }
            


            Console.ReadLine();
           
            
        
        }


    }
}
