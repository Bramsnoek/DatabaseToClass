using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public class ClassWriter : IWriter
	{
		private Writer writer;
		private string nameSpace;
		private string className;
		public ClassWriter(Writer writer, string nameSpace, string className)
		{
			this.writer = writer;
			this.nameSpace = nameSpace;
			this.className = className;
		}

		public void Write(StreamWriter writer)
		{
			if (this.writer is SetValueWriter)
			{
				writer.Write(@"
using ExtendedObservableCollection;
							");
				writer.Write(@"
namespace " + this.writer.GetTitle(nameSpace) + @"
{
	public class " + this.writer.GetTitle(className) + @" : ExtendedNotifyPropertyChanged
	{");

			}
			else
			{
				writer.Write(@"
namespace " + this.writer.GetTitle(nameSpace) + @"
{
	public class " + this.writer.GetTitle(className) + @"
	{");
			}



			this.writer.Write(writer);


		writer.Write
		(@"
	}
}");
		}
	}
}
