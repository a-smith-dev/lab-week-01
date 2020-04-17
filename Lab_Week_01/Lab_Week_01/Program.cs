using System;

namespace Lab_Week_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length, width, area, perimeter;
            string repeater;
            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");
            do
            {
                Console.Write("\nEnter Length: ");
                length = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = Convert.ToDecimal(Console.ReadLine());
                area = length * width;
                perimeter = (length + width) * 2;
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.Write("Would you like to continue (y/n)? ");
                repeater = Console.ReadLine();
            } while (repeater.ToUpper() == "Y");
            Console.WriteLine("Thank you for using the Grand Circus' Room Detail Generator! Have a great day!");
        }
    }
}
