using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsOn_Array
{
    internal class WordReverse
    {
        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] characters = words[i].ToCharArray();
                Array.Reverse(characters);
                words[i] = new string(characters);
            }
            return string.Join(" ", words);
        }
    }
}
