using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10_1.Models
{
	internal class Manager : Employee
	{

		public override void Printinfo()
		{
			base.Printinfo();
			Console.WriteLine(Sallary);
		}
	}
}



//ovveride - გადაწერა გადაკეთება 