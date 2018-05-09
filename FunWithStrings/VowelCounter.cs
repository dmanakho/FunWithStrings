using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class VowelCounter
    {
        public string Sentence { get; set; }

        private char[] vowels = { 'a', 'o', 'i', 'u', 'e', 'y' };
        public int GetVowelNo()
        {
            var totalVowels = 0;
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (vowels.Contains(Sentence[i]))
                {
                    totalVowels++;
                }
            }
            return totalVowels;
        }
    }
}
