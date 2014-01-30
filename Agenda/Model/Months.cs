using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class Months
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<int> Days { get; set; }

        public Months()
        {
            Days = new List<int>();
        }
        public void addDay(int leJour){
            this.Days.Add(leJour);
        }
    }
}
