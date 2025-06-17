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
            if(string.IsNullOrWhiteSpace(username))throw new ArgumentNullException("username cannot be null");
            this.Username = username;
        }
        public void Commit(Repository repo, string messege, string branch)
        {
            Branch currentBranch = repo.Branches.FirstOrDefault(B => B.Name==branch);
            if (currentBranch != null)
            {
                Commit commit = new Commit(messege, this, DateTime.Now);
                currentBranch.Commits.Add(commit);
            }
            else
            {
                throw new ArgumentException($"Branch {branch} is not found in the repository");
            }
        }

    }
}
