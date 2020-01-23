using System;

namespace FuzzyDates.Rules.RuleImplementations
{
	internal class DayMustBeInRangeRule : IRule<FuzzyDate>
	{
		public void Verify(FuzzyDate date)
		{
			if (date.Day.HasValue && (date.Day < Constants.DayMin || date.Day > Constants.DayMax))
			{
				throw new ArgumentOutOfRangeException($"Day must be between {Constants.DayMin} and {Constants.DayMax}", nameof(date.Day));
			}
		}
	}
}
