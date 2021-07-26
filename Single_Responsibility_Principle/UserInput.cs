using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle
{
    public class UserInput: GameLogic
    {


        public  char InputValidation(string input)
        {
            char parsed;
            try
            {
               parsed = char.Parse(input);
               
            }
            catch
            {
                Console.WriteLine("Input was not valid. Enter a letter");
                return ' ';
            }

            return parsed;
        }


      
    }
}
