using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public static class DateModifier
    {
        public static double GetDaysDifference(string dateOne, string dateTwo)
        {
            DateTime firstDate = DateTime.Parse(dateOne);
            DateTime secondDate = DateTime.Parse(dateTwo);

            double result = Math.Abs((firstDate - secondDate).TotalDays);

            return result;
        }

    }
}
