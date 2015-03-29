using butterfly.service.schedule.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace butterfly.service.schedule
{
    public class ScheduleDataService
    {
        public static List<Day> GetDays(string _day)
        {
            if (!String.IsNullOrEmpty(_day))
            {
                using (ScheduleEntities context = new ScheduleEntities())
                {
                    IQueryable<Day> days =
                        from day in context.DayTable
                        where (day.DayId.Contains(_day))
                        select new Day() { DayId = day.DayId, DayOfWeek = day.DayOfWeek };
                    return days.ToList<Day>();
                }
            }
            return new List<Day>();
        }
    }
}
