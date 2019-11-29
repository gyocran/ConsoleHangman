using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "word";
            var arr = word.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                var ch = arr[i];
                if (ch == 'o')
                    arr[i] = '_';
                //Console.Write(arr[i] + " ");
            }
            Console.Write(arr.ToString());
            Console.ReadLine();
        }
    }
}
