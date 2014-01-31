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
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Users()
        {
        }
        public Users(int _id)
        {
            this.id = _id;
        }
        public Users(string _email, string _password)
        {
            this.email = _email;
            this.password = _password;
            this.listeUsers = new List<Users>();
        }
    }
}
