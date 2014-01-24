using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Model
{
    class Users
    {
        private string email;
        private string password;

        public Users(string _email, string _password)
        {
            this.email = _email;
            this.password = _password;
        }
    }
}
