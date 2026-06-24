using System;
using System.Collections.Generic;
using System.Text;


//oop  - object oriented programming
//1. ინკაფსულაცია
//2. მემკვიდრეობა
//3. პოლიმორიზმი

namespace Lect9
{
	//კონსტრუქტორი

	internal class Car
	{




		public Car()
		{
		}

		public Car(string manufacturer, string model, int year, decimal price, string color)
		{
			Manufacturer = manufacturer;
			Model = model;
			Year = year;
			Price = price;
			Color = color;
		}




		//public string Manufacturer;  // field    " " 
		public string Manufacturer;

		///  property
		public string Model;

		private int _year;  //2025
		public int Year {
			get { return _year; }  // 2025


			set 
			{
				if(value < 0 || value > DateTime.Now.Year)
				{
					Console.WriteLine("invalid year");
					return;
				}
				_year = value; // 2025
			}
		
		}      // -5 2027


		public int MyProperty { get; set; }




		//full property  --   propfull

		private int _age; ///  

		public int Age
		{
			get { return _age; }
			set { if(value > 0) _age = value; else Console.WriteLine("invalid age"); }
		}




		public decimal Price { get; set; }
		public string Color { get; set; }


		public void Print()
		{
			Console.WriteLine($"{Manufacturer} {Model} {Year} {Price} {Color}");
		}


		public bool IsExpensive()
		{
			//if(Price > 100000) { return true; }
			//return false;

			return Price > 100000;
		}


		public bool IsModel(string model)
		{
			return Model == model;
		}



		public string GetColor()
		{
			return Color;
		}


	}
}



//BMW, M5,2023,105000,Black