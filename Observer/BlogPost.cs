namespace Observer
{
	public class BlogPost : Observable
	{
		public string BlogName { get; set; }
		protected List<string> blogLogs;
		protected List<Observer> listObservers = new List<Observer>();

		public BlogPost(string blogName)
		{
			BlogName = blogName;
			blogLogs = new List<string>() {"Blog " + BlogName + " Started"};
		}
		public void Enrole(Observer observer)
		{
			listObservers.Add(observer);
			blogLogs.Add("Enrole to blog user with NickName = " + observer.NickName);
		}

		public void Unenrole(Observer observer)
		{
			listObservers.Remove(observer);
			blogLogs.Add("Unenrole to blog user with NickName = " + observer.NickName);
		}

		public void UnenroleAll()
		{
			blogLogs.Add("Unenrole all observers");
			foreach (var observer in listObservers)
			{
				blogLogs.Add("Unenrole to blog user with NickName = " + observer.NickName);
			}

			listObservers.Clear();
		}

		public void Notify(string post)
		{
			blogLogs.Add("Create post -> " + post);
			foreach (Observer observer in listObservers)
			{
				observer.Update(BlogName + " -> " + post);
			}
		}

		public void ShowLogs()
		{
			Console.WriteLine("Blog " + BlogName + " Logs -> ");
			foreach (var blogLog in blogLogs)
			{
				Console.WriteLine(blogLog);
			}
		}
	}
}
