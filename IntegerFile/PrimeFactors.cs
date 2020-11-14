using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerFile
{
    public class PrimeFactors
    {

        public void PrintPrimeFactors(string filePath)
        {
            FileReader fl = new FileReader();
            PrimeFactorsRead(fl.FileRead(filePath));
        }


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
