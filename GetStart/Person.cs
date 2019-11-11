using System;
using System.Collections.Generic;
using System.Linq;

namespace GetStart
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{this.FirstName}\t{this.LastName}";

        public double LetterCountSum() => this.GetLetterCounts().Sum();

        public double LetterCountAvg() => this.GetLetterCounts().Average();

        public double LetterCountMax() => this.GetLetterCounts().Max();

        public double LetterCountMin() => this.GetLetterCounts().Min();

        private IEnumerable<int> GetLetterCounts() => from name in this.ToString().Split('\t') select name.Length;

    }
}
