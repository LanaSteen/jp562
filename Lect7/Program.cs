using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Lect7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string x = "text";
			//string y = "text";
			//Console.WriteLine(x==y);  // true    == 


			//int[] arr1 = [20, 30, 60];
			//int[] arr2 = [20, 30, 60];
			//Console.WriteLine(arr1==arr2);  // false  -- referance type


			//string text = "hello,world";

			//Console.WriteLine(text.Substring(6,5));


			//Console.WriteLine(text.Contains("g")); // Returns true
			//Console.WriteLine(text.IndexOf("g")     ); // Returns index of 'g' -1 

			////Console.WriteLine(text.Replace("h", "H"));
			//Console.WriteLine(text.Replace("hello", "bye"));


			//Console.WriteLine(text.Split(","));   // ["hello","world"]

			//string[] words = text.Split(",");



			//Random rand = new();
			//StringBuilder sbtext = new StringBuilder();

			//Console.WriteLine(sbtext);

			//sbtext.Append("Hi");

			//sbtext.AppendLine("fdfgh");
			//sbtext.AppendJoin("dsa0 ", "dsa1 ", "dsa2 ");


			//StringBuilder text2 = new StringBuilder();

			//text2.Append("Hi");

			//string tetx3 = "Hi";

			//Console.WriteLine(tetx3 == text2.ToString()); // true




			#region hw


			//1.შექმენით jagged array სადაც: თითოეულ სტუდენტს აქვს 
			//	სხვადასხვა რაოდენობის ქულა. იპოვეთ თითოეულის 
			//	საშუალო ქულა.


			//int[][] students =
			//[
			//	[ 80, 90, 85 ],
			//	[ 75, 88 ],
			//	[ 92, 95, 91, 89 ]
			//];


			//for (int i = 0; i < students.Length; i++)
			//{   //[ 80, 90, 85 ]
			//	int sum = 0;
			//	for (int j = 0; j < students[i].Length; j++)
			//	{
			//		sum += students[i][j];

			//	}

			//	Console.WriteLine(sum/ students[i].Length);
			//}






			//2.შექმენით რენდომული 4 ნიშნა პასკოდების არაი(10 წევრი).
			//	მომხმარებელს შემოაყვანინეთ კოდი და თუ რომელიმეს 
			//	დაემთხვა არაიში დაუბეჭდეთ “Correct” თუ არა და “Wrong”.

			//Random rand = new();


			//int[] passcodes = new int[10];

			//for (int i = 0; i < passcodes.Length; i++)
			//{
			//	passcodes[i] = rand.Next(1000,10000);
			//}

			//Console.WriteLine("enter passcode");
			//bool isValid = int.TryParse(Console.ReadLine(), out int userInput);

			//bool isMatch = false;

			//if (isValid)
			//{
			//	for (int i = 0; i < passcodes.Length; i++)
			//	{
			//		if (userInput == passcodes[i])
			//		{

			//			isMatch = true;
			//			break;
			//		}

			//	}
			//}
			//Console.WriteLine(isMatch ? "correct" : "inccorect");




			//3.შექმენით int-ების(მათ შორის ნეგატიური რიცხვებიც) მასივი.
			//	იპოვეთ მინიმალური და მაქსიმალური რიცხვები
			//	(არ გამოიყენოთ არაის მეთოდები).


			//int[] numbers = [3, 5, -4, 8, 11, 1, -1, 6];
			//int min = numbers[0]; // 3
			//int max = numbers[0]; // 3

			//foreach (var item in numbers)
			//{
			//	if(item < min)
			//	{
			//		min = item;
			//	}

			//	if (item > max)
			//	{
			//		max = item;
			//	}
			//}


			//Console.WriteLine(min + " " + max );




			//4.შექმენით სტრინგების მასივი და კონსოლში დაბეჭდეთ ყველა 
			//	ელემენტის ყველა სიმბოლო(არ გამოიყენოთ არაის მეთოდები).


			//string[] words = ["hello", "world", "example"];


			//foreach (var item in words)
			//{
			//	foreach (var symbol in item)
			//	{
			//		Console.WriteLine(symbol);
			//	}
			//}



			//5.შექმენით იმეილების მასივი
			// და დაადგინეთ ყველა ელემენტი თუ შეიცავს @ სიმბოლოს. 
			//	(არ გამოიყენოთ არაის და სტრინგის ჩაშენებული მეთოდები).


			//string[] emails = ["fdfddfd@fdf", "Sdsd@fdfd"];

			//bool validEmail = false;
			//foreach (var email in emails)
			//{
			//	foreach (var symbol in email)
			//	{
			//		if(symbol == '@')
			//		{
			//			validEmail = true;
			//		}
			//		Console.WriteLine(validEmail ? "valid" : "not valid");
			//	}
			//}





			#endregion region



			Console.WriteLine("hello");


			// ფუნქციები 
			//მეთოდები ობიექტში ან კლასში ჩასენუნლი ფუნქციები




			//ლოკალური ფუნქცია 
			//x = print();
			//print();
			//void print() 
			//{
			//	Console.WriteLine("hi");
			//}

			//Console.WriteLine(sum()); // " 5 + 5"
			//string sum()
			//{
			//	return " 5 + 5";
			//}




			//S R P   - ერთი პასუხისმგებლობის პრინციპი

			//  Console.WriteLine(sum(5, 6)); ;
			//  int sum(int x, int y) 
			//{
			//	return x + y;
			//}



			//არაიში შეინახავს რენდომულ
			//რიცხვებს და მერე დაბეწდე ეს რიცხვები

			int[] nums = new int[10];
			FillArray(nums);
			PrintArray(nums);

			int[] FillArray(int[] numbers)
			{
				Random rnd = new Random();

				for (int i = 0; i < numbers.Length; i++)
				{
					numbers[i] = rnd.Next(0, 100);

					//Console.WriteLine(numbers[i]);
				}

				return numbers;
			}



			void PrintArray(int[] numbers)
			{
				foreach (var item in numbers)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
