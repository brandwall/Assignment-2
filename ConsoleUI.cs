using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
	internal class ConsoleUI : IUI
	{
		public void Print(string message, bool lineBreak = true) // line break är automatiskt aktiverat om man inte skickar in false
		{
			if (lineBreak)
				Console.WriteLine(message);
			else
				Console.Write(message);
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
					Console.WriteLine("Felaktig inmatning. Försök igen! ");
				}
			}
		}

		public T PromptInput<T>(string msg) // Skriver ut ett meddelande och tar sen emot input
		{
			Console.Write(msg);
			return Input<T>();
		}

		public void Clear()
		{
			Console.Clear();
		}

		public void Exit()
		{
			Environment.Exit(0);
		}
	}
}
