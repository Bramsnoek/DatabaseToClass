using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public class SetValueWriter : Writer
	{
		public SetValueWriter(List<Tuple<string, string>> properties, string classname)
			: base(properties, classname)
		{

		}

		public override void Write(StreamWriter writer)
		{
			writer.Write(@"
		#region Fields");
			writer.Write(Environment.NewLine);
			foreach (Tuple<string, string> property in Properties)
			{
				writer.Write
			(@"
		private " + property.Item2 + " " + property.Item1.ToLower() + @";");
			}
			writer.Write(Environment.NewLine);
			writer.Write(Environment.NewLine);
			writer.Write("		#endregion");

			writer.Write(@"

		#region Properties");
			writer.Write(Environment.NewLine);
			foreach (Tuple<string, string> property in Properties)
			{
				writer.Write(@"
		public " + property.Item2 + " " + GetTitle(property.Item1) + @"
		{
			get { return " + property.Item1.ToLower() + @"; } 
			set { SetField(this, ref " + property.Item1.ToLower() + @", value); }
		}");
			}
			writer.Write(Environment.NewLine);
			writer.Write(Environment.NewLine);
			writer.Write("		#endregion");

			writer.Write(@"

		#region Constructor");
			writer.Write
				(@"

		public " + GetTitle(className) + @"(");

			foreach (Tuple<string, string> property in Properties)
			{
				if (Properties.IndexOf(property) == 0)
					writer.Write(property.Item2 + " " + property.Item1.ToLower());
				else
					writer.Write(", " + property.Item2 + " " + property.Item1.ToLower());
			}

			writer.Write(")");
			writer.Write(@"
		{");

			foreach (Tuple<string, string> property in Properties)
			{
				writer.Write(
				@"
			" + GetTitle(property.Item1) + " = " + property.Item1.ToLower() + ";");
			}

			writer.Write(@"
		}");
			writer.Write(Environment.NewLine);
			writer.Write(Environment.NewLine);
			writer.Write("		#endregion");
		}
	}
}
