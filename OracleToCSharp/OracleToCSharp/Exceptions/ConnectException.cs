﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public class ConnectException : Exception
	{
		public ConnectException() { }
		public ConnectException(string message) : base(message) { }
		public ConnectException(string message, Exception inner) : base(message, inner) { }
	}
}
