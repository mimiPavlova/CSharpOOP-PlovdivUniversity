using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public class Repository
    {
        public string Name { get; }
        public User Owner { get; }
        public List<Branch> Branches = new();
        public void AddBranch(string name)
        {
            Branches.Add(new Branch(name));
        }
        public void GetLatestCommits(string branchName)
        {
            Branch current = Branches.FirstOrDefault(b=>b.Name == branchName);
            foreach (Commit c in current.Commits)
            {
                Console.WriteLine($"Authour: {c.Author.Username}\n Messege: {c.Messege}\n Timestamp: {c.Timestamp}");
            }
        }
    }
}
