using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 7 == 0 && a % 23 == 0)
        {
        Console.WriteLine("yes");
        }
        else
        {
        Console.WriteLine("no");
        }
    }
}
