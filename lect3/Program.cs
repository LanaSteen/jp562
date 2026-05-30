using System.Runtime.InteropServices.Marshalling;
using System.Transactions;

namespace lect3
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//+ - / * % 
			// > < >= <= == != ! 
			//&& ||


			//Console.WriteLine(5>=6);

			//&&  and  ||   or 

			//?:   ternary operator   condition ? true : false


			Console.WriteLine(5 > 6 ? "metia" : (5 == 5 ? "metia" : "metia"));


			// +  

			Console.WriteLine("gamarjoba" + " " + "metia");

			//String 

			//სტრინგის ინტერპოლაცია
			//`${ }   ${}`



			//$" {}  {}   ";

			//Console.WriteLine($"{true} {false}");



			//მომხმარებელმა შემოიყვანოს რიცხვი თუ ეს რიცხვი
			//მეტია 100 ზე დაბეჭდე კონსოლსი მეტია


			//Console.WriteLine("enternumber");
			//string rame = Console.ReadLine();
			//int num = int.Parse(rame);
			//if (num == 0) 
			//{
			//	Console.WriteLine("მეტია");
			//}





			//			დაწერეთ C# Sharp პროგრამა, რომლითაც მომხმარებელი
			//			შეიყვანს ამომრჩევლის ასაკს და პროგრამა განსაზღვრავს,
			//			აქვს თუ არა მას არჩევნებზე ხმის მიცემის უფლება.
			//შესაყვანი სატესტო მონაცემი: 18
			//მოსალოდნელი შედეგი: გილოცავ! ხმის მიცემის უფლება გაქვთ.
			//–––––––––––––––––––––––
			//შესაყვანი სატესტო მონაცემი: 15
			//მოსალოდნელი შედეგი: სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ


			//Console.WriteLine("enter your age");


			//string ageStr = Console.ReadLine();    // "50"  "dssdsd"


			//bool isValid = int.TryParse(ageStr, out int age );

			//if (age >=18 && isValid)
			//{
			//	Console.WriteLine("you can vote");

			//}
			//else
			//{
			//	Console.WriteLine("you can not vote");
			//}




			//დაწერეთ C# პროგრამა, რომელიც დაადგენს სამ რიცხვს შორის უდიდესს.


			//int num1 = 2;
			//int num2 =5;
			//int num3 =64;


			//if (num1> num2 && num1 > num3)
			//{
			//	Console.WriteLine(num1 + "  greates");
			//}
			//else if (num2 > num3 && num2 > num1)
			//{
			//	Console.WriteLine(num2 + "  greates");
			//}
			//else if (num3 > num1 && num3 > num2)
			//{
			//	Console.WriteLine(num3 + "  greates");
			//}

			//Console.WriteLine(num1 > num2 && num1>num3 
			//	? $"{num1} metiaa" 
			//	: (num2>num1 && num2>num3 
			//	? $"{num2} metiaa" 
			//	: $"{num3} metiaa") );


			//დაწერეთ C# პროგრამა ორი მოცემული მთელი რიცხვის ჯამის გამოსათვლელად.
			//თუ ეს ორი რიცხვი ერთნაირია, მაშინ დააბრუნეთ გასამმაგებული მათი ჯამი.


			//int num1 = 2;
			//int num2 = 2;

			//?:
			//if (num1 == num2 )
			//{
			//	//int result = (num1 + num2) * 3;
			//	Console.WriteLine((num1 + num2) * 3);
			//}
			//else
			//{
			//	Console.WriteLine(num1 + num2);
			//}


			//Console.WriteLine(num1==num2? (num1+num2)*3 : num1 + num2);




			//int day = 2;


			//if (day == 1)
			//{
			//	Console.WriteLine("Monday");
			//}
			//else if (day == 2)
			//{
			//	Console.WriteLine("Tuesday");
			//}
			//else
			//{
			//	Console.WriteLine("Unknown");
			//}


			//switch (day)
			//{
			//	case 1:
			//		Console.WriteLine("Monday");
			//		break;
			//	case 2:
			//		Console.WriteLine("Tuesday");
			//		break;
		
			//	default:
			//		Console.WriteLine("Unknown");
			//		break;
			//}


			// როცა გვაქვს ჩამონათვალი უნდა გამოვიყენოთ სვიჩი



			//მომხმარებელმა შემოიყვანოს ქულა 
			//და თუ არის 90+
			//  	მშინ "A"
			//	70 90   "B"
			//	50 70   "C"
			//	        "D"



			//იუზერმა შემოიყვანოს "admin" ან "guest" 
			//	"you hav full access"
			//	"you have hulf access"
			




		}
	}
}
