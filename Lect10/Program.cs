using Lect10.Enums;
using Lect10.Models;

namespace Lect10
{
	internal class Program
	{
		static void Main(string[] args)
		{


			User user = new();
			user.Role = Role.Employee; // admin guest emloyee

			user.FirstName = "Test";

			user.Password = "password";
			Console.WriteLine(user.Password);


			Employee employee = new Employee();
			employee.FirstName = "Test2";



			employee.Salary = 500m;
			employee.FirstName = "Test3";
			employee.Age = 30;



			//string path = "C:\\Users\\l4nst\\Desktop\\jp 562\\jp562\\Lect10\\Data\\data.txt";
			string path2 = @"../../../Data/data.txt";
			
			string[] lines = File.ReadAllLines(path2);

			User[] users = new User[lines.Length];  // [{},{},{}]

			//Giorgi,Beridze,25,g.beridze @email.com,599123456
			int index = 0;

			foreach (var line in lines)
			{
				//Console.WriteLine(line);

				string[] parts = line.Split(',');   // ["Giorgi", "Beridze", "25", "g.beridze @email.com", "599123456"]
			    User usernew  = new User();
				usernew.FirstName = parts[0];
				usernew.LastName = parts[1];
				usernew.Age = int.Parse(parts[2]);
				usernew.Email = parts[3];
				usernew.Phone = parts[4];

				users[index] = usernew;
				index++;

			}




			int[] nums = [20, 60, 30];


			foreach (var userprint in users)
			{
				userprint.Print();
			}


			//Person person = new Person();

			//აბსტრაქტული  abstract



			//decimal x = 5m;
			//float u  = 0f;
			//double v = 0;
		}
	}
}



//enum enumerable -  
//select  option






//student teacher manager

//თითოაულს უნდა ჰქონდეს 5 property
