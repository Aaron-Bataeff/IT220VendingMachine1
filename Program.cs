// a small console program to simulate a free vending machine. 
// When started a user should be presented with a list of selections. 
// Then the user should prompted to input a number to make a selection. 
// Once the have made a selection the console should display 
// a message indicating vending of whatever selection they made.


namespace VendingMachine1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Free Vending Machine!");
            Console.WriteLine();
            Console.WriteLine("Please make a selection from the following options:");
            string[] items = { "1. Soda", "2. Chips", "3. Candy", "4. Water", "5. Juice" };
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.Write("Enter the number of your selection:    ");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You have selected " + input);

            // Call the extracted function that contains the switch
            ProcessSelection(input);

            Console.WriteLine("Thank you for using the Free Vending Machine!");
        }

        // Extracted switch logic into its own function for clarity and reuse
        private static void ProcessSelection(string input)
        {
            switch (input?.Trim())
            {
                case "1":
                    Console.WriteLine("Vending Soda...");
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("Vending Chips...");
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Vending Candy...");
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("Vending Water...");
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("Vending Juice...");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}
