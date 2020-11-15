using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerFile
{
    public class PrimeFactors
    {
        /// <summary>
        /// Calling the file reader and then sending them to the read functions. 
        /// </summary>
        /// <param name="filePath"></param>
        public void PrintPrimeFactors(string filePath)
        {
            FileReader fl = new FileReader();
            PrimeFactorsRead(fl.FileRead(filePath));
        }

        /// <summary>
        /// Read the numbers that were given from the file and make sure they are above 0 and then getting the prime factors of the number
        /// </summary>
        /// <param name="numbers"></param>
        public  void PrimeFactorsRead(LinkedList<int> numbers)
        {
            foreach(int number in numbers)
            {
                if(number > 1)
                {
                 Console.WriteLine(number + " has these prime numbers " + PrimeFactorsOut(number));
                }
                else
                {
                    Console.WriteLine(number + " has no prime numbers");
                }
            }
        }

        /// <summary>
        /// getting the prime factors of the number
        /// 
        /// start with the orignal number then go down from there. dividing by the lowest factor until the final number is a factor itself
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public  StringBuilder PrimeFactorsOut(int number)
        {
            LinkedList<int> factorsList = new LinkedList<int>();
            for (int b = 2; b < number;)
            {
                if (number % b == 0)
                {
                    number = number / b;
                    factorsList.AddLast(b);
                    b = 2;
                }
                else
                {
                    b++;
                }

                if(b == number)
                {
                    factorsList.AddLast(number);
                }
            }
            return PrimeFactorsOut(factorsList);
        }


        /// <summary>
        /// getting the list of prime factors and then printing them out comma delimited.
        /// </summary>
        /// <param name="FactorsList"></param>
        /// <returns></returns>
        public  StringBuilder PrimeFactorsOut(LinkedList<int> FactorsList)
        {
            StringBuilder stringBuilder = new StringBuilder();
            LinkedListNode<int> header = FactorsList.First;

            while(header.Next != null)
            {
                stringBuilder.Append(header.Value + ",");
                header = header.Next;
            }
            stringBuilder.Append(header.Value);

            return stringBuilder;
        }

    }
}
