using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services
{
    public class FizzBuzzService
    {
        /// <summary>
        /// elle renvoie un string 
        /// si la valeur est divisible par 3 ou par 5
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns></returns>
        public string GetFizzBuzz(int valeur)
        {
            string result = string.Empty;
            if (valeur % 3 == 0)
            {
                result += "Fizz";
            }
            if (valeur % 5 == 0)
            {
                result += "Buzz";
            }
            if (string.IsNullOrWhiteSpace(result))
            {

                result += valeur.ToString();
            }
            return result;
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetFizzBuzzPhrase(int max)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i<= max; i++)
            {
               sb.Append(GetFizzBuzz(i));
                if(i != max)
                {
                    sb.Append(" ");
                }
             }
            return sb.ToString();
        }
    }
}
