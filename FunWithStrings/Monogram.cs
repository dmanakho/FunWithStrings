using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Monogram
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Monogram(string firstName, string lastName,  string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        public string GetMonogram()
        {
            string m = FirstName.ToLower()[0].ToString() + LastName.ToUpper()[0].ToString() + MiddleName.ToLower()[0].ToString();
           
            return m;
        }
    }
}
