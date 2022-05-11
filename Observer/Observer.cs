using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public interface Observer
	{
		string NickName { get; }
		void Update(string post);
		void ShowLogs();
	}
}
