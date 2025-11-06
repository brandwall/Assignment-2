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
		public CinemaDiscountApplication(IUI ui) : base(ui) { } // Inherits the _ui instance from the base class "ApplicationBase"
		public override void Run()
		{
			
		}

		public void RunDiscountCheck()
		{
			int age = InputAge();

			if (age > 0)
			{
				if (age < (int)Ages.Youth)
					_ui.Print($"Ungdomspris: {Prices.Youth}kr");
				if (age > (int)Ages.Senior)
					_ui.Print($"Pensionärspris: {Prices.Senior}kr");
				else
					_ui.Print($"Standardpris: {Prices.Standard}kr");
			}
		}

		private int InputAge()
		{
			_ui.Print("Ange ålder: ");
			return _ui.Input<int>();
		}

		private void AddTicket()
		{
			var ticket = new Ticket("ha", 12);
		}

		private int GetPrice(int age)
		{
			int price;
			if (age < (int)Ages.Youth)
				price = (int)Prices.Youth;
			if (age >= (int)Ages.Senior)
				price = (int)Prices.Senior;
			else
				price = (int)Prices.Standard;

			return price;
		}

		private class Ticket
		{
			private string Name { get; set; }
			private int Price { get; set; }

			public Ticket(string name, int age)
			{
				Name = name;
				
			}

		}

	}

}
