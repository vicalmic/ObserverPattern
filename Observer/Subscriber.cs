using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class Subscriber : Observer
	{
		private List<string> subscriberLogs;
		public string NickName { get; set; }

		public Subscriber(string nickName)
		{
			NickName = nickName;
			subscriberLogs = new List<string>() {"Subscriber Activated with Nick Name = " + NickName};
		}

		public void Update(string post)
		{
			subscriberLogs.Add("Subscriber " + NickName + " saw post from \n\t" + post );
		}

		public void ShowLogs()
		{
			Console.WriteLine(NickName + " Logs -> ");
			foreach (var subscriberLog in subscriberLogs)
			{
				Console.WriteLine(subscriberLog);
			}
		}
	}
}
