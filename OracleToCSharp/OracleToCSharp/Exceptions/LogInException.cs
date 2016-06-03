using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public class LogInException : Exception
	{
		public LogInException() { }
		public LogInException(string message) : base(message) { }
		public LogInException(string message, Exception inner) : base(message, inner) { }

	}
}
