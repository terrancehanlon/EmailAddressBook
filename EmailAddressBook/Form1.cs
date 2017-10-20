using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EmailAddressBook
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private PersonEntry person;
		private List<PersonEntry> storage = new List<PersonEntry>();
		
		
	
		
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			Object q = (PersonEntry)listBox1.SelectedItem;  //Made sure that right toString method was being called by casting the selected list box item to PersonEntry from Object
			Form2 form = new Form2(q.ToString()); //Uses overrided constructor to pass the ToString string of ther person object
			form.ShowDialog();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StreamReader file = new StreamReader("email.txt");

			string line = file.ReadLine();

			/*reads file and splits into array, adds new person object to created list with 
			 * each iteration. */

			while (line != null)
			{
				string[] x = line.Split(',');
				string num = x[0];
				string name = x[1];
				string email = x[2];

				person = new PersonEntry(num, name, email);
				storage.Add(person);
				//string y = person.getName();

				listBox1.DisplayMember = "Name"; //displays the property Name in PersonEntry class


				listBox1.Items.Add(person); //adds the person object created to the listbox 
				line = file.ReadLine();
			}
		}
	}
}
