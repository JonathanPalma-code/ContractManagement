using System;
using System.Collections.Generic;

namespace ContractManagement.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double contractValue)
        {
            Number = number;
            Date = date;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }

        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
