using Lect10.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10.Models
{
	//Giorgi,Beridze,25,g.beridze @email.com,599123456

	//overload  - გადატვირთვა 
	internal class User  : Person
	{
		public string Phone { get; set; }

		public string Email { get; set; }

		public string UserName{ get; set; }

		private string _password;
		public string Password {
			get
			{
				return _password;
			}

			set 
			{
				if(value.Length < 8) {
					Console.WriteLine("Password is too short");
				}
				_password = value;
			}
		}

		public Role Role { get; set; }

		public User(string userName)
		{
			UserName = userName;
		}
		public User(string userName, string password)
		{
			Password = password;
		}
		public User() { }



		public void Print()
		{
			Console.WriteLine($"Name: {FirstName} Surname: {LastName} Age: {Age} Phone: {Phone} Email: {Email} Username: {UserName} Password: {Password} Role: {Role}");
		}
	}






}
