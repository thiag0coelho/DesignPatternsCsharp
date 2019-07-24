using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = new Sentence("Hello World");
            sentence[1].Capitalize = true;
            var phrase = sentence.ToString();
            Console.WriteLine("Hello World!");
        }
    }

    public class Sentence
    {
        private List<WordToken> Phrase = new List<WordToken>();

        public Sentence(string plainText)
        {
            foreach (var text in plainText.Split(" "))
            {
                Phrase.Add(new WordToken(text));
            }
        }

        public WordToken this[int index]
        {
            get
            {
                return Phrase[index];
            }
        }

        public override string ToString()
        {
            return String.Join(" ", Phrase);
        }

        public class WordToken
        {
            public bool Capitalize;

            private string Word;

            public WordToken(string word)
            {
                this.Word = word;
            }

            public override string ToString()
            {
                return Capitalize ? Word.ToUpper() : Word;
            }
        }
    }
}
