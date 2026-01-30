//SabraFisher
using System;

namespace VendingMachine1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Free Vending Machine!");
            Console.WriteLine();
            Console.WriteLine("Please make a selection from the following options:");
            string[] items = { "1. Soda", "2. Chips", "3. Candy", "4. Water", "5. Juice", "6. Gum" };
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.Write("Enter the number of your selection:    ");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You have selected " + input);
            Console.WriteLine();

            // Switch moved back into Main; each case delegates to a focused method
            switch (input?.Trim())
            {
                case "1":
                    VendSoda();
                    break;
                case "2":
                    VendChips();
                    break;
                case "3":
                    VendCandy();
                    break;
                case "4":
                    VendWater();
                    break;
                case "5":
                    VendJuice();
                    break;
                case "6":
                    VendGum();
                    break;
                default:
                    HandleInvalidSelection();
                    break;
            }

            Console.WriteLine("Thank you for using the Free Vending Machine!");
        }

        // Extracted per-selection behavior into individual methods for clarity and reuse
        private static void VendSoda()
        {
            Console.WriteLine("Vending Soda...");
            Console.WriteLine();
        }

        private static void VendChips()
        {
            Console.WriteLine("Vending Chips...");
            Console.WriteLine();
        }

        private static void VendCandy()
        {
            Console.WriteLine("Vending Candy...");
            Console.WriteLine();
        }

        private static void VendWater()
        {
            Console.WriteLine("Vending Water...");
            Console.WriteLine();
        }

        private static void VendJuice()
        {
            Console.WriteLine("Vending Juice...");
            Console.WriteLine();
        }

        private static void VendGum()
        {
            Console.WriteLine("Vending Gum...");
            Console.WriteLine();
        }

        private static void HandleInvalidSelection()
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }
}
