using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessWord
{
    public class ConsoleUI
    {

        public char InputLetter()
        {
            
            
            Console.Write("Enter a letter: ");

            while (true)
            {
                var inputLetter = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputLetter) &&
                    inputLetter.Length == 1 &&
                    char.IsLetter(inputLetter[0]))

                    return inputLetter[0];
            }
        }

        public DifficultyType ChooseDifficulty()

        {
            Console.WriteLine("Choose difficulty: \n" +
                              "1 - EasyBreezy\n" +
                              "2 - Normal\n" +
                              "3 - Hard");

            while (true)
            {
                var inputDifficulty = Console.ReadLine();


                switch (inputDifficulty)

                {
                    case "1":

                        return DifficultyType.EasyBreezy;
                    case "2":

                        return DifficultyType.Normal;
                    case "3":

                        return DifficultyType.Hard;
                    default:

                        Console.WriteLine("Incorrect chose. Please select a difficulty.");
                        break;
    
                }
            }
        }
        
        public void ShowUsedLetters(char[] letters)
        {
            Console.WriteLine("Used letters:");
            foreach (char letter in letters)
            {
                Console.Write($"{letter} ");
            }

            Console.WriteLine();
        }
        
        public void ShowGameResult(bool isWin, string word)
        {
            if (isWin)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You loose");
            }
            Console.ResetColor();
            
            Console.WriteLine($"The word was: {word}");
        }

        public void ShowGameState(string maskedWord, int attempts, HashSet<char> guessedLetters)
        {
            Console.WriteLine();
            Console.WriteLine($"Word: {maskedWord}");
            Console.WriteLine($"Attempts left: {attempts}");
            
            ShowUsedLetters(guessedLetters.ToArray());
        }
    }
}


