using Lect11.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11.Models
{
	internal class Employee 
	{
		public Employee() { }
		public Employee(string name, string lastName, DateTime birthBay,  Contacts contacts, Country country, Gender gender)
		{
			Name = name;
			LastName = lastName;
			BirthBay = birthBay;
			Country = country;
			Gender = gender;
			Contacts = contacts;
		}



		public string Name { get; set; }
		public string LastName { get; set; }

		public DateTime BirthBay { get; set; }

		public Country Country { get; set; } // 

		public Gender Gender { get; set; }


		public Contacts Contacts { get; set; }



		public int GetAge()
		{
			if (DateTime.Now.DayOfYear < BirthBay.DayOfYear)
				return DateTime.Now.Year - BirthBay.Year - 1;
			else 
				return DateTime.Now.Year - BirthBay.Year;
		}



		//9.შექმენით მეთოდი გარეთ ან რამე კლასში რომელიც მიიღებს ორ
		//პარამეტრს, Employ[] მასივს და ქვეყანას,გადაივლის ყოველ ელემენტზე და
		//	დაგვიბეჭდავს ისეთ Employ - იებს რომლებსაც ეგ ქვეყანა აქვთ
		//	Countryფროფერთიში შენახული.


		public static void FilterEmployee(Employee[] emps, Country country)
		{
			foreach (var item in emps)
			{
				if(item.Country == country)
				{
					Console.WriteLine(item);
				}
			}
		}

		public override string? ToString()
		{
			return $"Name : {Name}, LastName : {LastName}, Age : {GetAge()}";
		}
	}
}
