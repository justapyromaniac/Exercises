using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isNumber = false;
            do
            {
                Console.WriteLine("Please input a number: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The number you input is {number}");
                    isNumber = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You may only input numbers");
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("There was no number to read");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("The number you have was either too big or too small");
                }

            } while (!isNumber);
        }
    }
}
