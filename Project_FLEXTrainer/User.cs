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
        public string Password { get; set; }

        // Constructor
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
