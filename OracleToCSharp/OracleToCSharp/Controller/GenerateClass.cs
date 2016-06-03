using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleToCSharp
{
	public enum Language
	{
		CSharp
	}

	public enum PropertyType
	{
		Properties,
		FullProperties,
		Fields,
		SetValueProperties
	}

	public class GenerateClass
	{
		private Language Language;
		private PropertyType PropertyType;
		private string dirPath;
		private string nameSpace;

		public GenerateClass(Language language, PropertyType propertyType, string dirPath, string nameSpace)
		{
			this.Language = language;
			this.PropertyType = propertyType;
			this.dirPath = dirPath;
			this.nameSpace = nameSpace;
		}

		public List<string> Generate()
		{
			List<string> fileNames = new List<string>();

			try {
				foreach (DataRow row in OracleDb.SelectData(new OracleCommand(@"Select table_name from user_tables where table_name not like '%$%' and table_name not like '%LOGMNR%' and table_name not like '%SQLPLUS%' and table_name not like 'HELP' and table_name = 'POSTCODE'")).Rows)
				{
					ClassWriter writer = new ClassWriter(getPropertyWriter(row["TABLE_NAME"].ToString()), nameSpace, row["TABLE_NAME"].ToString());

					using (StreamWriter fileWriter = File.AppendText(dirPath + "/" + row["TABLE_NAME"].ToString() + getFileExtension()))
					{
						fileNames.Add(dirPath + "/" + row["TABLE_NAME"].ToString() + getFileExtension());
						writer.Write(fileWriter);
					}
				}

				return fileNames;
			}
			catch(Exception ex)
			{
				if(ex is LogInException)
				{
					MessageBox.Show(@"Your user information is incorrect! Please check your username and password!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return null;
				}
				else if (ex is ConnectException)
				{
					MessageBox.Show(@"Your connection information is incorrect! Please check your connection information!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return null;
				}
				else if (ex is NullReferenceException)
				{
					MessageBox.Show(@"Your database doesn't contain any tables! Please fill your database with tables!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return null;
				}
				return null;
			}
		}

		private string getFileExtension()
		{
			switch (Language)
			{
				case Language.CSharp:
					return ".cs";
			}

			return ".txt";
		}

		private Writer getPropertyWriter(string tableName)
		{
			List<Tuple<string, string>> properties = new List<Tuple<string, string>>();

			foreach (DataRow column in OracleDb.SelectData(new Oracle.ManagedDataAccess.Client.OracleCommand(@"SELECT table_name, column_name, data_type, data_length FROM USER_TAB_COLUMNS WHERE table_name = '" + tableName + "'")).Rows)
			{
				properties.Add(new Tuple<string, string>(column["COLUMN_NAME"].ToString(), GetPropertyType(column["DATA_TYPE"].ToString())));
			}

			switch (PropertyType)
			{
				case PropertyType.Properties:
					return new PropertyWriter(properties, tableName);
				case PropertyType.FullProperties:
					return new FullPropertyWriter(properties, tableName);
				case PropertyType.Fields:
					return new FieldWriter(properties, tableName);
				case PropertyType.SetValueProperties:
					return new SetValueWriter(properties, tableName);
			}

			return null;
		}
		private string GetPropertyType(string dbTypeName)
		{
			switch (dbTypeName)
			{
				case "VARCHAR2":
					return "string";
				case "DATE":
					return "DateTime";
				case "NUMBER":
					return "int";
				case "INTEGER":
					return "int";
				case "DECIMAL":
					return "decimal";
				case "TIMESTAMP":
					return "DateTime";
				case "CHAR":
					return "char";
				case "BYTE":
					return "byte";
				case "DOUBLE":
					return "double";
				case "LONG":
					return "long";
				case "NVARCHAR2":
					return "string";
			}

			return dbTypeName;
		}
	}
}

