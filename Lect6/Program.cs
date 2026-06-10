using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lect6
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//c#  არაის აქვს ფიქსირებული ზომა

			//int[] nums = [1,2,3];

			//int[] nums1 = { 1, 2, 3 };


			//int[] nums3 = { 1, 20, 30 };

			//int[] nums4 = new int[3];   // [0,0,0]


			//string[] texts = new string[2];  // [null, null]





			//			დავალება 1
			//შექმენით ერთ განზომილებიანი ორი მასივი.
			//შეავსეთ ორივე მასივი ელემენტებით.
			//გააერთიანე ერთ მასივში ორივე მასივის ელემენტები.
			//დაბეჭდეთ საბოლოოდ მიღებული მასივი.
			//მაგალითად, თუ პირველი მასივის ელემენტების: 1 2 3
			//ხოლო მეორე მასივის ელემენტებია : 4 5 6


			//int[] num1 = [20, 60, 40, 30];
			//int[] num2 = [80, 60, 50, 10, 10];



			//int[] resultArray = new int[num1.Length + num2.Length];  // 9


			//for (int i = 0; i < num1.Length; i++)
			//{
			//	resultArray[i] = num1[i];   // resultArray  [20, 60, 40, 30, 0, 0, 0, 0]

			//}

			//for (int i = 0; i < num2.Length; i++)
			//{
			//	resultArray[num1.Length+i] = num2[i]; 
			//}




			////version 2

			//int index = 0;
			//for (int i = num1.Length; i < resultArray.Length; i++)
			//{ 
			//	resultArray[i]  = num2[index]; 
			//	index++; 
			//}


			//			დავალება 2
			//შექმენით ინტების მასივი და შეავსეთ ელემენტებით. მაგ: 3, 5, -4, 8, 11, 1, -1, 6
			//კონსოლიდან გადმოეცით რაღაც რიცხვი რომელსაც შეინახავთ targetSum ცვლადში.
			//მოძებნეთ მასივში ყველა ის ორი ელემენტი რომლის ჯამიც იქნება targetSum ტოლი და ამწყვილებისგან შექმენით მასივი.
			//დააბრუნეთ ამ ელემენტების წყვილები კონსოლში.
			//2 | P a g e
			//მაგალითად: array = { 3, 5, -4, 8, 11, 1, -1, 6}
			//			targetSum = 7
			//შედეგად უნდა მივიღოთ: resultArray = [[1, 6], [8, -1], [-4, 11]]




			//int[] arr = [3, 5, -4, 8, 11, 1, -1, 6];


			//Console.WriteLine("Enter targetSum");

			//bool isValid = int.TryParse(Console.ReadLine(), out int targetSum);
			//int count = 0;

			//for (int i = 0; i < arr.Length; i++)
			//{  // 5

			//	for (int j = i+1; j < arr.Length; j++)
			//	{
			//		if (arr[i] + arr[j] == targetSum)
			//		{
			//			Console.WriteLine(arr[i] +  "," + arr[j]);
			//			count++;
			//		}
			//	}
			//}


			//int[][] resultArray = new int[count][];   ///     [[],[],[]]

			//int index = 0;

			//for (int i = 0; i < arr.Length; i++)
			//{  // 5

			//	for (int j = i + 1; j < arr.Length; j++)
			//	{
			//		if (arr[i] + arr[j] == targetSum)
			//		{
			//			resultArray[index] = [arr[i], arr[j]];
			//			index++;
			//		}
			//	}
			//}






			//stundents [ [20,50,60],[0,50,60,30,80,80], [50,60 ]  ] 




			//[20, 50, 60]

			//int[][] students =
			//   	[
			//    [20, 50, 60],
			//	[0, 50, 60, 30, 80, 80],
			//	[50, 60],
			//	[20, 50, 60],
			//	[0, 50, 60, 30, 80, 80],
			//	[50, 60]
			//    ];

			//foreach (var row in students)
			//{
			//	int[] nums = row;

			//	int sum = 0;

			//	for (int i = 0; i < nums.Length; i++)
			//	{
			//		//20,
			//		sum += nums[i];    // 130
			//	}
			//	Console.WriteLine(sum / nums.Length);

			//}



			//int[][] students = 
			//[
			//	[20, 50, 60], 
			//	[0, 50, 60, 30, 80, 80], 
			//	[50, 60], 
			//	[20, 50, 60], 
			//	[0, 50, 60, 30, 80, 80], 
			//	[50, 60]
			//];


			//foreach (var row in students)
			//{
			//	int[] nums = row;   // [20, 50, 60]

			//	int sum = 0;

			//	for (int i = 0; i < nums.Length; i++)
			//	{
			//		//20,
			//		sum += nums[i];    // 130
			//	}
			//	Console.WriteLine(sum / nums.Length);

			//}






			//string 

			//value type    vs    referance  type




			//int x = 5;
			//int y = x;

			//Console.WriteLine(x + " " + y);  // 5   5  
			//y++;

			//Console.WriteLine(x + " " + y);  // 5   6




			//int[] arr1 = [20, 60, 30040];
			//int[] arr2 = arr1;


			//arr1[0] = 20000;


			//  arr1    // 20000, 60, 30040
			//  arr2    // 20000, 60, 30040








			//string   referance     immutable


			string str1 = "Hello";

			str1 = "     Ehhlo1     ";



			Console.WriteLine(str1[0]);
			///  "E"


			foreach (var item in str1)
			{
				Console.WriteLine(item);	
			}



			Console.WriteLine(str1.ToLower());
			Console.WriteLine(str1.ToUpper());
			Console.WriteLine(str1.Trim());


			Console.WriteLine(str1.EndsWith("h"));    // false

			Console.WriteLine(str1.Contains("l"));  // true


		}
	}
}