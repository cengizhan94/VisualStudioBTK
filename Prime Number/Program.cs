using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (isPrimenumber(7))
            {
                Console.WriteLine("Asal Sayıdır.");
            }
            else
            {
                Console.WriteLine("Asal Sayı değildir.");
            }
            Console.ReadLine();
        }
        private static bool isPrimenumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;      
                }
                
            }
            return result;
        }
    }
}
