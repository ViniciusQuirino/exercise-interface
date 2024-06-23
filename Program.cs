using System;
using Entities;
using Services;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter contract data");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            System.Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract, installments);

            System.Console.WriteLine();
            System.Console.WriteLine("Installments: ");

            foreach (Installment installment in contract.installments)
            {
                System.Console.WriteLine(installment);
            }
        }
    }
}