namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class DateModifier
    {
        public static int CalculateDifferenceInDays(string[] input1, string[] input2)
        {
            var year = int.Parse(input1[0]);
            var month = int.Parse(input1[1]);
            var day = int.Parse(input1[2]);

            var dateOne = new DateTime(year, month, day);

            var year1 = int.Parse(input2[0]);
            var month1 = int.Parse(input2[1]);
            var day1 = int.Parse(input2[2]);

            var dateTwo = new DateTime(year1, month1, day1);



            var compareInDays = Math.Abs((dateOne.Date - dateTwo.Date).Days);

            return compareInDays;
        }
    }
}
