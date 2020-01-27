using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Starter
    {
        HashSet<char> hiddenChars = new HashSet<char>();

        public void HideCharacters(string word)
        {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++) // 2 chosen just to test
            {
                int index = rnd.Next(0, word.Length - 1);
                hiddenChars.Add(word[index]);
            }
        }

        public void CheckCharExists(char character)
        {
            if (hiddenChars.Contains(character))
            {
                hiddenChars.Remove(character);
            }
        }
    }
}
