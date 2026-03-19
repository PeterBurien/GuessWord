using System;
using System.Linq;

namespace GuessWord
{
    public class WordBank
    {
        private Word[] _words;

        public WordBank()
        {
            _words = new[]
            {
                new Word("pet"),
                new Word("home"),
                new Word("dog"),
                new Word("cat"),
                new Word("cock"),
                new Word("rock"),
                new Word("hogwarts"),
                new Word("magic"),
                new Word("wond"),
                new Word("giant"),
                new Word("leviosa"),
                new Word("secret"),

            };
        }

        public Word Generate(Difficulty difficulty)
        {
            var words = _words.Where(word => word.Length >= difficulty.MinWordLength &&
                                           word.Length <= difficulty.MaxWordLength).ToArray();
            var random = new Random();
            int index = random.Next(words.Length);
            return words[index];
        }
    }
}