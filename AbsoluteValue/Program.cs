/*
 * Purpose: Demonstrate creating and calling methods
 * Input: number
 * Output: absoluteValue
 * Author: Mihiri Kamiss
 * Date: Oct 12, 2022
 */

namespace AbsoluteValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxValue = -1;
            Setup();
            int number = GetAbsoluteValue();
            Console.WriteLine(number);

            number = GetAbsoluteValue(MaxValue);
            Console.WriteLine(number);

            Console.ReadLine();
        }// end of Main

        //next method goes here
        static void Setup()
        {
            Console.Title = "Get Absolute Value";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
        }//end of Setup
        
        static int GetSafeInt(string prompt)
        {
            bool isValid = false;
            int number;
            do
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input ... please try again.");
                    number = 0;
                }
            } while (!isValid);
            return number;
        }//end of GetSafeInt

        static int GetAbsoluteValue()
        {
            int number = GetSafeInt("Enter an integer value: ");
            int absolute = Math.Abs(number);
            return absolute;
        }// end of GetAbsoluteValue

        static int GetSafeInt(string prompt, int maxValue)
        {
            bool isValid = false;
            int number;
            do
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    if(number == maxValue)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine($"The number {number} exceeds {maxValue}...please try again.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input ... please try again.");
                    number = 0;
                }
            } while (!isValid);
            return number;
        }//end of GetSafeInt

        static int GetAbsoluteValue(int maxValue)
        {
            int number = GetSafeInt("Enter an integer value: ", maxValue);
            int absolute = Math.Abs(number);
            return absolute;
        }// end of GetAbsoluteValue

    }
}