using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace AddressBook
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private System.Windows.Forms.TextBox TxtDname;
        private System.Windows.Forms.TextBox TxtSname;
		private System.Windows.Forms.Button BtnConnect;
		private System.Windows.Forms.Button BtnExit;
        private TextBox TxtPass;
        private TextBox TxtUid;
		Form1 f1 = new Form1();
		public Form3()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSname = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TxtDname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database Name";
            // 
            // TxtSname
            // 
            this.TxtSname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSname.Location = new System.Drawing.Point(144, 40);
            this.TxtSname.Name = "TxtSname";
            this.TxtSname.Size = new System.Drawing.Size(184, 20);
            this.TxtSname.TabIndex = 0;
            this.TxtSname.Text = ".";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(162, 90);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TxtDname
            // 
            this.TxtDname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDname.Location = new System.Drawing.Point(144, 64);
            this.TxtDname.Name = "TxtDname";
            this.TxtDname.Size = new System.Drawing.Size(184, 20);
            this.TxtDname.TabIndex = 1;
            this.TxtDname.Text = "AddressBook";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Database Connection Information";
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(253, 90);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Quit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(144, 38);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(184, 22);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.Visible = false;
            // 
            // TxtUid
            // 
            this.TxtUid.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUid.Location = new System.Drawing.Point(144, 63);
            this.TxtUid.Name = "TxtUid";
            this.TxtUid.Size = new System.Drawing.Size(184, 20);
            this.TxtUid.TabIndex = 2;
            this.TxtUid.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(344, 119);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUid);
            this.Controls.Add(this.TxtDname);
            this.Controls.Add(this.TxtSname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Connectin Informtion";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form3());
		}

		private void BtnConnect_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			f1.Show();
            TxtUid.Text = "sa";
            TxtPass.Text = "";
			f1.Connection_To_Database(TxtSname.Text,TxtDname.Text,TxtUid.Text,TxtPass.Text);		
		}

		
		public void BlankBox()
		{
			string str;
			foreach(Control ctrl in this.Controls)
			{
				str = Convert.ToString(ctrl.GetType());
				if(str == "System.Windows.Forms.TextBox")
				{
					ctrl.Text = "";
				}
			}
		}
		public void CheckBlank()
		{
			string str;
			foreach(Control ctrl in this.Controls)
			{
				str = Convert.ToString(ctrl.GetType());
				if(str == "System.Windows.Forms.TextBox")
				{
					if(ctrl.Text.Length == 0)
					{
						MessageBox.Show("Cannot Left Blank any Field");
						ctrl.Focus();
						break;
					}
				}
			}
		}

		private void BtnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void Form3_Load(object sender, EventArgs e)
        {

        }
	}
}
