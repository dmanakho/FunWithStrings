using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class StringReverser
    {
        public string Sentence { get; set; }

        public string Reverse()
        {
            char[] s = Sentence.ToCharArray();
          
           return String.Join("", s.Reverse()) ;
        }
    }
}
