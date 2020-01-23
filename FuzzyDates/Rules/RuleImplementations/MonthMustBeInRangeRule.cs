using System;

namespace FuzzyDates.Rules.RuleImplementations
{
	internal class MonthMustBeInRangeRule : IRule<FuzzyDate>
	{
		public void Verify(FuzzyDate date)
		{
			if (date.Month.HasValue && (date.Month < Constants.MonthMin || date.Month > Constants.MonthMax))
			{
				throw new ArgumentOutOfRangeException("Month must be between 1 and 12", nameof(date.Month));
			}
		}
	}
}
