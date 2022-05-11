using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public interface Observable
	{
		string BlogName { get;}
		void Enrole(Observer observer);

		void Unenrole(Observer observer);

		void UnenroleAll();
		
		void Notify(string post);
		void ShowLogs();
	}
}
