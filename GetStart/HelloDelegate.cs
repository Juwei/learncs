using System;
using System.Collections.Generic;
using System.Text;

namespace GetStart
{
    public class HelloDelegate
    {
        public static string ProcessAndDispalyDoubleNumber(Func<double, double> func, double value)
        {
            double res = func(value);
            string ops = func.Method.Name;
            return $"Ops is {ops}, Value is {value}, result of operation is {res}";
        }
    }
}
