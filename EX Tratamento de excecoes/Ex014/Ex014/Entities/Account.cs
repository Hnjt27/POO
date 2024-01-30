using Ex014.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex014.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() 
        { 
        }

        public Account(int number, string holder, double balance, double withDLm)
        { 
            Number = number;   
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDLm;    
        }

        public void Deposit(double amount) 
        {
            
            Balance = Balance + amount;
        }

        public void Withdraw(double amount) 
        {
            if (amount < Balance)
            {
                Balance = Balance - amount;

               Console.WriteLine("New balance: " + Balance.ToString());
            }
            if (amount > WithDrawLimit) 
            {
                throw new DomainException("The amount exceeds withdraw limit ");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance ");
            }

           
        }

        

    }
}
