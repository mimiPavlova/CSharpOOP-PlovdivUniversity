using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenegar
{
    public class User
    {
        public string UserName { get; }

        public User(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName)) throw new ArgumentNullException("name cannot be empty");

            UserName=userName;
        }
    }
}
