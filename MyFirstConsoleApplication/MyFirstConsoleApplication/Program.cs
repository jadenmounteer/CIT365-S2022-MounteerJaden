using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            GetUserNameAndLocation();

            DateTime today = DateTime.Today;
            ChristmasCountdown(today);

            GlazerApp.RunExample();

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }

        private static void GetUserNameAndLocation()
        {
            var person = new Person();

            Console.WriteLine("What is your name?: ");
            person.name = Console.ReadLine();

            Console.WriteLine($"Hi {person.name}! Where are you from? ");
            person.location = Console.ReadLine();

            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

        }

        private static void ChristmasCountdown(DateTime today)
        {
            Console.WriteLine($"Today's date is: {today.ToString()}");
            

            DateTime christmas = DateTime.Parse($"12/25/{today.Year} 12:00:01 AM");

            TimeSpan daysUntilChristmas = today - christmas;

            Console.WriteLine($"There are {Convert.ToInt32(daysUntilChristmas.TotalDays) * -1} days until Christmas!");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();



        }


    }
}
