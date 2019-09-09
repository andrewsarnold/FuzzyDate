using System;

namespace FuzzyDates.Rules.RuleImplementations
{
	public class RangeMustBeChronologicalRule : IRule<FuzzyDateRange>
	{
		public void Verify(FuzzyDateRange range)
		{
			// Special case: If a date is wholly unknown, it can go on either end of the range
			if (range.From.Year == null || range.To.Year == null)
			{
				return;
			}

			// Special case: If the dates share a year, the first date's month is
			// known, but the second date's month is unknown, it is okay
			// (even though they would normally be sorted the opposite way)
			if (range.From.Year == range.To.Year &&
				range.From.Month != null && range.To.Month == null)
			{
				return;
			}

			// Likewise for days
			if (range.From.Year == range.To.Year &&
				range.From.Month == range.To.Month &&
				range.From.Day != null && range.To.Day == null)
			{
				return;
			}

			var sortOrder = range.From.CompareTo(range.To);
			if (sortOrder > 0)
			{
				throw new ArgumentException("To date must be after From date", nameof(range.To));
			}
		}
	}
}
