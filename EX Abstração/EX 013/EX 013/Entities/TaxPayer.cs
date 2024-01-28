﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_013.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome{ get; set; }


        public  TaxPayer() 
        { 

        }

        public TaxPayer(string name, double anualInc)
        {
            Name = name;
            AnualIncome = anualInc;
        }

        public abstract double Tax();
    }

    

}
