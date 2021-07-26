using System;
using System.Collections.Generic;
using System.IO;

namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {

            Messages.GameStart();

            var isGameRunning = true;
            
            int chances = 3;

            List<char> guessedLetters = new List<char>();
            List<char> correctResponses = new List<char>();
            var random_Word = new WordGenerator().WordSelector();
       
            SpacesGenerator.SpacingGenerator(1);

            while (isGameRunning)
            {
                Messages.CurrectWordValidation(random_Word, correctResponses);

                SpacesGenerator.SpacingGenerator($"Chances Left: {chances}", 2x, 1);


                SpacesGenerator.SpacingGenerator("# Of Letters: " + random_Word.Length, 1);


                SpacesGenerator.SpacingGenerator("Choose a Letter:", 1, 1);

              

                var response = Console.ReadLine();

                SpacesGenerator.SpacingGenerator(1);

                var response_letter = new UserInput().InputValidation(response);


                chances = GameLogic.playerChances(GameLogic.WordValidation(response_letter, random_Word, guessedLetters,correctResponses),chances);

               

                if (Messages.GameOver(GameLogic.isGameOver(chances)))
                {
                    break;
                }

                Console.Clear();
             }
        }
    }
}
