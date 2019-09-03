using System;

namespace FuzzyDate.Rules.RuleImplementations
{
	internal class YearMustBeNonZeroRule : IRule
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
