using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Word
    {
        public string Name { get; }
        public string Meaning { get; set; }

        public Word(string name, string meaning)
        {
            this.Name = name;
            this.Meaning = meaning;
        }
    }

    public class WordDictionary
    {
        // Words sourced from dictionary.com
        private static ArrayList Words = new ArrayList
        {
            new Word("corybantic", "frenzied; agitated; unrestrained."),
            new Word("foison", "abundance; plenty.")
        };

        // Select random word from word repository
        public static Word SelectRandomWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, Words.Count - 1);
            return (Word)Words[index];
        }
    }
}
