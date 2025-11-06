using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Applications
{
	internal class CinemaDiscountApplication : ApplicationBase
	{
		// Inherits 
		public CinemaDiscountApplication(IUI ui) : base(ui) { }
		public override void Run()
		{
			_ui.Print("");
		}
	}
}
