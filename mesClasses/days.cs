using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    class Days
    {
        List<Events> theEvents;
        DateTime selectedDay;
        DateTime currentDay;

        public Days(DateTime day)
        {
            this.init();
            selectedDay = day;
            currentDay = DateTime.Now;
        }

        public List<Events> getEvents()
        {
            List<Events> list = new List<Events>();
            foreach (Events currentEvent in theEvents)
            {
                if (currentEvent.getPointBegin().Day == selectedDay.Day)
                {
                    list.Add(currentEvent);
                }
            }
            return list;
        }
        public void uploadEvents(Days day)
        {

        }
        private void init()
        {
            this.theEvents = new List<Events>();
            for (int jour = 1; jour < 31; jour++)
            {
                theEvents.Add(new Meetings(
                    "Meeting " + jour,
                    "description",
                    new DateTime(DateTime.Now.Year, DateTime.Now.Month, jour, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second),
                    new DateTime(DateTime.Now.Year, DateTime.Now.Month, jour, DateTime.Now.Hour + 1, DateTime.Now.Minute, DateTime.Now.Second),
                    null,
                    null)
                    );
            }
        }

    }
}
