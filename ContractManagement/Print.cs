using System;
using ContractManagement.Entities;

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

            Contract contract = new Contract(id, date, value);
        }
    }
}
