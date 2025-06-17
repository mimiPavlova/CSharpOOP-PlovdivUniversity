using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public class User
    {
        public string Username { get; private set; }
        public User(string username)
        {
            this.Username = username;
        }
        public void Commit(Repository repo, string messege)
        {
            Branch mainBranch = repo.Branches.FirstOrDefault(B => B.Name=="main");
            if (mainBranch != null)
            {
                Commit commit = new Commit(messege, this, DateTime.Now);
                mainBranch.Commits.Add(commit);
            }
            else
            {
                throw new ArgumentException("Main branch is not found in the repository");
            }
        }

    }
}
