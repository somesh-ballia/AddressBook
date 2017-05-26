using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
namespace AddressBook
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.LinkLabel MailMe;
		private System.Windows.Forms.LinkLabel ProgInfo;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;
		string msg;
		int count;

		public Form2()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.MailMe = new System.Windows.Forms.LinkLabel();
			this.ProgInfo = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// MailMe
			// 
			this.MailMe.BackColor = System.Drawing.SystemColors.Desktop;
			this.MailMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MailMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MailMe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.MailMe.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.MailMe.LinkColor = System.Drawing.Color.Gold;
			this.MailMe.Location = new System.Drawing.Point(152, 184);
			this.MailMe.Name = "MailMe";
			this.MailMe.Size = new System.Drawing.Size(208, 24);
			this.MailMe.TabIndex = 0;
			this.MailMe.TabStop = true;
			this.MailMe.Text = "Mail Me : hpatel4u@hotmail.com";
			this.MailMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MailMe.VisitedLinkColor = System.Drawing.Color.Lime;
			this.MailMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MailMe_LinkClicked);
			// 
			// ProgInfo
			// 
			this.ProgInfo.BackColor = System.Drawing.Color.IndianRed;
			this.ProgInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ProgInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.ProgInfo.LinkColor = System.Drawing.Color.Lime;
			this.ProgInfo.Location = new System.Drawing.Point(0, 184);
			this.ProgInfo.Name = "ProgInfo";
			this.ProgInfo.Size = new System.Drawing.Size(152, 24);
			this.ProgInfo.TabIndex = 1;
			this.ProgInfo.TabStop = true;
			this.ProgInfo.Text = "Programmer Info";
			this.ProgInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ProgInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProgInfo_LinkClicked);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Violet;
			this.label1.Image = ((System.Drawing.Bitmap)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(20, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 74);
			this.label1.TabIndex = 2;
			this.label1.Text = @"Hi My Self Hiten Patel This program is created for storing Your Friend  information in your Database & when u wana get it u can. U can use this project for you knowledge but can not sale it & if u wana sale it then your own risk u can sale it. If u have any doubt about this code or project then contact me at Surat PHONE : 91 261 8557487 and also mail me.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(360, 205);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.ProgInfo,
																		  this.MailMe});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About AddressBook";
			this.TransparencyKey = System.Drawing.Color.Yellow;
			this.Disposed += new System.EventHandler(this.Form2_Disposed);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void MailMe_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:hpatel4u@hotmail.com");
		}

		private void ProgInfo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore","http://www.geocities.com/hpatel4u");
		}

		private void Form2_Load(object sender, System.EventArgs e)
		{
		
		}
		private void Form2_Disposed(object sender, System.EventArgs e)
		{
			this.Hide();
		}
	}
}
