using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (word == null || words == null || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == false)
            {
                if (words.Select(w => w).Contains(word))
                {
                    return true;
                }
            }


            if (words.Select(w => w.ToLower()).Contains(word.ToLower()) && ignoreCase == true)
            {
                return true;
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 2)
            {
                if (num == 2)
                {
                    return true;
                }

                return false;
            }

            else if (num % 2 == 0)
            {
                return false;
            }

            else
            {
                for (int i = 3; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;

                    }
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null || str.Length == 0)
            {
                return -1;
            }

            for (int i = str.Length - 1; i >= 0; i--) 
            {
                var currentChar = str[i];

                if (str.LastIndexOf(currentChar) == str.IndexOf(currentChar))
                {
                    return i; 
                }
            }

            return -1;  
        }




        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int count = 1;  
            int maxCount = 1;  

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;  
                }

               
                maxCount = Math.Max(maxCount, count);
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var result = new List<double> { };

            if (elements == null || !elements.Any() || n == 0 || n < 0 || n == null)
            {
                return result.ToArray();
            }

            else
            {
                for (int i = n - 1; i < elements.Count; i += n)
                {
                    result.Add(elements[i]);
                }
            }




            return result.ToArray();
        }

    }
}
