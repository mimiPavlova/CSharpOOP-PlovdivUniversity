using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public  class Commit
    {
        public string Messege { get; }
        public User Author { get; }
         public DateTime Timestamp { get; }

        public Commit(string messege, User author, DateTime timestamp)
        {
            Messege=messege;
            Author=author;
            Timestamp=timestamp;
        }
    }
}
