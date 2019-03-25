using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CreateFizzBuzz(int number)
        {
            var result = "";
            if (number % 3 == 0)
            {
                result += "Fuzz";
            }

            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            if (String.IsNullOrWhiteSpace(result))
            {
                result = number.ToString();
            }

            return result;
        }
    }
}