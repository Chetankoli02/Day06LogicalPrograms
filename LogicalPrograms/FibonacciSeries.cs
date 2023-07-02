using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_
{
    internal class FibonacciSeries
    {
        public void Main(string[] args)
        {
            int count;

            Console.WriteLine("Enter the number of terms to generate in the Fibonacci series:");
            while (!int.TryParse(Console.ReadLine(), out count) || count < 1)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer:");
            }

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < count; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            static int Fibonacci(int n)
            {
                if (n <= 1)
                    return n;

                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        }
    }
}
