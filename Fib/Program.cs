using System;

namespace FibonacciSequence
{
    class Program
    {
        static int ReadInt(
            string prompt,
            int min = int.MinValue,
            int max = int.MaxValue
            )
        {
            int v;
            bool validInput;

            do
            {
                Console.WriteLine(prompt + " between " + min + " and " + max);
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out v);
            } while (!validInput);

            return v;
        }
        static int Fibonacci(int position)
        {
            int num;

            if (position > 2) // First 2 values of the sequence is 1
            {
                num = Fibonacci(position - 1) + Fibonacci(position - 2);
            }
            else
            {
                num = 1;
            }

            return num;
        }
        static void Main(string[] args)
        {
            const int MIN_VALUE = 1;
            int position;
            int value;

            position = ReadInt("Enter desired position:", min: MIN_VALUE);

            value = Fibonacci(position);

            Console.WriteLine("The value is " + value);
        }
    }
}
