using Lect11.Models;
using System;
using System.Collections.Generic;
using System.Text;

//oveload - გადატვირთვა

//generic - ზოგადი

namespace Lect11.Helpers
{
	internal class ArrayHelper
	{

		public static void PrintArrayGen<T>(T[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}


		//public static void PrintArray(Employee[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}

		//public static void PrintArray(int[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//public static void PrintArray(string[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
	}
}
