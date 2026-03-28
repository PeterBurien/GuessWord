using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessWord
{
    public class WordBank
    {
        private List<string> _allWords = new List<string>()
        
        {
            "dog", "cup", "winter", "ball", "money", "bus", "statement", "flower", "book",
            "scandal", "purse", "pillow", "laptop", "lightning", "shirt", "serenity", 
            "punishment", "pool", "wedding", "husband"

        };
        
        private Random _random = new Random();

        public Word Generate(Difficulty difficulty)
        {
            var suitable = new List<string>();

            foreach (var word in _allWords)
            {
                if (word.Length >= difficulty.MinWordLength && word.Length <= difficulty.MaxWordLength)
                    suitable.Add(word);
            }

            if (suitable.Count == 0)
                return new Word(_allWords[_random.Next(_allWords.Count)]);

            return new Word(suitable[_random.Next(suitable.Count)]);
        }
    }
}