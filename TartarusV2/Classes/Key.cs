namespace TartarusV2.Classes
{
    public class Key 
    {
        public int Number { get; set; }
        public string CurrentlySet { get; set; }

        public Key(int number)
        {
            Number = number;
            CurrentlySet = String.Empty;
        }
    }
}
