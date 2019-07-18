namespace DefiningClasses
{
    using System;
    public class DateModifier
    {
        private string startDate;
        private string endDate;

        public double Difference(string startDate, string endDate)
        {
            double days = Math.Abs((Convert.ToDateTime(endDate) - Convert.ToDateTime(startDate)).TotalDays);
            return days;
        }
    }
}