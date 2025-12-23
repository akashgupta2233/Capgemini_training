using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n=== Main Menu ===");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Show Current Date");
            Console.WriteLine("3. Perform Addition");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello, welcome to the menu system!");
                    break;

                case 2:
                    Console.WriteLine($"Today's date is: {DateTime.Now.ToShortDateString()}");
                    break;

                case 3:
                    Console.Write("Enter first number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Sum = {a + b}");
                    break;

                case 4:
                    Console.WriteLine("Exiting... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        } while (choice != 4); 
    }
}
