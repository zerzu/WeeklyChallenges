using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool valBool = false;
            foreach (var b in vals)
            {
                if (b == false)
                {
                    valBool = true;
                    break;
                }

            }

            return valBool;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool valBool = false;
            int sum = 0;

            if (numbers == null || !numbers.Any())
            {
                return valBool;
            }

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            if (sum % 2 != 0)
            {
                valBool = true;
            }

            return valBool;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$");

            return regex.IsMatch(password);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;

            }

            else
            {
                return dividend / divisor;

            }
        }




        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var numList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) != 0)
                {
                    numList.Add(i);
                }
            }

            return numList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
    
}
