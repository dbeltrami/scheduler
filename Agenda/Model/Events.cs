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
    class Events
    {
        public string name { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        private DateTime pointBegin;
        private DateTime pointEnd;
        private Periodicity period;
        private List<Users> lesParticipants;
        public string type { get; set; }

        public Events()
        {
            this.name = "";
            this.type = "";
            this.lesParticipants = new List<Users>();
            this.description = "";
            this.pointBegin = new DateTime();
            this.pointEnd = new DateTime();
            this.period = null;
        }
        public Events(string _name, string _description, DateTime _pointBegin, DateTime _pointEnd, Periodicity _period)
        {
            this.name = _name;
            this.description = _description;
            this.pointBegin = _pointBegin;
            this.pointEnd = _pointEnd;
            this.period = _period;
            this.lesParticipants = new List<Users>();
            this.type = "";
        }


        //public static Events getEvent(int id)
        public async Task getEvent(int id)
        {
            //using (var webClient = new System.Net.WebClient())
            //{
            //    // var json = webClient.DownloadString("http://82.236.45.188/AgendaWS/events/"+id);
            //    //JObject jObject = JObject.Parse(json);
            //    //JToken jEvent = jObject;
            //    //unEvent.name = (string)jEvent["name"];
            //    //unEvent.description = (string)jEvent["description"];
            //    //unEvent.type = (string)jEvent["type"];
            //}

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://82.236.45.188/AgendaWS/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("events/" + id);
            if (response.IsSuccessStatusCode)
            {
                Events theEvent = await response.Content.ReadAsAsync<Events>();
                this.id = theEvent.id;
                this.name = theEvent.name;
                this.description = theEvent.description;
            }
        }
        public static List<Events> getEvents()
        {
            List<Events> lesEvents = new List<Events>();

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://82.236.45.188/AgendaWS/events");
                JArray arr = JArray.Parse(json);

                for (int i = 0; i < arr.Count; i++)
                {
                    JObject jObject = JObject.Parse(arr[i].ToString());
                    JToken jEvent = jObject;
                    Events newEvent = new Events();
                    newEvent.name = (string)jEvent["name"];
                    newEvent.description = (string)jEvent["description"];
                    newEvent.type = (string)jEvent["type"];
                    lesEvents.Add(newEvent);
                }
            }

            return lesEvents;
        }

        public async Task addEvent()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://82.236.45.188/AgendaWS/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync("events", this);
        }

        public async Task editEvent()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://82.236.45.188/AgendaWS/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("events" + this.id);
            if (response.IsSuccessStatusCode)
            {
                Uri eventUrl = response.Headers.Location;
                response = await client.DeleteAsync(eventUrl);
            }
        }

        public async Task deleteEvent()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://82.236.45.188/AgendaWS/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.DeleteAsync("events/" + this.id);
        }

        public DateTime getPointBegin() { return this.pointBegin; }
        public DateTime getPointEnd() { return this.pointEnd; }
        public Periodicity getPeriod() { return this.period; }

    }
}
