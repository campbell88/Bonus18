using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class ValidateConsoleInput
    {
        public static int GetValidInteger()
        {
            int input;


            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("The input is not an integer! Please enter an integer! ");
            }

            return input;
        }
    }
}
