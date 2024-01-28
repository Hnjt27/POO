using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_013.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpendutiries { get; set; }


        public Individual() 
        { 
        
        }

        public Individual(string name, double anualInc, double healthExp) : base(name, anualInc)
        {
             HealthExpendutiries = healthExp;   
        }

        public override double Tax()
        {
            double imposto;

            if (AnualIncome < 20000.00)
            { 
                imposto  = AnualIncome * 15/100;
            
            }
            else 
            {
                imposto = AnualIncome * 25/100;
            

            }

            double healthExpMid;

            if (HealthExpendutiries > 0)
            {
                healthExpMid = HealthExpendutiries / 2;

                imposto -= healthExpMid;
            }
            
            return  imposto;
        }

        public override string ToString()
        {
            return Tax().ToString();
        }
    }
    
}
