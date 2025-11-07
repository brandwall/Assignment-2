using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Applications
{
	internal class ThirdWordApplication : ApplicationBase
	{
		public ThirdWordApplication(IUI ui) : base(ui) { }
		public override void Run()
		{
			while (true)
			{
				string input = _ui.PromptInput<string>("Ange en mening med minst tre ord: ");
				var splitInput = input.Split(' ');

				// Kontrollerar om man antingen har angivit fler mellanslag efter varann eller har angivit mindre än 3 ord
				if (splitInput.Contains(string.Empty) || splitInput.Length < 3)
				{
					_ui.Clear();
					_ui.Print("Försök igen! ");
				}
				else if (splitInput.Length >= 3)
				{
					_ui.Print(splitInput[2]);
					break;
				}
			}

		}
	}
}
