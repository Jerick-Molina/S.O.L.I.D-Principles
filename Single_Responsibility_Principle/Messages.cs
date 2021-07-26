using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle
{
    public  class Messages
    {

        public  static void GameStart()
        {     
            SpacesGenerator.SpacingGenerator("Welcome to hangman created by Jerick Molina", 2);
        }
       public static bool GameOver(bool isGameOver)
        {
            if (isGameOver)
            {
                Console.Clear();
                Console.WriteLine("GAME OVER!");
                return true;
            }
            return false;
        }
        public static void CurrentWordState(string word, List<char> correctResponses)
        {
            foreach (var _letter in word)
            {
                var doesLetterExist = false;
                foreach (var _correctLetter in correctResponses)
                {
                    if (_letter == _correctLetter)
                    {
                        doesLetterExist = true;
                        Console.Write($"{_correctLetter} ");
                        break;
                    }
                }

                if (!doesLetterExist)
                {
                    Console.Write("_ ");
                }
            }
        }
        public static void CurrectWordValidation(string word,List<char> correctResponses)
        {
            string currentWordState = "";     
            for (var i = 0; i < word.Length; i++)
            {
                char current;
                for (var j = i; j < correctResponses.Count; j++)
                {
                    
                    if (word[i] == correctResponses[j] &&  correctResponses[i] != correctResponses[j])
                    {
                        current = correctResponses[i];
                        correctResponses[i] = correctResponses[j];
                        correctResponses[j] = current;
                    }
                }
            }
            foreach (var sortedLetter in correctResponses)
            {
                currentWordState += sortedLetter;
            }
            if (currentWordState == word)
            {
                Console.Clear();
                Console.WriteLine($"You guessed it: {word}!");
            }
            else
            {
                CurrentWordState(word, correctResponses);
            }

        }
       
    }
}
