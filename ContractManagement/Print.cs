using System;
using ContractManagement.Entities;
using ContractManagement.Services;

namespace ContractManagement
{
    class Print
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the contract details");
            Console.Write("Contract ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of installments: ");
            int installmentsQty = int.Parse(Console.ReadLine());

            Contract contract = new Contract(id, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ContractProcess(contract, installmentsQty);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
