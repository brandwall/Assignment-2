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
				_ui.Print("Main menu");
				_ui.Print($"1. Cinema age discount");
				_ui.Print($"2. Repeat string x10");
				_ui.Print($"3. The third word");
				_ui.Print($"0. Exit");


				_ui.Print("Select which program to run:");
				int option = _ui.Input<int>();

				IApplication? app;
				switch (option)
				{
					case 0:
						_ui.Clear();
						_ui.Print("Exiting application...");
						_ui.Exit();
						break;
					case 1:
						_ui.Clear();
						_ui.Print("Cinema");
						app = new CinemaDiscountApplication(_ui);
						app.Run();
						break;
					case 2:
						_ui.Clear();
						_ui.Print("String repetition");
						app = new StringRepeatApplication(_ui);
						app.Run();
						break;
					case 3:
						_ui.Clear();
						_ui.Print("The third word");
						app = new StringRepeatApplication(_ui);
						app.Run();
						break;
					default:
						_ui.Clear();
						_ui.Print("Invalid input. Try again!");
						break;
				}



			}
		}
	}
}
