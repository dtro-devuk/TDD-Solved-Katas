using System;

namespace TDD.Katas.CSharp.FizzBuzzKata
{
    public class FizzBuzz
    {
        //1st test implmentation
        //public static string PrintFizzBuzz(int number)
        //{
        //    throw new NotImplementedException();
        //}

        public static string PrintFizzBuzz(int number)
        {
            var returnValue = string.Empty;

            if (!VerifyInput(number))
            {
                return returnValue;
            }

            if (number == 3) return "FIZZ";

            returnValue = number.ToString();
            return returnValue;
        }

        #region Private Helper Methods

        private static bool VerifyInput(int number)
        {
            if (number < 1)
            {
                return false;
            }
            return true;
        }

        #endregion

    }

    
}
