﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoJenkins
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbl_DateNow.Text = DateTime.Now.ToLongDateString();
			lbl_DateNow1.Text = DateTime.Now.ToLongTimeString();
			lbl_Name.Text = "Kanel";
		}
	}
}
