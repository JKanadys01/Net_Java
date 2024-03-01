using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0_FizzBuzz
{
    internal class FizzBuzz
    {
        private int upperLimit;
        public FizzBuzz(int x) { upperLimit = x; }
        public void Display()
        {
            for (int i = 0; i <= upperLimit; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
    }
}
