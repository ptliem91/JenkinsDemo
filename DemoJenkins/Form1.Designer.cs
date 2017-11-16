namespace DemoJenkins
{
	partial class Form1
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
			this.lbl_DateNow = new System.Windows.Forms.Label();
			this.lbl_DateNow1 = new System.Windows.Forms.Label();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_DateNow
			// 
			this.lbl_DateNow.AutoSize = true;
			this.lbl_DateNow.Location = new System.Drawing.Point(103, 54);
			this.lbl_DateNow.Name = "lbl_DateNow";
			this.lbl_DateNow.Size = new System.Drawing.Size(55, 13);
			this.lbl_DateNow.TabIndex = 0;
			this.lbl_DateNow.Text = "Date Now";
			// 
			// lbl_DateNow1
			// 
			this.lbl_DateNow1.AutoSize = true;
			this.lbl_DateNow1.Location = new System.Drawing.Point(103, 117);
			this.lbl_DateNow1.Name = "lbl_DateNow1";
			this.lbl_DateNow1.Size = new System.Drawing.Size(55, 13);
			this.lbl_DateNow1.TabIndex = 1;
			this.lbl_DateNow1.Text = "Date Now";
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Location = new System.Drawing.Point(106, 164);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(0, 13);
			this.lbl_Name.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lbl_Name);
			this.Controls.Add(this.lbl_DateNow1);
			this.Controls.Add(this.lbl_DateNow);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_DateNow;
		private System.Windows.Forms.Label lbl_DateNow1;
		private System.Windows.Forms.Label lbl_Name;
	}
}

