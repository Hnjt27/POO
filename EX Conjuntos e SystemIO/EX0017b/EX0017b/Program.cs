using System.Linq.Expressions;
using System;
using System.IO;
using EX0017b.Entities;


namespace EX0017b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord{ UserName = name, Instant = instant });
                        //Console.WriteLine(line);
                    }

                    Console.WriteLine("Total users: " + set.Count);
                }


            }
            catch (IOException e)
            { 
                Console.WriteLine(e.Message);
            }
                
        }
       
    }
}
