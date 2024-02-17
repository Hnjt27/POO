using System;
using System.Collections.Generic;
using EX_015.Entities;


namespace EX_015.Services
{
    internal class ContractServices
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractServices(IOnlinePaymentService onlinePaymentService) 
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProccesContract(Contract contract, int months)
        {
            double amountInstallments =  contract.TotalValue/months;

            for(int i = 1; i-1 < months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double inteValue = _onlinePaymentService.Interest(amountInstallments, i);
                double pFeeValue = _onlinePaymentService.PaymentFee(inteValue);
                contract.AddInstallment(new Installments(date, pFeeValue));               
            }

        }
    }
}
