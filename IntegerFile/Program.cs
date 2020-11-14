using System;

namespace IntegerFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrimeFactors pm = new PrimeFactors();
                Console.WriteLine("Please enter your file path");
                pm.PrintPrimeFactors(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
         }

    } 
}
