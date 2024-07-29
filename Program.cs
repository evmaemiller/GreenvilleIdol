using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        while (true)
        {
            DisplayMenu();

            Console.Write("\nPlease Enter the following number below from the following menu:\n");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateRevenueYearOverYear();
                    break;
                case "2":
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }

    static void CalculateRevenueYearOverYear()
    {
        int lastYearContestants = GetValidNumber("Please enter the number of contestants last year:");
        int currentYearContestants = GetValidNumber("Please enter the number of contestants this year:");

        if (currentYearContestants > 2 * lastYearContestants)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (currentYearContestants > lastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
    }
    static int GetValidNumber(string prompt)
    {
        int number;
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= 0 && number <= 30)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid number. Must be between 0 and 30. Please try again.");
            }
        }
    }
}
