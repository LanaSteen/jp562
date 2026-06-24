using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10_1.Models
{
	internal class Student : Person
	{
		public int Grade { get; set; }
		public Faculty Faculty { get; set; }

	}



	public enum Faculty
	{
		IT,
		Bussiness
	}
}
