using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            if (isPrimenumber(7))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is a not prime number.");
            }
            Console.ReadLine();
        }

        private static bool isPrimenumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }

    }
 }
