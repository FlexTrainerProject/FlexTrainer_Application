using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FLEXTrainer
{
    public class User
    {
        public string Username { get; set; }

        public string Type { get; set; }
        public string Password { get; set; }

        // Constructor
        public User(string username, string type, string password)
        {
            Username = username;
            Type = type;
            Password = password;
        }
    }
}
