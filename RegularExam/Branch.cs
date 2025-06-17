using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public  class Branch
    {
        public string Name { get; }
        public List<Commit> Commits;
        public Branch(string name)
        {
            this.Name = name;
            Commits=new List<Commit>();
        }


    }

}
