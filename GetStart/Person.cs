using System;
using System.Linq;

namespace GetStart
{
    public class Person
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}

        public override string ToString() => $"{this.FirstName}\t{this.LastName}";

        public double LetterCount() {
            var fullName = this.ToString();
            var lc = from name in fullName.Split('\t') select name.Length;
            return lc.Sum();
        }
    }
}
