using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleToCSharp
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			foreach (PropertyType type in Enum.GetValues(typeof(PropertyType)))
			{
				cmbProp.Items.Add(type.ToString());
			}
			foreach (Language type in Enum.GetValues(typeof(Language)))
			{
				CmbLang.Items.Add(type.ToString());
			}

			CmbLang.SelectedIndex = 0;
			cmbProp.SelectedIndex = 0;
		}

		private void btnDir_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			DialogResult result = fbd.ShowDialog();

			if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
			{
				txtDir.Text = fbd.SelectedPath;
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			OracleDb.ConnString = @"Data Source=" + TxtIp.Text + "/" + TxtService.Text + ";User Id=" + TxtUser.Text + ";Password=" + TxtPassword.Text + ";";

			Generate();
		}

		private void Generate()
		{
			if (string.IsNullOrWhiteSpace(txtDir.Text))
				MessageBox.Show("Please select a directory!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (string.IsNullOrWhiteSpace(TxtIp.Text))
				MessageBox.Show("Please fill in an ip address!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (string.IsNullOrWhiteSpace(txtNameSpace.Text))
				MessageBox.Show("Please fill in a namespace!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (string.IsNullOrWhiteSpace(TxtPassword.Text) || string.IsNullOrWhiteSpace(TxtUser.Text))
				MessageBox.Show("Please fill in all the user data!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (string.IsNullOrWhiteSpace(TxtService.Text))
				MessageBox.Show("Please fill in a service name!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				GenerateClass generateClass = new GenerateClass
				(
					(Language)CmbLang.SelectedIndex,
					(PropertyType)cmbProp.SelectedIndex,
					txtDir.Text,
					txtNameSpace.Text
				);
				

				string succesString = @"The class(es) have been succesfully generated!
										Location(s): ";

				List<string> generatedFiles = generateClass.Generate();

				if (generatedFiles != null) {
					foreach (string file in generatedFiles)
					{
						succesString = succesString +
											@"
										" + file;
					}
					MessageBox.Show(succesString, "Succes!", MessageBoxButtons.OK);
				}
			}
		}
	}
}
