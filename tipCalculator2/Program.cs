using System;

namespace tipCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the total of your bill?");

            string totalBillInput = Console.ReadLine();
            totalBillInput = totalBillInput.Trim().Trim('$');

            Console.WriteLine("What percentage do you want to tip?");

            string tipPercentageInput = Console.ReadLine();
            tipPercentageInput = tipPercentageInput.Trim().Trim('%');

            //decimal totalBill = decimal.Parse(totalBillInput);
            decimal tipPercentage;
            //int tipPercentage = int.Parse(tipPercentageInput);
            if (!decimal.TryParse(tipPercentageInput, out tipPercentage))
            {
                Console.WriteLine($"{tipPercentageInput} is an invalid value");

            }
            decimal totalBill;
             if (!decimal.TryParse(totalBillInput, out totalBill))
            {
                Console.WriteLine($"{totalBillInput} is an invalid value");

            }
            decimal tipAmount = tipPercentage * totalBill / 100;
            tipAmount = Math.Round(tipAmount, 2);
            Console.WriteLine($"You're tip will be ${tipAmount} and your total bill is ${totalBill}.");
            Console.ReadLine();





        }
    }
}
