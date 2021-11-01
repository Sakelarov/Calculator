using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTerminated = false;

            Console.WriteLine("Hi!");

            while (!isTerminated)
            {
                Console.WriteLine("Input the first number:");
                double firstNum = double.Parse(Console.ReadLine());

                Console.WriteLine("Input the operation type:");
                string operation = Console.ReadLine();

                Console.WriteLine("Input the second number:");
                double secondNum = double.Parse(Console.ReadLine());


                if (operation == "+")
                {
                    Console.WriteLine("Result: " + (firstNum + secondNum));
                    isTerminated = true;
                }
                else if (operation == "-")
                {
                    Console.WriteLine("Result: " + (firstNum - secondNum));
                    isTerminated = true;
                }
                else if (operation == "*")
                {
                    Console.WriteLine("Result: " + firstNum * secondNum);
                    isTerminated = true;
                }
                else if (operation == "/")
                {
                    Console.WriteLine("Result: " + firstNum / secondNum);
                    isTerminated = true;
                }
                else
                {
                    Console.WriteLine("Unsupported operation type. Try again:");
                }
            }
        }
    }
}
