using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_013.Entities
{
    internal class Company : TaxPayer
    {
        public int NumbOfEmployees { get; set; }

        public Company() 
        { 
        
        }

        public Company(string name, double anualInc, int numbOfEmployees) : base(name, anualInc)
        {
            NumbOfEmployees = numbOfEmployees;
        }

        public override double Tax()
        {
            double imposto;

            if (NumbOfEmployees > 10)
            {
                imposto = AnualIncome * 14/100;
              
            }
            else 
            {
                imposto = AnualIncome * 16 / 100;
              
            }

            return imposto;
                
        }

        public override string ToString()
        {
            return Tax().ToString();
        }
    }
}
