using RegularExam;

Repository repo=new Repository();
repo.AddBranch("main");
User user = new User("user1");
user.Commit(repo, "Hello Word", "main");
repo.GetLatestCommits("main");