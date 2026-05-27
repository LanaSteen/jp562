namespace lect2
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//string name = "ddfgf";


			//string name;
			//name = "fgfh";


			////""   char ''

			//char ch = 'a';

			//string ch2 = "b";

			//String text = "Dsdffg";


			//bool isvalid = true;




			//var x = true;

			////var x = 10;  //int

			////x = "dsd";




			//Console.WriteLine(int.MaxValue);



			//2015 es6 
			//var  
			//const 
			//let 


			//var x = 10;
			//x ="fdgdh"

			//	if ()
			//{
			//	const cvladi = 10
			//}




			//=  

			//==     10!=0  

			//>=  <=  > <  !=    ! not

			//!true


			//&& and   || or 




			//&   |     1011101    



			//?:     ternary operator

			//5==5


			//Console.WriteLine(10 == 10 ? "rame" : "other rame");

			//Console.Write("");

			//Console.ReadLine();  // prompt




			//Console.WriteLine("Hello, World!");

			//   string ageStr =	Console.ReadLine(); // strgin   "50"

			//Console.WriteLine(ageStr+1);  //501

			////int age = int.Parse(ageStr);  // int 51
			////int age;  // 0

			//bool isValid = int.TryParse(ageStr, out age);

			//Console.WriteLine(age+6);  // 51


			//if (5>6) 
			//{
			//	if ()
			//	{

			//	}
			//	else
			//	{

			//	}
			//}
			//else if (5<6)
			//{
			//	Console.WriteLine("5<6");
			//}
			//else
			//{
			//	Console.WriteLine("5>6");
			//}



			//Console.WriteLine("Enter number");

			//string userInput = Console.ReadLine();

			//int num;

			//bool validNum = int.TryParse(userInput, out num);

			//if (validNum)
			//{
			//	num++;
			//}
			//else
			//{
			//	Console.WriteLine("Invalid input");
			//}

			 //   sallary  
				//nationality

			 //   sallary  > 1000  you are rich
				//sallary < 1000   "GEO"  you are poor but its ok

				//sallary < 1000   your are poor




			string salaryStr = Console.ReadLine(); // "1000"  "dffgffhg"

			int salary;
			bool validSallary = int.TryParse(salaryStr, out salary);

			string nat = Console.ReadLine(); // "GEO"  "USA"


			if(validSallary)
			{

				if(salary > 1000)
				{
					Console.WriteLine("you are rich");
				}
				else if (nat == "GEO")
				{
					Console.WriteLine("you are poor but its ok");
				}

				else
				{
					Console.WriteLine("You are poor");
				}

			}
			else
			{
				Console.WriteLine("Invalid input");
			}
		


		}
	}
}
