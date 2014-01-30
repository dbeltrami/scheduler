using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Agenda.Model
{
    class Users
    {
        public string email { get; set; }
        public string password { get; set; }
        private List<Users> listeUsers;

        public Users()
        {
            this.email = "";
            this.password = "";
        }
        public Users(string _email, string _password)
        {
            this.email = _email;
            this.password = _password;
            this.listeUsers = new List<Users>();
        }

        public List<Users> getUsers(){


            return this.listeUsers;
        }

        public void createUser()
        {
            using (var client = new HttpClient())
            {

            }

        }

        public static Users getUser()
        {
            Users unUser = new Users();

            using (var webClient = new System.Net.WebClient())
            {
               // var json = webClient.DownloadString("http://82.236.45.188/AgendaWS/events/1");
                var json = webClient.DownloadString("http://82.236.45.188/VroumVroum/users/1");
                JObject jObject = JObject.Parse(json);
                JToken jUser = jObject;
                unUser.email = (string)jUser["email"];
                unUser.password = (string)jUser["userToken"];
            }

            return unUser;
        }
    }
}
