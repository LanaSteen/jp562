namespace Lect5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw

			//			გააკეთე კონსოლიდან შემოყვანილი რიცხვის
			//			გამრავლების ტაბულის ერთი ბლოკი. (ათის ნამრავლის ჩათვლით)
			//შესაყვანი სატესტო მონაცემი: 13
			//მოსალოდნელი შედეგი:



			//Console.WriteLine("Enter number");

			//bool isValid = int.TryParse(Console.ReadLine(), out int num);
			//if (isValid)
			//{
			//	for (int i = 0; i <= 10; i++)
			//	{
			//		Console.WriteLine($"{num} * {i} = {num*i}");
			//	}
			//}




			//  დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით 
			//	შედგენილ პირამიდის ფორმას.მაგალითად ციფრი 4–ის 
			//	შეყვანისას კონსოლში გამოვა შემდეგი სახის პირამიდა:

			//Console.WriteLine("Enter number");

			//bool isValid = int.TryParse(Console.ReadLine(), out int num);

			//if (isValid)
			//{
			//	for (int i = 1; i <= num; i++)
			//	{
			//		for (int j = 1; j <= num - i; j++)

			//			Console.Write(" ");
			//		for (int k = 1; k <= i; k++)

			//			Console.Write("* ");
			//		Console.WriteLine();

			//	}


			//}
			//else
			//{
			//	Console.WriteLine("invalid input");
			//}





			//დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხულ
			//რიცხვამდე დააჯამებს ყველა ლუწ რიცხვს
			//და პასუხი გამოიტანეთ კონსოლში



			//Console.WriteLine("enter number");

			//bool isValid = int.TryParse(Console.ReadLine(), out int num);
			//int sum = 0;
			//if (isValid)
			//{
			//	for (int i = 2; i < num; i+=2)
			//	{
			//		//if (i % 2 == 0)
			//		//{
			//			sum += i;
			//		//}
			//	}
			//}


			//Console.WriteLine(sum);





			//			დაწერეთ პროგრამა რომელიც აირჩევს რენდომულ რიცხვს.
			//მომხმარებელმა შემოიყვანოს კონსოლიდან რიცხვი
			//მანამ არ გამოიცნობს არჩეულ რენდომულ რიცხვს.


			//Random random = new Random();
			// 	Random random = new();

			//int rand = random.Next(0,100);  //-2  +2 

			//Console.WriteLine("Enter number");
			//bool isvalid = int.TryParse(Console.ReadLine(), out int userNum);


			//	while(rand != userNum || !isvalid)
			//	{
			//		Console.WriteLine(rand);
			//		Console.WriteLine("Try again");
			//		isvalid = int.TryParse(Console.ReadLine(), out  userNum);
			//	}












			#endregion





			//[20,40,50]    Length-1 
			//          0  1   2 


			//let arr = [20,60,70,50, "fdfdf"]  js  


			//string[] arr = ["sd"];

			//arr[0] = "ramesxva";
			////arr[1] = "kidev sxva rames";    ///  out of range
			//Console.WriteLine(arr[0]);
			//
			//
			//int[] point = [50, 65, 70, 85];
			//int sum = 0;

			//for (int i = 0; i < point.Length; i++)
			//{
			//	//Console.WriteLine(point[i]);  // 50 65 70 85

			//	//if (point[i] > 60)
			//	//{
			//	//	Console.WriteLine(point[i]);
			//	//}

			//	sum+= point[i];

			//}

			//Console.WriteLine(sum/point.Length);
			//დაბეჭდეთ ყველა ის ქულა რომელიც მეტია 60 ზე 


			//int[] points = [50, 65, 70, 85];

			//foreach (var item in points)
			//{
			//	Console.WriteLine(item);
			//}
			//
			int[][] jagedArray = [ [20,50], [40,60], [60,70,80]   ];
			//Console.WriteLine(jagedArray[0][0]);


			foreach (var item in jagedArray)   //[40,60]
			{

				foreach (var num in item) ////[40,60]
				{
					Console.WriteLine(num);
				}

			}



			//2D 
			//2D 

		}
	}
}
