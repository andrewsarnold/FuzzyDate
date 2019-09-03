using System;

namespace FuzzyDate.Rules
{
	internal class MonthMustBeInRangeRule : IRule
	{
		public void Verify(FuzzyDate date)
		{
			if (date.Month.HasValue && (date.Month < 1 || date.Month > 12))
			{
				throw new ArgumentException("Month must be between 1 and 12", nameof(date.Month));
			}
		}
	}
}
