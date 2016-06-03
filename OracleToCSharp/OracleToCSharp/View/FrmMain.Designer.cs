namespace OracleToCSharp
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbDir = new System.Windows.Forms.GroupBox();
			this.btnDir = new System.Windows.Forms.Button();
			this.txtDir = new System.Windows.Forms.TextBox();
			this.gbInfo = new System.Windows.Forms.GroupBox();
			this.gbUser = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.gbConn = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtService = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtIp = new System.Windows.Forms.TextBox();
			this.lblIp = new System.Windows.Forms.Label();
			this.gbClass = new System.Windows.Forms.GroupBox();
			this.CmbLang = new System.Windows.Forms.ComboBox();
			this.cmbProp = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNameSpace = new System.Windows.Forms.TextBox();
			this.gbDir.SuspendLayout();
			this.gbInfo.SuspendLayout();
			this.gbUser.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gbConn.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbClass.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbDir
			// 
			this.gbDir.Controls.Add(this.btnDir);
			this.gbDir.Controls.Add(this.txtDir);
			this.gbDir.Location = new System.Drawing.Point(13, 13);
			this.gbDir.Name = "gbDir";
			this.gbDir.Size = new System.Drawing.Size(325, 48);
			this.gbDir.TabIndex = 0;
			this.gbDir.TabStop = false;
			this.gbDir.Text = "Class Directory";
			// 
			// btnDir
			// 
			this.btnDir.Image = global::OracleToCSharp.Properties.Resources.OpenFolder;
			this.btnDir.Location = new System.Drawing.Point(292, 20);
			this.btnDir.Name = "btnDir";
			this.btnDir.Size = new System.Drawing.Size(27, 20);
			this.btnDir.TabIndex = 1;
			this.btnDir.UseVisualStyleBackColor = true;
			this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
			// 
			// txtDir
			// 
			this.txtDir.Location = new System.Drawing.Point(7, 20);
			this.txtDir.Name = "txtDir";
			this.txtDir.Size = new System.Drawing.Size(279, 20);
			this.txtDir.TabIndex = 0;
			// 
			// gbInfo
			// 
			this.gbInfo.Controls.Add(this.gbUser);
			this.gbInfo.Controls.Add(this.gbConn);
			this.gbInfo.Location = new System.Drawing.Point(13, 68);
			this.gbInfo.Name = "gbInfo";
			this.gbInfo.Size = new System.Drawing.Size(325, 188);
			this.gbInfo.TabIndex = 1;
			this.gbInfo.TabStop = false;
			this.gbInfo.Text = "Database Information";
			// 
			// gbUser
			// 
			this.gbUser.Controls.Add(this.groupBox3);
			this.gbUser.Controls.Add(this.TxtPassword);
			this.gbUser.Controls.Add(this.label6);
			this.gbUser.Controls.Add(this.TxtUser);
			this.gbUser.Controls.Add(this.label7);
			this.gbUser.Location = new System.Drawing.Point(7, 103);
			this.gbUser.Name = "gbUser";
			this.gbUser.Size = new System.Drawing.Size(312, 78);
			this.gbUser.TabIndex = 5;
			this.gbUser.TabStop = false;
			this.gbUser.Text = "User";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Location = new System.Drawing.Point(0, 109);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(312, 105);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Connection";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(83, 48);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(126, 20);
			this.textBox4.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Service Name:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(83, 22);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(126, 20);
			this.textBox5.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "IP Address:";
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(83, 48);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(126, 20);
			this.TxtPassword.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Password:";
			// 
			// TxtUser
			// 
			this.TxtUser.Location = new System.Drawing.Point(83, 22);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(126, 20);
			this.TxtUser.TabIndex = 1;
			this.TxtUser.Text = "System";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "User Name:";
			// 
			// gbConn
			// 
			this.gbConn.Controls.Add(this.groupBox1);
			this.gbConn.Controls.Add(this.TxtService);
			this.gbConn.Controls.Add(this.label1);
			this.gbConn.Controls.Add(this.TxtIp);
			this.gbConn.Controls.Add(this.lblIp);
			this.gbConn.Location = new System.Drawing.Point(7, 19);
			this.gbConn.Name = "gbConn";
			this.gbConn.Size = new System.Drawing.Size(312, 78);
			this.gbConn.TabIndex = 2;
			this.gbConn.TabStop = false;
			this.gbConn.Text = "Connection";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(0, 109);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 105);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connection";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(83, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(126, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Service Name:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(83, 22);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(126, 20);
			this.textBox3.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "IP Address:";
			// 
			// TxtService
			// 
			this.TxtService.Location = new System.Drawing.Point(83, 48);
			this.TxtService.Name = "TxtService";
			this.TxtService.Size = new System.Drawing.Size(126, 20);
			this.TxtService.TabIndex = 3;
			this.TxtService.Text = "Xe";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Service Name:";
			// 
			// TxtIp
			// 
			this.TxtIp.Location = new System.Drawing.Point(83, 22);
			this.TxtIp.Name = "TxtIp";
			this.TxtIp.Size = new System.Drawing.Size(126, 20);
			this.TxtIp.TabIndex = 1;
			this.TxtIp.Text = "Localhost";
			// 
			// lblIp
			// 
			this.lblIp.AutoSize = true;
			this.lblIp.Location = new System.Drawing.Point(6, 25);
			this.lblIp.Name = "lblIp";
			this.lblIp.Size = new System.Drawing.Size(61, 13);
			this.lblIp.TabIndex = 0;
			this.lblIp.Text = "IP Address:";
			// 
			// gbClass
			// 
			this.gbClass.Controls.Add(this.txtNameSpace);
			this.gbClass.Controls.Add(this.label10);
			this.gbClass.Controls.Add(this.CmbLang);
			this.gbClass.Controls.Add(this.cmbProp);
			this.gbClass.Controls.Add(this.label9);
			this.gbClass.Controls.Add(this.label8);
			this.gbClass.Location = new System.Drawing.Point(13, 263);
			this.gbClass.Name = "gbClass";
			this.gbClass.Size = new System.Drawing.Size(325, 116);
			this.gbClass.TabIndex = 2;
			this.gbClass.TabStop = false;
			this.gbClass.Text = "Class Information";
			// 
			// CmbLang
			// 
			this.CmbLang.FormattingEnabled = true;
			this.CmbLang.Location = new System.Drawing.Point(90, 45);
			this.CmbLang.Name = "CmbLang";
			this.CmbLang.Size = new System.Drawing.Size(126, 21);
			this.CmbLang.TabIndex = 9;
			// 
			// cmbProp
			// 
			this.cmbProp.FormattingEnabled = true;
			this.cmbProp.Location = new System.Drawing.Point(90, 16);
			this.cmbProp.Name = "cmbProp";
			this.cmbProp.Size = new System.Drawing.Size(126, 21);
			this.cmbProp.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Properties: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Language:";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(263, 389);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate!";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(11, 75);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Namespace:";
			// 
			// txtNameSpace
			// 
			this.txtNameSpace.Location = new System.Drawing.Point(90, 72);
			this.txtNameSpace.Name = "txtNameSpace";
			this.txtNameSpace.Size = new System.Drawing.Size(126, 20);
			this.txtNameSpace.TabIndex = 5;
			this.txtNameSpace.Text = "Your Namespace";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 424);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.gbClass);
			this.Controls.Add(this.gbInfo);
			this.Controls.Add(this.gbDir);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database To Class";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.gbDir.ResumeLayout(false);
			this.gbDir.PerformLayout();
			this.gbInfo.ResumeLayout(false);
			this.gbUser.ResumeLayout(false);
			this.gbUser.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.gbConn.ResumeLayout(false);
			this.gbConn.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbClass.ResumeLayout(false);
			this.gbClass.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbDir;
		private System.Windows.Forms.Button btnDir;
		private System.Windows.Forms.TextBox txtDir;
		private System.Windows.Forms.GroupBox gbInfo;
		private System.Windows.Forms.GroupBox gbConn;
		private System.Windows.Forms.TextBox TxtService;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtIp;
		private System.Windows.Forms.Label lblIp;
		private System.Windows.Forms.GroupBox gbUser;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtUser;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox gbClass;
		private System.Windows.Forms.ComboBox CmbLang;
		private System.Windows.Forms.ComboBox cmbProp;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.TextBox txtNameSpace;
		private System.Windows.Forms.Label label10;
	}
}

