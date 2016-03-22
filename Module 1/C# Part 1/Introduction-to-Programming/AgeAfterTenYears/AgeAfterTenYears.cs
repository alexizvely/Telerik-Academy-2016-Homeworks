//Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace AgeAfterTenYears
{
    using System;
    using System.Globalization;

    public class AgeAfterTenYears
    {
        public static void Main()
        {
            DateTime currentDate = DateTime.Now;
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;

            bool isCorrectFormat = false;

            int yearBirth;
            Console.Write("Please enter year of birth: ");
            isCorrectFormat = Int32.TryParse(Console.ReadLine(), out yearBirth);

            while (!isCorrectFormat)
            {
                Console.Write("Please enter year of birth as a number: ");
                isCorrectFormat = Int32.TryParse(Console.ReadLine(), out yearBirth);
            }

            while (!(1900 < yearBirth || yearBirth >= currentDate.Year))
            {
                Console.Write("Please enter year of birth between 1900 and the current year: ");
                isCorrectFormat = Int32.TryParse(Console.ReadLine(), out yearBirth);
                while (!isCorrectFormat)
                {
                    Console.Write("Please enter year of birth as a number: ");
                    isCorrectFormat = Int32.TryParse(Console.ReadLine(), out yearBirth);
                }
            }

            int monthBirth;
            Console.Write("Please enter month of birth: ");
            isCorrectFormat = Int32.TryParse(Console.ReadLine(), out monthBirth);

            while (!isCorrectFormat)
            {
                Console.Write("Please enter month of birth as a number: ");
                isCorrectFormat = Int32.TryParse(Console.ReadLine(), out monthBirth);
            }

            while (!(0 < monthBirth && monthBirth < 12))
            {
                Console.Write("Please enter month of birth between 1 and the 12: ");
                isCorrectFormat = Int32.TryParse(Console.ReadLine(), out monthBirth);
                while (!isCorrectFormat)
                {
                    Console.Write("Please enter month of birth as a number: ");
                    isCorrectFormat = Int32.TryParse(Console.ReadLine(), out monthBirth);
                }
            }

            int dayBirth;
            Console.Write("Please enter day of birth: ");
            isCorrectFormat = Int32.TryParse(Console.ReadLine(), out dayBirth);

            while (!isCorrectFormat)
            {
                Console.Write("Please enter day of birth as a number: ");
                isCorrectFormat = Int32.TryParse(Console.ReadLine(), out dayBirth);
            }

            while (!(0 < dayBirth && dayBirth <= DateTime.DaysInMonth(yearBirth, monthBirth)))
            {
                Console.Write("Please enter day of birth that is within the month of birth: ");
                isCorrectFormat = Int32.TryParse(Console.ReadLine(), out dayBirth);
                while (!isCorrectFormat)
                {
                    Console.Write("Please enter day of birth as a number: ");
                    isCorrectFormat = Int32.TryParse(Console.ReadLine(), out dayBirth);
                }
            }

            if ((currentDate.Month < monthBirth) || ((currentDate.Month == monthBirth) && (currentDate.Day < dayBirth)))
            {

                yearBirth += 1;
            }

            int age = currentDate.Year - yearBirth + 10; 
            Console.WriteLine("You are {0} years old. You will be {1} years old at this date after 10 years.", age - 10, age);
        }
    }
}
