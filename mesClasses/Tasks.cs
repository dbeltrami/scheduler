using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Model
{
    class Tasks : Events
    {
        public Tasks(string _name, string _description, DateTime _pointBegin, DateTime _pointEnd, Periodicity _period)
            : base(_name, _description, _pointBegin, _pointEnd, _period)
        {

        }
    }
}
