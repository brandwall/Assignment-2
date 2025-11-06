namespace Övning2
{
	internal interface IUI
	{
		void Clear();
		void Exit();
		T Input<T>();
		void Print(string message);
	}
}