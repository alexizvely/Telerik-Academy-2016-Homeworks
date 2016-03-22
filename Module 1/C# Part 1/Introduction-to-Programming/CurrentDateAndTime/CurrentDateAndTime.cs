//Current Date and Time

//Create a console application that prints the current date and time.

namespace CurrentDateAndTime
{
    using System;
    using System.Globalization;

    public class CurrentDateAndTime
    {
        public static void Main()
        {
            // more info at: https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.invariantculture(v=vs.110).aspx
            DateTime currentDate = DateTime.Now;
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            Console.WriteLine(currentDate.ToString("r", invariantCulture));
        }
    }
}
