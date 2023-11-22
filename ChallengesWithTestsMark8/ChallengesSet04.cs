using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var mysum = 0;

            foreach (var i in numbers)
            {
                if (i.GetType() == typeof(int))
                {

                    if ((i % 2) == 0)
                    {
                        mysum += i;
                    }

                    else
                    {
                        mysum -= i;
                    }
                }
            }

            return mysum;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length < str2.Length && str3.Length < str4.Length && str2.Length < str3.Length)
            {
                return str1.Length;
            }

            else if (str2.Length < str3.Length && str3.Length < str4.Length)
            {
                return str2.Length;
            }

            else if (str3.Length < str4.Length)
            {
                return str3.Length;
            }

            else { return str4.Length; }

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
               sideLength1 + sideLength3 > sideLength2 &&
               sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            int counter = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }

                else
                {
                    counter++;
                }
            }

            return count > counter;


        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            int counter = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            else
            {

                foreach (int number in numbers)
                {
                    if (number % 2 == 0 || number == 0)
                    {
                        sum += number;
                        counter++;
                    }                   

                }

                return counter == 0 ? 0 : sum / counter;
            }
        }


        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int sum = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    sum *= i;
                }
            }

            return sum;
        }
    }
}




