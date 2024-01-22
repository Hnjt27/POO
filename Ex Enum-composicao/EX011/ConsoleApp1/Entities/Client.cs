using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }

        public Client() 
        { 
        
        }

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            Birth = birth;
        }

        public override string ToString()
        {
            return Name + ", " 
                   + Email + ", "
                   + Birth.ToString("dd/MM/yyyy");
        }
    }
}
