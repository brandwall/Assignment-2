using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Applications
{
	internal class StringRepeatApplication : ApplicationBase
	{
		public StringRepeatApplication(IUI ui) : base(ui) { }
		public override void Run()
		{
			string message = _ui.PromptInput<string>("Skriv mening som ska upprepas: ");

			for(int i = 1; i <= 10; i++)
			{
				_ui.Print($"{i}.{message} ", false);
			}
		}
	}
}
