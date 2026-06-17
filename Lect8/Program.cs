namespace Lect8
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw
			//დავალება 1
			//დაწერეთ ფუნქცია რომელიც მიიღებს ორ ინტ პარამეტრს და
			//აიყვანს პირველ რიცხვ მეორე რიცხვის ხარისხში.
			//მაგალითად:
			//		input: 3 და 2
			//result: 3 - ის კვადრატი 9
			//სხვა მაგალითი:
			//input: 2 და 4
			//result: 2 - ის მეოთხე ხარისხში ანუ 2 * 2 * 2 * 2 იქნება 16


			//Console.WriteLine(power(2, 3)); //8


			////2*2*2 // 8


			//int power(int num1, int num2)
			//{
			//	int result = num1;
			//	for (int i = 1; i < num2; i++)
			//	{
			//		result *= num1;  // 8
			//	}

			//	return result;
			//}





			//			დავალება 2
			//დაწერეთ ფუნქცია რომელიც მიიღებს ინტ რიცხვს დაგვიბრუნებს bool
			//მნიშვნელობას იმის მიხედვით რიცხვი მარტივია თუ არა: ანუ იყოფა მარტო
			//საკუთარ თავზე და 1 ზე.
			//მაგ: input: 31 return: true console output: 31 მარტივი რიცხვია
			//2 | P a g e
			//მაგ2: input: 6 return: false console output: 6 არ არის მარტივი რიცხვი

			//6  5 4  3 2


			//bool IsPrime(int num)
			//{

			//	for (int i = 2; i < num; i++)
			//	{
			//		if(num%i == 0)
			//		{
			//			return false;
			//		}
			//	}

			//	return true;

			//}


			//Console.WriteLine("Ennter numebe");
			//bool isValid = int.TryParse(Console.ReadLine(), out int userNum);

			//Console.WriteLine(IsPrime(userNum) ? "primitive" : "conpose" );











			//			დავალება 5
			//დაწერეთ რეკურსიული მეთოდი რომელიც გამოთვლის
			//ნებისმიერი რიცხვის ხარისხს, კონსოლიდან შემოიტანეთ რიცხვი და ხარისხი,
			//გადაეცით თქვენ რეკურსიულ მეთოდს და დააბრუნეთ მისი ხარისხი.
			//მაგ:
			//inpt num: 4
			//power: 3
			//console output: 4 –ი ხარისხად 3 არის: 64

			//2 1 //  2


			//2 3
			//2 * (2 , 2) //  8
			//2 *  (2  1) // 4


			//int Pow(int num, int powerer)
			//{
			//	if(powerer == 1)
			//	{
			//		return num;
			//	}

			//	return num * Pow(num, powerer - 1);
			//}











			//			დავალება 3
			//დაწერეთ რეკურსიული მეთოდი რომელიც მიიღებს რაიმე სტრინგს
			//კონსოლიდან და დაგვიბრენუბს true ან false იმის მიხედვით არის
			//თუ არა სტრინგი პალიდრომი.
			//განმარტება: პალიდრომი წარმოადგენს ისეთ ტექსტ, რომელიც რომელი
			//მხრიდანაც არ უნდა წავიკითხოთ, ის ერთნაირად იკითხება.
			//მაგ: inp: stepets console output: stepets არის პალინდრომი.
			//მაგ2: inp: noon console output: noon არის პალინდრომი.


			//"noon"
			//"aiia"


			//"stepon1nopeks"
			//"teponnopet"
			//"eponnope"
			//nn

			//"1"


			//bool IsPailndrome(string pal )
			//{
			//	if(pal.Length < 2)
			//	{
			//		return true;
			//	}

			//	if (pal[0] != pal[pal.Length - 1])
			//	{
			//		return false;
			//	}

			//	string middle = pal.Substring(1, pal.Length-2);

			//	return  IsPailndrome(middle);
			//}

			//Console.WriteLine(IsPailndrome("1noon"));








			//Stack overflow error
			//print();

			//string print()
			//{
			//	return print();
			//}


			#endregion


			#region todo
			//challange
			//factorial    1! 

			//5 * 4 * 3 * 2* 1 = 125

			//int Findfactorial(int num)
			//{
			//	if (num == 1)
			//	{
			//		return 1;
			//	}



			//}


			#endregion



			//Random rand = new Random();
			//rand.Next();

			//Program program = new Program();
			//program.Print2();



			//Program.Print();
			//Console.WriteLine("dsdfhg");
		
		
		
		    //User user = new User();  // {}

			//User user = new();  // {}

			var user = new User();

			user.Name = "John";
			user.Age = 50;


			var user2 = new User();

			user2.Name = "jane";
			user2.Age = 30;


			int x = 5;


			Console.WriteLine(user.Name + " " + user.Age);
			Console.WriteLine($"{user.Name} {user.Age}");

			//int[] arr = [20,50]

			//	string[]
			//	bool[]

			//User[] users = new User[2];
			//users[0] = user;

			User[] users = [user, user2];


			foreach (var item in users)																															
			{
				item.PrintfullInfo();
				//Console.WriteLine($"{item.Name} {item.Age}");
			}

			User.print3();
		}

		//method vs function

		//Console.Writeline()

		//  static void Print() {

		//	Console.WriteLine("hi");
		//}

		// void Print2()
		//{

		//	Console.WriteLine("hi");
		//}



		//class ჩვენი type

		//user {name, age }
		//user { name, age, phone }

		



	}


	class User
	{
		public string Name;
		public int Age;

		public void PrintfullInfo()
		{
			Console.WriteLine(Name + " " + Age);
		}

		public static void print3()
		{
			Console.WriteLine("ok");
		}
}
}







//o o p   =  ობიექტზე ორიენტირებული პროგრამირება 

//2015 es6 js   oop


//function print() { }