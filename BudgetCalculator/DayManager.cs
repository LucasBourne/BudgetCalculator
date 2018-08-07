using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    class DayManager
    {
        private List<DayInfo> DayList = new List<DayInfo>();
        
        public void AddDay(DayInfo dayToAdd)
        {
            DayList.Add(dayToAdd);
        }
        public List<DayInfo> GetList()
        {
            return DayList;
        }
        public decimal GetWeeklyTotal(int WeekNumber)
        {
            decimal total = 0;
            foreach(DayInfo day in DayList)
            {
                if (day.GetWeek() == WeekNumber)
                {
                    total += day.GetSpend();
                }
            }
            return total;
        }
    }
}
