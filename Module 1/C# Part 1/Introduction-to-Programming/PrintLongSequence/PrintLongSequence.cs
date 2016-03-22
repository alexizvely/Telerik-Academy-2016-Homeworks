//Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

namespace PrintLongSequence
{
    using System;

    public class PrintLongSequence
    {
        public static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                Console.WriteLine("number {0} is {1}", i - 1, i * (Math.Pow(-1, i)));
            }
        }
    }
}
