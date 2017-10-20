using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailAddressBook
{
	class PersonEntry
	{
		string phoneNumber;
		string personname;
		string email;


		public PersonEntry(string phone, string name_, string email_)
		{

			personname = name_;
			phoneNumber = phone;

			email = email_;

		}

		public string Name
		{
			get
			{
				return personname;
			}
		}

		public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

		public string Email { get { return email; } set { email = value; } }
	
		public override string ToString()
		{
			return "Phone Number: " + phoneNumber + " Name: " + personname + " email: " + email;
		}
		

		}
	}	

