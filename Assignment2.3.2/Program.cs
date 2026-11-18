/*
Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

Use the format specifiers to display currency, % symbol.
*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the bill total:");
        string? billInput = Console.ReadLine();
        Console.WriteLine("Enter the tip percentage:");
        string? tipInput = Console.ReadLine();

        if (billInput != null && tipInput != null &&
            decimal.TryParse(billInput, out decimal billTotal) &&
            decimal.TryParse(tipInput, out decimal tipPercentage))
        {
            decimal tipAmount = billTotal * tipPercentage / 100;
            decimal grandTotal = billTotal + tipAmount;
            Console.WriteLine($"Tip Amount: {tipAmount:C}");
            Console.WriteLine($"Grand Total: {grandTotal:C}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
