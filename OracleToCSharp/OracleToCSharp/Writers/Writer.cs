using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public abstract class Writer : IWriter
	{
		public List<Tuple<string, string>> Properties { get; set; }
		public string className { get; set; }

		public Writer(List<Tuple<string, string>> properties, string className)
		{
			this.Properties = properties;
			this.className = className;
		}

		public abstract void Write(StreamWriter writer);

		public string GetTitle(string title)
		{
			string adjustedTitle = title.ToLower();
			adjustedTitle = adjustedTitle[0].ToString().ToUpper() + adjustedTitle.Substring(1, title.Length - 1);

			return adjustedTitle;
		}
	}
}
