using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public  class Class
    {
        public string Name { get; }
        public Class(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Name cannot be null");
            this.Name=name;
        }
    }
}
