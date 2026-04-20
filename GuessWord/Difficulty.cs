namespace GuessWord
{
    public class Difficulty
    {
        private readonly DifficultyType _type;

        public Difficulty(DifficultyType type)
        {
            _type = type;
            
            switch(type)
            {
                case DifficultyType.Easy:
                    Attempts = 10;
                    MinWordLength = 3;
                    MaxWordLength = 5;
                    break;
                case DifficultyType.Normal:
                    Attempts = 8;
                    MinWordLength = 4;
                    MaxWordLength = 6;
                    break;
                case DifficultyType.Hard:
                    Attempts = 6;
                    MinWordLength = 5;
                    MaxWordLength = 7;
                    break;
               
            }
        }
        
    }
   public class Difficulty
{
    public string Name { get; private set; }
    public int Attempts { get; private set; }    
    public int MaxAttempts { get; private set; }
    public int MinWordLength { get; private set; }
    public int MaxWordLength { get; private set; }

    public Difficulty(string name, int maxAttempts, int minWordLength, int maxWordLength)
    {
        Name = name;
        MaxAttempts = maxAttempts;
        MinWordLength = minWordLength;
        MaxWordLength = maxWordLength;
    }
}
}
