namespace Övning2
{
	internal interface IUI
	{
		void Clear();
		void Exit();
		T Input<T>();
		T PromptInput<T>(string msg);
		void Print(string message, bool lineBreak = true);
	}
}