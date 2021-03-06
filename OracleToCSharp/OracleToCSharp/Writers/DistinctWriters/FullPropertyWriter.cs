﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public class FullPropertyWriter : Writer
	{
		public FullPropertyWriter(List<Tuple<string, string>> properties, string classname)
			: base(properties, classname)
		{

		}
		public override void Write(StreamWriter writer)
		{
			foreach (Tuple<string, string> property in Properties)
			{
				writer.Write
				(@"
		private " + property.Item2 + " " + property.Item1.ToLower() + @";
				");

				writer.Write(@"
		public " + property.Item2 + " " + GetTitle(property.Item1) + @"
		{
			get { return " + property.Item1.ToLower() + @"; } 
			set { " + property.Item1.ToLower() + @" = value;
		}
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
			" + GetTitle(property.Item1) + " = " + property.Item1.ToLower() + ";");
			}

			writer.Write(@"
		}");
		}
	}
}

