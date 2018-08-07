using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    public class DayInfo
    {
        private DateTime Date;
        private decimal CurrentSpend;
        private int Week;

        public DayInfo(DateTime p_date, decimal p_spend)
        {
            WeekHandler weekHandler = new WeekHandler();
            Date = p_date;
            CurrentSpend = p_spend;
            Week = weekHandler.GetWeekOfYear(p_date);
        }

        public DateTime GetDate() { return Date; }
        public decimal GetSpend() { return CurrentSpend; }
        public int GetWeek() { return Week; }
        public void AddSpend(decimal add) { CurrentSpend += add; }
        public void SubSpend(decimal sub) { CurrentSpend -= sub; }
    }
}
