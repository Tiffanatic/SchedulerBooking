using System;
using System.Linq;

namespace CouncelingScheduler.domain.domain
{
    public class Name
    {
        public string Navn { get; private set; }

        public Name(string nameString)
        {
            if (!nameString.Any(char.IsDigit))
            {
                this.Navn = nameString;
            }
            else
            {
                throw new Exception(nameString + "is not a valid name");
            }
        }
    }
}