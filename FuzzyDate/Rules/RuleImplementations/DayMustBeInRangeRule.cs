using System;

namespace FuzzyDate.Rules.RuleImplementations
{
	internal class DayMustBeInRangeRule : IRule
	{
		public void Verify(FuzzyDate date)
		{
			// Todo - validate against number of days in month?

			if (date.Day.HasValue && (date.Day < 1 || date.Day > 31))
			{
				throw new ArgumentException("Day must be between 1 and 31", nameof(date.Day));
			}
		}
	}
}
