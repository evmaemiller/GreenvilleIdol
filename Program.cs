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
                    Console.ReadKey();
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
        Console.WriteLine("\nPlease enter the number of contestants last year:");
        int lastYearContestants = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the number of contestants this year:");
        int currentYearContestants = Convert.ToInt32(Console.ReadLine());

        int revenuePerContestant = 25; 
        int revenueLastYear = lastYearContestants * revenuePerContestant;
        int revenueCurrentYear = currentYearContestants * revenuePerContestant;

        Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants");
        Console.WriteLine($"Revenue expected last year was ${revenueLastYear}");
        Console.WriteLine($"Revenue expected this year is ${revenueCurrentYear}");

        if (currentYearContestants > lastYearContestants)
        {
        Console.WriteLine($"It is \u001b[1mtrue\u001b[0m that this year's competition is bigger than last year's.");
         }
        else
        {
            Console.WriteLine($"This year's competition is not bigger than last year's.");
        }

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
    }
}
