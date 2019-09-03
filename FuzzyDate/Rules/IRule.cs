namespace FuzzyDate.Rules
{
	internal interface IRule
	{
		/// <summary>
		/// Throws an exception with a relevant message if the rule is not met.
		/// </summary>
		/// <param name="date"></param>
		void Verify(FuzzyDate date);
	}
}
