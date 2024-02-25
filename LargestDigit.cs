using System;
class Program
{
        static void Main(string[] args)
    {
        Console.Write("Enter a number from the segment [10, 99]: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int firstDigit = number / 10;
        int secondDigit = number % 10;
        int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
        Console.WriteLine(maxDigit);
    }
}
