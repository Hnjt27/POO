using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_015.Services
{
    internal class PaypalService : IOnlinePaymentService
    {

        public double PaymentFee(double amount) 
        {
            amount += (amount * 0.02);
            return amount;
        }

        public double Interest(double amount, int months)
        {
            amount += ((amount * 0.01) * months);

            return amount;
        }


    }
}
