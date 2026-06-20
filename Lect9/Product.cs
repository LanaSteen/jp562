using System;
using System.Collections.Generic;
using System.Text;

namespace Lect9
{

	public class Product
	{
		public int Id;
		public string Name;
		public double Price;
		public bool Nuts;
		public string Image;
		public bool Vegeterian;
		public int Spiciness;
		public string Category;


		public void Printinfo()
		{
			Console.WriteLine($"{Id} {Name} {Price} {Nuts} {Image} {Vegeterian} {Spiciness} {Category}");
		}


		public bool IsVegeterianAndNuts()
		{
			//if(Vegeterian && Nuts) {  return true; }
			//return false;

			return Vegeterian && Nuts;
		}


	}


}
