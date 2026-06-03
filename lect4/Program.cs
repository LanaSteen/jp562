namespace lect4
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region hw


			//			Login სისტემა: პროგრამაში გვაქვს
			//username: admin
			//password: 1234
			//მომხმარებელს შემოჰყავს ორივე მნიშვნელობა
			// თუ სწორია კონსოლში გამოიტანე:
			//Welcome!
			// თუ არა:
			//Access denied



			//string userrole = "admmin";
			//string userpass = "1234";


			//Console.WriteLine("Enter userName");
			//string userName = Console.ReadLine();

			//Console.WriteLine("Enter password");
			//string userPasword = Console.ReadLine();



			//if(userName == userrole && userPasword == userpass)
			//{

			//	Console.WriteLine("Welcome");
			//}
			//else
			//{
			//	Console.WriteLine("Access denied");
			//}


			//int x = 1234; 







			//			Calculator(switch-ით)
			//მომხმარებელი შეიყვანს:
			//•	რიცხვი 1
			//•	ოპერატორი(+-* /)
			//•	რიცხვი 2
			//კონსოლში გამოიტანე არითმეტიკული ოპერაციის შედეგი. (შემოყვანილი ოპერატორის შესაბამისად)



			Console.WriteLine("enter first number");
			string num1str = Console.ReadLine();


			Console.WriteLine("enter opp");
			string oppStr = Console.ReadLine();


			Console.WriteLine("enter second number");
			string num2str = Console.ReadLine();





			//int num1;
			//bool num1isValid = int.TryParse(num1str, out int num1);  // 0

			//bool num2isValid = int.TryParse(num2str, out int num2);  // 0

			//bool isValidOpp = char.TryParse(oppStr, out char opperator);



			//if (num1isValid && num2isValid && isValidOpp)
			//{
			//	switch (opperator)
			//	{
			//		case '+':
			//			Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
			//			break;
			//		case '-':
			//			Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
			//			break;
			//		case '*':
			//			Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
			//			break;
			//		case '/':
			//			if (num2 == 0)
			//			{
			//				Console.WriteLine("Devide by 0 is not possibole");
			//			}
			//			else
			//			{
			//				Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
			//			}
			//			break;
			//		default:
			//			Console.WriteLine("Invalid opperatorf");
			//			break;
			//	}

			//}
			//else
			//{
			//	Console.WriteLine("Invalid input");
			//}







			//			მომხმარებელს შეაყვანინე ასაკი:
			//			დაადგინე და კონსოლში გამოიტანე:
			//•	ბავშვი(0–12)
			//•	თინეიჯერი(13–19)
			//•	ზრდასრული(20–64)
			//•	პენსიონერი(65 +)


			//Console.WriteLine("Enter Age");
			//string ageStr = Console.ReadLine();


			//byte age;
			//bool isValid = byte.TryParse(ageStr, out age);


			//if(age <=12 && isValid)
			//{
			//	Console.WriteLine("Kid");
			//}  
			//else if (age <=19 && isValid)
			//{
			//	Console.WriteLine("Teenager");
			//}
			//else if(age <=64 && isValid)
			//{
			//	Console.WriteLine("Adult");
			//}
			//else if (isValid)
			//{
			//	Console.WriteLine("Pensionerf");
			//}
			//else
			//{
			//	Console.WriteLine("error");
			//}


			#endregion


			decimal balance = 1000;

			Console.Write("enter amount");
			string amountstr = Console.ReadLine();

			bool success = decimal.TryParse(amountstr, out decimal amount);
			
			if (success) {

				Console.WriteLine($"your balance is {balance - amount}");			
			}
			else
			{
				Console.WriteLine("invalid input");
			}











			//ბალანსი 1000
			//მოხმარებელს კითხეთ 500
   //         ბალანსი 1000-500



		}
	}
}
