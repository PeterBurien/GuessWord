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
                case DifficultyType.EasyBreezy:
                    Mistakes = 7;
                    MinWordLength = 3;
                    MaxWordLength = 5;
                    break;
                case DifficultyType.Normal:
                    Mistakes = 6;
                    MinWordLength = 4;
                    MaxWordLength = 6;
                    break;
                case DifficultyType.Hard:
                    Mistakes = 5;
                    MinWordLength = 5;
                    MaxWordLength = 7;
                    break;
               
            }
        }
        
    public int Mistakes { get; private set; }    
    public int MinWordLength { get; private set; }    
    public int MaxWordLength { get; private set; }    

    }
    public enum DifficultyType
    {
        EasyBreezy,
        Normal,
        Hard
    }
}
