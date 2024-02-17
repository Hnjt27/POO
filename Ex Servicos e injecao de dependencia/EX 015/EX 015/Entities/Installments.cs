using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_015.Entities
{
    internal class Installments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }


        public Installments() 
        { 
        }

        public Installments(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount;
        }
    }
}
