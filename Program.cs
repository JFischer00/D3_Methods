using System;

namespace D3_Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your name:");
			PrintWelcome(Console.ReadLine());
		}

		private static void PrintWelcome(string name)
		{
			Console.WriteLine($"Hello {name}!");
		}
	}
}
