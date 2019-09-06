using System.Collections.Generic;
using FuzzyDate.Rules.RuleImplementations;

namespace FuzzyDate.Rules
{
	internal static class RulesRunner
	{
		private static readonly IEnumerable<IRule<FuzzyDate>> _fuzzyDateRules = new List<IRule<FuzzyDate>>
		{
			new DayMustBeInRangeRule(),
			new MonthMustBeInRangeRule(),
			new YearMustBeNonZeroRule(),
			new DateMustExistInCalendarRule()
		};

		private static readonly IEnumerable<IRule<FuzzyDateRange>> _fuzzyDateRangeRules = new List<IRule<FuzzyDateRange>>
		{
			new RangeMustBeChronologicalRule()
		};

		internal static void RunRules(FuzzyDate date)
		{
			foreach (var rule in _fuzzyDateRules)
			{
				rule.Verify(date);
			}
		}

		internal static void RunRules(FuzzyDateRange range)
		{
			foreach (var rule in _fuzzyDateRangeRules)
			{
				rule.Verify(range);
			}
		}
	}
}
