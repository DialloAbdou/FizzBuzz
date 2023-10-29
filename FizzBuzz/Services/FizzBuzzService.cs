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
        public string getFizzBuzz(int valeur)
        {
            if (valeur % 3 == 0 && valeur % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (valeur % 3 == 0)
            {
                return "Fizz";
            }
            else if (valeur % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return valeur.ToString();
            }

        }
    }
}
