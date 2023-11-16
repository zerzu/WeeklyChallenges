using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int counter = 0;
            foreach (var v in vals)
            {
                counter++;
            }
            return counter % 2 == 0;

        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null || !str1.Any() || str2 == null || !str2.Any())
            {
                return 0;
            }

            else
            {
                if (str1.Length > str2.Length)
                {
                    return str2.Length;
                }

                else
                {
                    return str1.Length;
                }
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            int numSum = 0;

            foreach (var n in numbers)
            {
                numSum += n;
            }

            return numSum;

        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            int numSum = 0;

            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    numSum += n;
                }

            }

            return numSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }

            int numSum = 0;

            foreach (var n in numbers)
            {
                numSum += n;

            }

            return numSum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int numSum = 0;

            for (int i = 0; i < number; i++)
            {
                if ((i % 2) != 0)
                {
                    numSum++;
                }
            }

            return numSum;
        }
    }
}
