﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public class FieldWriter : Writer
	{
		public FieldWriter(List<Tuple<string, string>> properties, string classname) 
			: base(properties, classname)
		{
		}

		public override void Write(StreamWriter writer)
		{
			foreach (Tuple<string, string> property in Properties)
			{
				writer.Write
				(@"
		public " + property.Item2 + " " + property.Item1.ToLower() + @";
				");
			}


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
			this." + property.Item1.ToLower() + " = " + property.Item1.ToLower() + ";");
			}

			writer.Write(@"
		}");
		}
	}
}

