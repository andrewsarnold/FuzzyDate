namespace FuzzyDate.Rules
{
	internal interface IRule<T>
	{
		/// <summary>
		/// Throws an exception with a relevant message if the rule is not met.
		/// </summary>
		/// <param name="obj"></param>
		void Verify(T obj);
	}
}
