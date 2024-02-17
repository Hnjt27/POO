using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_015.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installments> Installments;

    
        public Contract(int number, DateTime date, double totalvalue) 
        { 
            Number = number;
            Date = date;    
            TotalValue = totalvalue;
            Installments = new List<Installments>();
        }


        public void AddInstallment(Installments installment)
        {
            Installments.Add(installment);
        }
      
    }
}
