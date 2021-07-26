using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle
{
    public class GameLogic
    {
        public static bool DuplicateValidation(char letter, List<char> usedLetters)
        {
            bool doesLetterExist = false;
            foreach (var _letter in usedLetters)
            {
                if (_letter == letter)
                {
                    doesLetterExist = true;

                    break;
                }
            }
            if (!doesLetterExist)
            {
                usedLetters.Add(letter);
                return false;
            }
            else
            {
                Console.WriteLine("You've already choosed this letter");
            }

            return true;
        }

        public static bool WordValidation(char letter, string word, List<char> usedLetters, List<char> correctLetters)
        {
            if (!DuplicateValidation(letter, usedLetters))
            {
                var isLetterCorrect = false;
                foreach (var _letter in word)
                {
                    if (_letter == letter)
                    {
                        correctLetters.Add(letter);
                        isLetterCorrect = true;
                        break;
                    }       
                }

                if (!isLetterCorrect)
                {
                    return false;
                }

                return true;
            }

            return true;
        }

        public static int playerChances(bool wordValidation, int lives)
        {
            if (!wordValidation)
            {
                lives = lives -1;

                if(lives == 0)
                {
                    Console.Clear();
                    Console.WriteLine("GAME OVER!");
                    return lives;
                }
             
            }
            return lives;
        }

        public static bool isGameOver(int lives)
        {
            if (lives == 0)
            {
          
                return true;
            }
            return false;
        }
    }
}
