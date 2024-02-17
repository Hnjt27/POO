using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX_015.Services
{
    interface IOnlinePaymentService
    {
         double PaymentFee(double amount);

         double Interest(double amount, int months);

    }
}
