using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public static class DateModifier
    {
        public static int CalculateDateDifference(string date1, string date2)
        {
            var dateOne = DateTime.Parse(date1);
            var dateTwo = DateTime.Parse(date2);
            int difference = Math.Abs((dateOne - dateTwo).Days);

            return difference;
        }
    }
}
