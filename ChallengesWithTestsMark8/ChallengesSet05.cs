using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            // Calculate the remainder when startNumber is divided by n
            int remainder = startNumber % n;

            // If remainder is 0, startNumber is already divisible by n, return it
            // Otherwise, return the next multiple of n
            return (n == 0) ? startNumber : startNumber + Math.Abs(n - remainder);
        }


        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business b in businesses)
            {
                if (b.TotalRevenue == 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)        
        {
            if ((numbers == null) || (!numbers.Any()))
            {
                return false;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
                    
                   
                    
            
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            #region myCode
            //    if (words == null || words.Length == 0)
            //    {
            //        return "";
            //    }
            //    else
            //    {
            //        string phrase = "";

            //        foreach (string word in words)
            //        {
            //            if (!string.IsNullOrEmpty(word) && word != "" && word != " ")
            //            {
            //                var wordTrim = word.Trim();
            //                phrase += " " + wordTrim;
            //                phrase = phrase.Trim();
            //            }
            //        }
            //        if (string.IsNullOrEmpty(phrase))
            //        {
            //            return phrase;
            //        }
            //        else
            //        {
            //            return phrase + ".";
            //        }
            //    }
            //}
            #endregion
            #region chatGPT

            if (words == null || words.Length == 0)
            {
                return "";
            }

            string phrase = string.Join(" ", words
                .Where(word => !string.IsNullOrWhiteSpace(word))
                .Select(word => word.Trim()));

            return string.IsNullOrEmpty(phrase) ? phrase : phrase + ".";
        }
        #endregion

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return Array.Empty<double>();
            }
            return elements.Where((element, index) => (index + 1) % 4 == 0).ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (var j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
               
            }
            return false;
        }
    }
}
