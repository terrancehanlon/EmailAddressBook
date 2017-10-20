using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailAddressBook
{
	public partial class Form2 : Form
	{
		
			string value; //used to gain access to passed string from form one

	
	public Form2(string str)
		{
			value = str;
			InitializeComponent(); //needed to show items in form
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			textBox1.Text = value; //setting textbox1 text to the passed string value from form1
		}
	}
}
