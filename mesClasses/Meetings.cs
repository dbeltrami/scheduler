using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Model
{
    class Meetings : Events
    {
        List<Users> participants;

        public Meetings (string _name, string _description, DateTime _pointBegin, DateTime _pointEnd, Periodicity _period, List<Users> _participants) : base(_name, _description, _pointBegin, _pointEnd, _period)
        {
            this.participants = _participants;
        }
        public Meetings getMeeting()
        {
            return this;
        }
    }
}
