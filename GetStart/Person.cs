using System;
using System.Collections.Generic;
using System.Linq;

namespace GetStart
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{this.FirstName} {this.LastName}";

        public Action<string> Greet = (name) => {
            Console.WriteLine(String.Format("Hello, {0}.", name));
        }; 

        public double LetterCountSum() => this.GetLetterCounts().Sum();

        public double LetterCountAvg() => this.GetLetterCounts().Average();

        public double LetterCountMax() => this.GetLetterCounts().Max();

        public double LetterCountMin() => this.GetLetterCounts().Min();

        private IEnumerable<int> GetLetterCounts() => from name in this.ToString().Split(' ') select name.Length;

    }
}
