using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			theScreen.Text = "1";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			theScreen.Text = "4";
		}

		private void value2_Click(object sender, EventArgs e)
		{
			theScreen.Text = "2";
		}

		private void value3_Click(object sender, EventArgs e)
		{
			theScreen.Text = "3";
		}

		private void value5_Click(object sender, EventArgs e)
		{
			theScreen.Text = "5";
		}

		private void value6_Click(object sender, EventArgs e)
		{
			theScreen.Text = "6";
		}

		private void value7_Click(object sender, EventArgs e)
		{
			theScreen.Text = "7";
		}

		private void value8_Click(object sender, EventArgs e)
		{
			theScreen.Text = "8";
		}

		private void value9_Click(object sender, EventArgs e)
		{
			theScreen.Text = "9";
		}

		private void value0_Click(object sender, EventArgs e)
		{
			theScreen.Text = "0";
		}

		private void result_Click(object sender, EventArgs e)
		{
			theScreen.Text = "CALCULATING";
		}
	}
}
