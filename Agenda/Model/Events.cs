using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Model
{
    
    class Events
    {
        private string name;
        private string description;
        private DateTime pointBegin;
        private DateTime pointEnd;
        private Periodicity period;

        public Events(string _name, string _description, DateTime _pointBegin, DateTime _pointEnd, Periodicity _period)
        {
            this.name = _name;
            this.description = _description;
            this.pointBegin = _pointBegin;
            this.pointEnd = _pointEnd;
            this.period = _period;
        }
        

        public Events getEvent()
        {
            return this;
        }
        public string getName() { return this.name; }
        public string getDescription() { return this.description; }
        public DateTime getPointBegin() { return this.pointBegin; }
        public DateTime getPointEnd() { return this.pointEnd; }
        public Periodicity getPeriod() { return this.period; }
    }
}
