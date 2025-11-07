using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Applications
{
	internal class CinemaDiscountApplication : ApplicationBase
	{
		internal enum Prices { Youth = 80, Senior = 90, Standard = 120}
		internal enum Ages { Youth = 20, Senior = 65 }
		public CinemaDiscountApplication(IUI ui) : base(ui) { } // Ärver _ui instansen från basklassen "ApplicationBase"
		public CinemaDiscountApplication(IUI ui, string choice) : base(ui)
		{
			// körs endast när man skapar ett object med en string (var tvungen att göra såhär eftersom IApplication endast har en Run metod
			RunDiscountCheck();
		}
		public override void Run()
		{
			uint quantity = _ui.PromptInput<uint>("Hur många är ni som ska gå på bio? ");
			List<Ticket> tickets = new List<Ticket>();

			tickets.Sum(t => t.Price);

			for(int i = 1; i <= quantity; i++)
			{
				_ui.Print($"Person #{i}: ");
				uint age = _ui.PromptInput<uint>("Ange ålder: ");

				tickets.Add(new Ticket(age));
			}

			_ui.Print($"Antal: {tickets.Count} personer");
			_ui.Print($"Kostnad: {tickets.Sum(t => t.Price)}kr");
		}

		public void RunDiscountCheck()
		{
			uint age = _ui.PromptInput<uint>("Ange ålder: ");
			string discount = CheckDiscount(age);

			if (discount == "Youth")
				_ui.Print($"Ungdomspris: {(int)Prices.Youth}kr");
			else if (discount == "Senior")
				_ui.Print($"Pensionärspris: {(int)Prices.Senior}kr");
			else
				_ui.Print($"Standardpris: {(int)Prices.Standard}kr");
		}

		private static string CheckDiscount(uint age)
		{
			if (age < (uint)Ages.Youth)
				return "Youth";
			if (age >= (uint)Ages.Senior)
				return "Senior";
			else
				return "Standard";
		}

		private class Ticket
		{
			internal uint Price { get; set; } = (int)Prices.Standard;
			private string Discount { get; set; } = "Standard";

			public Ticket(uint age)
			{
				Discount = CheckDiscount(age);
				if (Discount == "Youth")
				{
					Price = (uint)Prices.Youth;
				}
				else if (Discount == "Senior")
				{
					Price = (uint)Prices.Senior;
				}
			}
		}

	}

}
