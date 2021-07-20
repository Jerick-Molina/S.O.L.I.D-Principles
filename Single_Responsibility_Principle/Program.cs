using System;
using System.Collections.Generic;
using System.IO;
namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Steps for Hangman:
             * 1. Read All data from Txt file /
             * 2. Put it in a list /
             * 3. Pick a random word from the List /
             * 4. Hide Word and Show how many letters there is. /
             * 5. Let user pick a word 
             * 6. User only gets a (set) chances
             * 7. User being able to play again.
             * 
             * _ _ _ _ _ _
             * Chances: 3
             * Letters Picked: 
             */

            bool isGameRunning = true;
            var textFile = File.ReadAllText(@"C:\Users\Jerick\Desktop\Project Templates\C#\SOLID Coding\1.S\Single_Responsibility_Principle\Single_Responsibility_Principle\HangManWords.txt");

            string[] words = textFile.Split(  Environment.NewLine );
           

            int chances = 3;
            List<char> guessedLetters = new List<char>();

            var random_Word = words [new Random().Next(words.Length)];

            Console.WriteLine(random_Word);
            for(var i = 0; i < random_Word.Length; i++)
            {
                Console.Write("_ ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("# Of Letters: " + random_Word.Length);


            // Start User Response

            while (isGameRunning)
            {
               
                Console.WriteLine();
                Console.WriteLine($"Chances Left: {chances}");
                Console.WriteLine();
            

                var response = Console.ReadLine();

                didAnswer = true;
                
                List<Char> correctResponse = new List<char>();

                if (char.IsLetter(char.Parse(response)))
                {
                   
                    var response_letter = Char.Parse(response);
                    guessedLetters.Add(response_letter);


                    foreach (var letter in random_Word)
                    {

                        bool doesLetterExist = false;
                        foreach (var usedLetters in guessedLetters)
                        {
                            if (usedLetters == letter)
                            {
                                correctResponse.Add(letter);
                                doesLetterExist = true;
                                break;
                            }
                        }
                        if (doesLetterExist)
                        {
                            Console.Write($"{letter} ");
                        }
                        else
                        {
                            Console.Write($"_ ");
                        }
                      
                    }

                    Console.WriteLine("Choose a Letter");

                    
                    var word = "";
                    for(var i = 0; i < random_Word.Length; i++)
                    {
                        for (var j = 0; j < correctResponse.Count; j++)
                        {
                            if(random_Word[i] == correctResponse[j])
                            {
                               var  current = correctResponse[j];
                                correctResponse[j] = correctResponse[i];
                                correctResponse[i] = current;
                            }              
                        }
                    }

                    foreach(var sortedLetter in correctResponse)
                    {
                        word += sortedLetter;
                    }
                    if(word == random_Word)
                    {
                        Console.Clear();
                        Console.WriteLine($"You guessed it: {word}!");
                        isGameRunning = false;
                    }

                }

              

                Console.WriteLine();
             


            }
        
           

        }
    }
}
