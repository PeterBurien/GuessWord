using System;
using System.Linq;

namespace GuessWord
{
    public class Word
    {
        private readonly string _value;

        public Word(string value)
        {
            _value = value;
        }

        public int Length => _value.Length;

        public bool Contains(char letter)
        {
            return _value.Contains(letter.ToString());
        }
        
        public string GetMask(char[] guessedletters)
        

        {
            string result = string.Empty;

            foreach (char character in _value)
            {
                if (guessedletters.Contains(character) )
                    result += character;
                else
                    result += "*";
            }

            return result;
        }
        
    }

}