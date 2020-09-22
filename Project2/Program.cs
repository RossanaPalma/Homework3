/// Chapter No. 3		Exercise No. 2
/// File Name: Program.cs - Project 2 
/// /// @author: Rossana Palma
/// Date:  September 21, 2020
///
/// Problem Statement: Write a program that determines the change to be dispensed by vending machine. Each item in the machine can be cost between
/// 25 cents and 1 dollar, in 5-cent increments and the machine accepts only a single dollar bill to pay for the item.  
/// 
/// Overall Plan:
/// 1) Declare variables.
/// 2) Ask for price.
/// 3) Calculates the change.
/// 4) Display the purchase value and how the change will be given.
/// 
/// 
using System;
using System.Transactions;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n1, n2, n3, n4, amount; 

            // Ask for price
            Console.WriteLine("Enter price of item (from 25 cents to a dollar, in 5-cent increments)");
            String userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            
            // Calculations
            amount = 100 - n1; 
            n2 = amount / 25;
            amount = amount % 25;
            n3 = amount / 10;
            n4 = amount / 5;

            // Display output

            Console.WriteLine("You bought an item for " + n1 + " cents and gave me a dollar, so your change is ");
            Console.WriteLine(n2 + " quarters");
            Console.WriteLine(n3 + " dimes", "and");
            Console.WriteLine(n4 + " nickles");
           
        }

    }
}
