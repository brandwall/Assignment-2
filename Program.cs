using Övning2.Applications;

namespace Övning2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ConsoleUI _ui = new ConsoleUI();

			while (true)
			{
				_ui.Print("");
				_ui.Print("Huvudmeny");
				_ui.Print($"1. Verifiera ålder för biorabatt");
				_ui.Print($"2. Köp biobiljetter");
				_ui.Print($"3. Ord-repeterare");
				_ui.Print($"4. Skriv-ut-tredje-ordet");
				_ui.Print($"0. Avsluta");

				int option = _ui.PromptInput<int>("Välj ett av alternativen: ");

				IApplication? app;
				switch (option)
				{
					case 0:
						_ui.Print("Avslutar...");
						_ui.Exit();
						break;
					case 1:
						_ui.Clear();
						_ui.Print("--- Rabattkontroll ---");
						app = new CinemaDiscountApplication(_ui, "discount");
						break;
					case 2:
						_ui.Clear();
						_ui.Print("--- Biokassa ---");
						app = new CinemaDiscountApplication(_ui);
						app.Run();
						break;
					case 3:
						_ui.Clear();
						_ui.Print("--- Repetera mening ---");
						app = new StringRepeatApplication(_ui);
						app.Run();
						break;
					case 4:
						_ui.Clear();
						_ui.Print("--- Skriva ut tredje ordet ---");
						app = new ThirdWordApplication(_ui);
						app.Run();
						break;
					default:
						_ui.Clear();
						_ui.Print("Fel alternativ. Försök igen!");
						break;
				}



			}
		}
	}
}
