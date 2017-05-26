using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;            //   To Connect with Database u have to use this 
using System.Data.SqlClient;  //   both namespace other wise it will gives u an error.
/*
 * CREATE TABLE ADDRESSBOOK
(
	NAME VARCHAR(50),
	ADDRESS VARCHAR(100),
	CITY VARCHAR(20),
	STATE VARCHAR(20),
	COUNTRY VARCHAR(20),
	PHONE VARCHAR(25),
	E_MAIL_ID VARCHAR(75)
)

create table StoreInfo(sname varchar(20),dbname varchar(20),uid varchar(20),pass varchar(20))
 */
namespace AddressBook
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox TxtName;
		private System.Windows.Forms.TextBox TxtAdd;
		private System.Windows.Forms.TextBox TxtCity;
		private System.Windows.Forms.TextBox TxtState;
		private System.Windows.Forms.TextBox TxtCountry;
		private System.Windows.Forms.TextBox TxtPhone;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnModify;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnFirst;
		private System.Windows.Forms.Button BtnAbout;
		private System.Windows.Forms.Button BtnLast;
		private System.Windows.Forms.ListBox LstDetails;
		private System.Windows.Forms.ComboBox CBAlfa;
		private System.Windows.Forms.Button BtnShow;
		private System.Windows.Forms.Button BtnAll;
		private System.Windows.Forms.Label label18;
		Form2 f2 = new Form2();
		//==================================================
		//Start Sql Connection String and code
            SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=AddressBook;Integrated Security=true");
			SqlCommand sc;
			DataSet ds = new DataSet();
			SqlDataAdapter sda =new SqlDataAdapter();
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label19;			
		//End Sql Connection String and code
		//==================================================
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnAll = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.CBAlfa = new System.Windows.Forms.ComboBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LstDetails = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAdd
            // 
            this.TxtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdd.Enabled = false;
            this.TxtAdd.Location = new System.Drawing.Point(160, 79);
            this.TxtAdd.Multiline = true;
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(160, 64);
            this.TxtAdd.TabIndex = 8;
            // 
            // TxtPhone
            // 
            this.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPhone.Enabled = false;
            this.TxtPhone.Location = new System.Drawing.Point(160, 248);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(160, 20);
            this.TxtPhone.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(350, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Select Character for get Detail";
            // 
            // BtnAll
            // 
            this.BtnAll.Location = new System.Drawing.Point(472, 48);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(48, 23);
            this.BtnAll.TabIndex = 16;
            this.BtnAll.Text = "All";
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Address";
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(88, 336);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(155, 23);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "A&bout";
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(248, 336);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(75, 23);
            this.BtnLast.TabIndex = 4;
            this.BtnLast.Text = "&Last";
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(7, 312);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtCountry
            // 
            this.TxtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCountry.Enabled = false;
            this.TxtCountry.Location = new System.Drawing.Point(160, 216);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(160, 20);
            this.TxtCountry.TabIndex = 11;
            // 
            // TxtID
            // 
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(160, 280);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(160, 20);
            this.TxtID.TabIndex = 13;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(88, 312);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 376);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(512, 96);
            this.dataGrid1.TabIndex = 18;
            // 
            // CBAlfa
            // 
            this.CBAlfa.DropDownWidth = 80;
            this.CBAlfa.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBAlfa.Location = new System.Drawing.Point(336, 48);
            this.CBAlfa.Name = "CBAlfa";
            this.CBAlfa.Size = new System.Drawing.Size(80, 21);
            this.CBAlfa.TabIndex = 14;
            this.CBAlfa.Text = "Select";
            // 
            // TxtCity
            // 
            this.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCity.Enabled = false;
            this.TxtCity.Location = new System.Drawing.Point(160, 152);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(160, 20);
            this.TxtCity.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(16, 383);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(510, 94);
            this.label19.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(342, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(160, 48);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(160, 20);
            this.TxtName.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Your Self on NET";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Phone";
            // 
            // TxtState
            // 
            this.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtState.Enabled = false;
            this.TxtState.Location = new System.Drawing.Point(160, 183);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(160, 20);
            this.TxtState.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(343, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 277);
            this.label16.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "City";
            // 
            // LstDetails
            // 
            this.LstDetails.Location = new System.Drawing.Point(336, 80);
            this.LstDetails.Name = "LstDetails";
            this.LstDetails.Size = new System.Drawing.Size(184, 277);
            this.LstDetails.TabIndex = 17;
            this.LstDetails.SelectedIndexChanged += new System.EventHandler(this.LstDetails_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "State";
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(168, 312);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "&Modify";
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(248, 312);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(168, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Friend Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(168, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(168, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 22);
            this.label5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(168, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(168, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 2;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(424, 48);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(48, 23);
            this.BtnShow.TabIndex = 15;
            this.BtnShow.Text = "Show";
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(168, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(168, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 60);
            this.label3.TabIndex = 2;
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(8, 336);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnFirst.TabIndex = 3;
            this.BtnFirst.Text = "&First";
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(536, 485);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CBAlfa);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LstDetails);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniper I Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/*[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}*/
		public void Connection_To_Database(string sname,string dname,string uid,string pass)
		{
            try
            {				
				cnn.Open();
				this.FriendList();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
		}
		private void BtnAdd_Click(object sender, System.EventArgs e)
		{
			if(BtnAdd.Text == "&Add")
			{
				BtnAdd.Text = "&Save";
				BtnDelete.Text = "&Cancel";
				this.Enable(true);
				TxtName.Focus();
				this.BlankBox();
			}
			else
			{
				BtnAdd.Text = "&Add";
				BtnDelete.Text = "&Delete";
				this.InsertRec(TxtName.Text,TxtAdd.Text,TxtCity.Text,TxtState.Text,TxtCountry.Text,TxtPhone.Text,TxtID.Text);
				this.Enable(false);	
				this.BlankBox();
				this.FriendList();
			}
		}
		private void BtnShow_Click(object sender, System.EventArgs e)
		{
			LstDetails.Items.Clear();
			if(CBAlfa.Text == "Select")
			{
				//MessageBox.Show("Select AlphaBets form the List");
				CBAlfa.Focus();
			}
			else
			{
				this.SelectedFind(CBAlfa.Text);
			}
			
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
		public void InsertRec(string nm,string add,string ct,string st,string country,string ph,string id)
		{
            try
            {
				string sql = "Insert into AddressBook values('"+ nm +"','"+ add +"','"+ ct +"','"+ st +"','"+ country +"','"+ ph +"','"+ id +"')";
				//MessageBox.Show(sql);
				sc = new SqlCommand(sql,cnn);
				sc.CommandType = CommandType.Text;
				sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}
		public void Enable(bool flag)
		{
			string str;
			foreach(Control ctrl in this.Controls)
			{
				str = Convert.ToString(ctrl.GetType());
				if(str == "System.Windows.Forms.TextBox")
				{
					ctrl.Enabled = flag;
				}
			}
		}

		private void BtnDelete_Click(object sender, System.EventArgs e)
		{
			if(BtnDelete.Text == "&Delete")
			{
				this.Enable(false);
				if(LstDetails.SelectedIndex == -1)
				{
					MessageBox.Show("Oh Sorry u must have to select your friend name before delete");
					LstDetails.Focus();
				}
				else
				{
					DialogResult dr = MessageBox.Show("Hai man r u sure u wana delete record of "+LstDetails.SelectedItem.ToString(),"Delete Record Conformation",MessageBoxButtons.YesNo);
					if(Convert.ToString(dr) == "Yes")
					{
						string query = "delete from addressbook where name = '"+ LstDetails.SelectedItem.ToString() +"'";
						this.ExecQuery(query);
						this.FriendList();
						this.BlankBox();
					}
				}
			}
			else
			{
				BtnAdd.Text = "&Add";
				BtnDelete.Text = "&Delete";
				BtnModify.Text = "&Modify";
				this.Enable(false);
				this.BlankBox();
			}
		}
		
		public void ExecQuery(string sql)
		{
			try
			{
				sc = new SqlCommand(sql,cnn);
				sc.CommandType =  CommandType.Text;
				sc.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		public void FriendList()
		{
			LstDetails.Items.Clear();
			try
			{
				string sql = "select * from AddressBook";
				SqlDataAdapter sda = new SqlDataAdapter(sql,cnn);
				DataSet dtset = new DataSet();
				sda.Fill(dtset,"AddressBook");
				DataTable dt = dtset.Tables["AddressBook"];
				dataGrid1.SetDataBinding(dtset,"AddressBook");
				
				foreach(DataRow dtRow in dt.Rows)
				{
					LstDetails.Items.Add( dtRow["Name"].ToString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		public void SelectedFind(string sr)
		{
			try
			{
				string sql = "select * from AddressBook where name like '"+ sr +"%'";
				//MessageBox.Show(sql);
				SqlDataAdapter sda = new SqlDataAdapter(sql,cnn);
				DataSet dtset = new DataSet();
				sda.Fill(dtset,"AddressBook");
				DataTable dt = dtset.Tables["AddressBook"];
				
				foreach(DataRow dtRow in dt.Rows)
				{
					LstDetails.Items.Add( dtRow["Name"].ToString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void BtnAll_Click(object sender, System.EventArgs e)
		{
			this.FriendList();
			CBAlfa.Text = "Select";
		}

		private void BtnFirst_Click(object sender, System.EventArgs e)
		{
			LstDetails.SelectedIndex=0;
		}

		private void BtnLast_Click(object sender, System.EventArgs e)
		{
			LstDetails.SelectedIndex = LstDetails.Items.Count -1;
		}
		private void BtnModify_Click(object sender, System.EventArgs e)
		{
			if(!(TxtName.Text.Length==0))
			{
				if(BtnModify.Text == "&Modify")
				{
				
					this.Enable(true);
					TxtName.Focus();
					BtnModify.Text = "&Change";
					BtnDelete.Text = "&Cancel";
				}
				else
				{
					BtnModify.Text = "&Modify";
					BtnDelete.Text = "&Delete";
					string query = "update addressbook set address='"+ TxtAdd.Text +"',city='"+ TxtCity.Text +"',state='"+ TxtState.Text +"',country='"+ TxtCountry.Text +"',phone='"+ TxtPhone.Text +"',e_mail_id='"+ TxtID.Text +"' where name like '"+ TxtName.Text +"%'";
					this.ExecQuery(query);
					this.Enable(false);

				}
			}
			else
			{
				MessageBox.Show("U Must have to select person name from the list","Update Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				
			}
		}
		private void LstDetails_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				//SqlDataAdapter sda = new SqlDataAdapter("select * from addressbook where name like '"+ LstDetails.SelectedItem.ToString() +"%'",cnn);
				SqlDataAdapter sda = new SqlDataAdapter("select * from addressbook",cnn);
				DataSet dtset = new DataSet();
				sda.Fill(dtset,"AddressBook");

			//	MessageBox.Show("Table in Database = "+dtset.Tables.Count.ToString());

				DataTable dt = dtset.Tables["AddressBook"];

			//	MessageBox.Show("Fetched Rows = " + dt.Rows.Count.ToString());
				
			//	MessageBox.Show(LstDetails.Items.Count.ToString());
			//	MessageBox.Show("Selected Index = "+LstDetails.SelectedIndex.ToString());
				//DataRow  dr = dt.Rows[0]; 
				DataRow  dr = dt.Rows[LstDetails.SelectedIndex];
				
				TxtName.Text = dr["name"].ToString();
				TxtAdd.Text = dr["address"].ToString();
				TxtCity.Text = dr["city"].ToString();
				TxtState.Text = dr["state"].ToString();
				TxtCountry.Text = dr["country"].ToString();
				TxtPhone.Text = dr["phone"].ToString();
				TxtID.Text = dr["e_mail_id"].ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void BtnAbout_Click(object sender, System.EventArgs e)
		{
			f2.ShowDialog();
		}

		private void BtnExit_Click(object sender, System.EventArgs e)
		{
			DialogResult dr = MessageBox.Show("R u sure u wana quit this application?","Conformation",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
			//DialogResult dr = MessageBox.Show("Su tamare aa program bandh karvo chhe..?","Conformation",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
			if(Convert.ToString(dr)=="Yes")
			{
                Application.Exit();
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{

		}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
	}
}