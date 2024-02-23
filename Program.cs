using System;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string answer;
            int result = 0;

            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.WriteLine("Please enter your first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter A for addition, S for subtraction, M for multiplication, or D for division:");
            answer = Console.ReadLine();

            if (answer.ToLower() == "a")
            {
                result = num1 + num2;
            }
            else if (answer.ToLower() == "s")
            {
                result = num1 - num2;
            }
            else if (answer.ToLower() == "m")
            {
                result = num1 * num2;
            }
            else if (answer.ToLower() == "d")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Invalid operation selected!");
                Environment.Exit(0);
            }

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Thank you for using the calculator program!");

            Console.ReadKey();
        }
    }
}
