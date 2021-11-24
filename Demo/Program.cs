using Calculations;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Calculator.Calculate("1.5 + .5"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
