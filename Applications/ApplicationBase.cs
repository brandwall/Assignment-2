using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2.Applications
{
	internal abstract class ApplicationBase : IApplication
	{
		protected IUI _ui;
		protected ApplicationBase(IUI ui)
		{
			_ui = ui;
		}
		public abstract void Run();
	}
}
