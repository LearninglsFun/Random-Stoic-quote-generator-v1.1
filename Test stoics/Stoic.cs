﻿namespace Random_Stoic_quotes_generator
{
    public class Stoic
    {
        public string Name { get; set; }
        public List<string> Quotes { get; set; }

        public Stoic(string name, List<string> quotes)
        {
            Name = name;
            Quotes = quotes;
        }

        public Stoic(string name, string filePath)
        {
            Name = name;

            // Combine the base directory with the relative path to ensure correct file access
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", filePath);
            Quotes = new List<string>(File.ReadAllLines(fullPath));

        }

        public string GetRandomQuote()
        {
            Random rand = new Random();
            int index = rand.Next(Quotes.Count);
            return $"{Quotes[index]} - {Name}";
        }
    }
}