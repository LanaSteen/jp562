using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10_1.Models
{
	internal abstract class Person
	{
		public string Name { get; set; }
		public string LastName { get; set; }

		public int Age { get; set; }


		public virtual void Printinfo() 
		{
			Console.WriteLine($"Name: {Name}, LastName: {LastName}, Age: {Age}");
		}


	}
}
