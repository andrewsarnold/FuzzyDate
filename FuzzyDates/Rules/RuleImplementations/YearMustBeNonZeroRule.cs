using System;

namespace FuzzyDates.Rules.RuleImplementations
{
	internal class YearMustBeNonZeroRule : IRule<FuzzyDate>
	{
		public void Verify(FuzzyDate date)
		{
			if (date.Year.HasValue && date.Year == 0)
			{
				throw new ArgumentException("Year cannot be zero", nameof(date.Year));
			}
		}
	}
}
