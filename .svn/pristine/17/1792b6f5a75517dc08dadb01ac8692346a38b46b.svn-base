using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BudgetCalculator
{
    public class WeekHandler
    {
        Calendar calendar = CultureInfo.CurrentCulture.Calendar;
        public int GetWeekOfYear(DateTime date)
        {
            return calendar.GetWeekOfYear(date, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);
        }
    }
}
