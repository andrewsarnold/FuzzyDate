namespace FuzzyDates.Rules.RuleImplementations
{
	internal class DateMustExistInCalendarRule : IRule<FuzzyDate>
	{
		public void Verify(FuzzyDate date)
		{
			if (!date.Day.HasValue || (date.Year.HasValue && date.Year < Constants.YearMin))
			{
				return;
			}

			// Use built-in .net parser to determine if it is valid
			_ = date.ToDateTime();
		}
	}
}
