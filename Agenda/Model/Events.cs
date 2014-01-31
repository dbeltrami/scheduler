using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class Events
    {
        public string name { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        private DateTime pointBegin { get; set; }
        private DateTime pointEnd { get; set; }
        private int period { get; set; }
        private List<Users> lesParticipants { get; set; }
        public string type { get; set; }

        public Events()
        {
            this.name = "";
            this.type = "";
            this.lesParticipants = new List<Users>();
            this.description = "";
            this.pointBegin = new DateTime();
            this.pointEnd = new DateTime();
            this.period = 0;
        }
        public Events(int _id)
        {
            this.id = _id;
            this.name = "";
            this.type = "";
            this.lesParticipants = new List<Users>();
            this.description = "";
            this.pointBegin = new DateTime();
            this.pointEnd = new DateTime();
            this.period = 0;
        }
        public Events(string _name, string _description, DateTime _pointBegin, DateTime _pointEnd, int _period)
        {
            this.name = _name;
            this.description = _description;
            this.pointBegin = _pointBegin;
            this.pointEnd = _pointEnd;
            this.period = _period;
            this.lesParticipants = new List<Users>();
            this.type = "";
        }
    }
}
