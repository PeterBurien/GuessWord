using System;
using System.Linq;
using System.Collections.Generic;
using GuessWord;

namespace GameWord
{
    public class Game
    {
        public Difficulty Difficulty { get; private set; }
        public Word Word { get; private set; }
        public int AttemptsLeft { get; private set; }
        private HashSet<char> _guessedLetters;

        public Game(Difficulty difficulty, Word word)
        {
            Difficulty = difficulty;
            Word = word;
            AttemptsLeft = difficulty.Attempts;
            _guessedLetters = new HashSet<char>();
        }

        public HashSet<char> GuessedLetters => _guessedLetters;
        public string Mask => Word.GetMask(_guessedLetters.ToArray());
        
        public bool IsWon => !Mask.Contains("*");
        public bool IsLost => AttemptsLeft <= 0;

    }
}