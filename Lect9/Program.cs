namespace Lect9
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//შექმენით მანქანის კლასი მოცემული მონაცემებისთვის
			//BMW, M5,2023,105000,Black
			//დაწერეთ მეთოდები რომლებიც:
			//დაბეჭდავს მთლიანად მაქანის ინფორმაციას,
			//გამოთვლის ძვირია თუ არა მანქანა. ძვირია თუ ფასი 100 000 ზე მეტია
			//დაადგენს მანქანა არის თუ არა  კონკრეტული მოდელის 
			//დააბრუნებს მანქანის ფერს

			//შექმენით 5 ობიექტი ამ მანქანის კლასისდან 

			//შეინახეთ არაიში და ყველა მანქანის შესახებ ინფორმაცია გამოიტანეთ კონსოლში


			int x = 5;

			Car car = new("bmw", "M5", 2023, 105000, "Black");

			car.Manufacturer = "bMW";
			car.Model = "M5";
			car.Year = 2025;
			car.Price = 2000;
			car.Color = "Black";

			Console.WriteLine(car.Year);

			Car car2 = new();

			car2.Manufacturer = "bMW";
			car2.Model = "M5";
			car2.Year = 2025;
			car2.Price = 2000;
			car2.Color = "Black";



			Car[] cars = [ car, car2 ];

			foreach (var item in cars)
			{
				item.Print();
			}



			//"id": 0,
			// "name": "string",
			// "price": 0,
			// "nuts": true,
			// "image": "string",
			// "vegeterian": true,
			// "spiciness": 0,
			// "category": "string"


			Product product = new Product();
			product.Id = 0;
			product.Name = "rame";
			product.Price = 50;
			product.Nuts = true;
			product.Image = "link";
			product.Vegeterian = true;
			product.Spiciness = 0;
			product.Category = "Soups";


			Product product2 = new Product();
			product2.Id = 0;
			product2.Name = "rame2";
			product2.Price = 500;
			product2.Nuts = true;
			product2.Image = "link2";
			product2.Vegeterian = true;
			product2.Spiciness = 0;
			product2.Category = "Soups2";


			Product[] products =  [ product, product2 ];

			foreach (var item in products)
			{
				item.Printinfo();
				Console.WriteLine(item.IsVegeterianAndNuts());
			}
		}
	}



}






















