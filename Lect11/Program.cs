
using Lect11.Enums;
using Lect11.Helpers;
using Lect11.Models;


namespace Lect11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1.შექმენით enum Country, ჩაამატეთ მასში 4 ქვეყნის დასახელება.
			//2.შექმენით enum Gender, ჩაამატეთ მასში მნიშვნელობები.
			//3.შექმენით enum Contacts ჩაამატეთ შიგნით მასში.მაგ ტელეფონი, მეილი, ფაქსი
			//4.შექმენით Employ კლასი რომელსაც ექნება ზემოთ შექმნილი enum-ების propertebi და პლიუს თავისიფროფერთები: name, surname, dateofbirth(datetime)
			//5.Employ კლასს ჩაუმატეთ პარამეტრიანი კონსტრუქტორი რომელიც ყველა ფროფერთის შეავსებს.
			//6.Employ კლასს ჩაუმატეთ მეთოდი რომელიც გამოთვლის და დაგვიბრუნებს ასაკს.
			//7.შექმენით Employ კლასის 8 ინსტანსი, რომლებსაც ყოველ ორს ერთიდაიგივე ქვეყანა ექნება.
			//8.შეინახეთ ეს ობიექტები Employ[] employs = new Employ[8] ელემენტიან მასივში.
			//9.შექმენით მეთოდი გარეთ ან რამე კლასში რომელიც მიიღებს ორ პარამეტრს, Employ[] მასივს და ქვეყანას, გადაივლის ყოველ ელემენტზე და დაგვიბეჭდავს ისეთ Employ-იებს რომლებსაც ეგ ქვეყანა აქვთ Countryფროფერთიში შენახული.



			//Employee emp = new Employee(,);


			Employee[] employs = new Employee[8] {

			 new Employee("John", "Smith", new DateTime(1990, 3, 15), Contacts.Email, Country.UnitedStates, Gender.Male),
			 new Employee("Anna", "Johnson", new DateTime(1985, 7, 22), Contacts.Mobile, Country.UnitedStates, Gender.Female),
			 new Employee("Jhon", "Doe", new DateTime(1980, 5, 20), Contacts.Mobile, Country.Georgia, Gender.Male),
			 new Employee("Maria", "Garcia", new DateTime(1992, 11, 2), Contacts.Email, Country.Georgia, Gender.Female),
			 new Employee("David", "Brown", new DateTime(1978, 9, 10), Contacts.Mobile, Country.France, Gender.Male),
			 new Employee("Elena", "Ivanova", new DateTime(1988, 4, 18), Contacts.Email, Country.UnitedKingdom, Gender.Female),
			 new Employee("Michael", "Williams", new DateTime(1995, 12, 1), Contacts.Mobile, Country.UnitedKingdom, Gender.Male),
			 new Employee("Sophie", "Martin", new DateTime(1983, 6, 25), Contacts.Email, Country.France, Gender.Female)

			};

			Employee.FilterEmployee(employs, Country.Georgia);

			//ArrayHelper.PrintArray(employs);


			int[] ints = [20, 60, 3];
			//ArrayHelper.PrintArray(ints);

			string[] strs = ["fgf", "gfg"];
			//ArrayHelper.PrintArray(strs);



			ArrayHelper.PrintArrayGen<int>(ints);
			ArrayHelper.PrintArrayGen(ints);
			ArrayHelper.PrintArrayGen(strs);
			ArrayHelper.PrintArrayGen<Employee>(employs);
		}
	}
}
