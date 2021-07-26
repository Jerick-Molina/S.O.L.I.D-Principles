using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle
{
   public  class SpacesGenerator
    {
        public static void SpacingGenerator(int spaces)
        {
            for(var i = 0; i <spaces; i++)
            {
                Console.WriteLine();
            }
        }

        public static void SpacingGenerator(string message, int spaces)
        {
            Console.WriteLine(message);

            for (var i = 0; i < spaces; i++)
            {
                Console.WriteLine();
            }
        }
        public static void SpacingGenerator(string message, int spacesBefore, int spacesAfter)
        {
            for (var i = 0; i < spacesBefore; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(message);
            for (var i = 0; i < spacesAfter; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
