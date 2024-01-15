using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex008Certo
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set;}

        public Aluno(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }


        public override string ToString()
        {
            return " Nome do aluno: " + Nome + " Email do aluno: " + Email;
        }
    }



}
