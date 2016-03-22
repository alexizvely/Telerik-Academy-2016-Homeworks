//Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace PrintSequence
{
    using System;

    public class PrintSequence
    {
        public static void Main()
        {
            // formula used here: a(n) = n*(-1)^n
            for (int i = 2; i < 12; i++)
            {
                Console.WriteLine(i*(Math.Pow(-1, i)));
            }
        }
    }
}
