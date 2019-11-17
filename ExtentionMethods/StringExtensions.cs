using System;
using System.Collections.Generic;
using System.Linq;

namespace MyExtentionMethods
{
    public static class StringExtensions
    {
        public static int WordCount(this String str){
            return str.Split('\t', ',').Count();
        }
    }
}
