using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
	internal class ConsoleUI : IUI
	{
		private int _delayMiliseconds;
		public void Print(string message)
		{
			Console.WriteLine(message);
		}

		public T Input<T>() // Generisk metod som körs tills rätt type har blivit inmatad av användaren
		{
			while (true)
			{
				string input = Console.ReadLine() ?? string.Empty;
				try
				{
					return (T)Convert.ChangeType(input, typeof(T));
				}
				catch
				{
					Console.WriteLine("Invalid input. Try again!");
				}
			}
		}

		public void Clear()
		{
			Console.Clear();
		}

		public void Exit()
		{
			Environment.Exit(0);
		}

		public T Input2<T>()
		{
			string input = Console.ReadLine() ?? string.Empty;
			return (T)Convert.ChangeType(input, typeof(T));
		}
	}
}
