namespace Lab12
{
    public class Dog
    {
        public string Rasa { get; set; }

        public override string ToString()
        {
            return $"[Dog de tipul {Rasa}]";
        }
    }
}