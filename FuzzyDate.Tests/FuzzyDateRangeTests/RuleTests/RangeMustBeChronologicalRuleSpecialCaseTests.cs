using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDate.Tests.FuzzyDateRangeTests.RuleTests
{
	[TestClass]
	public class RangeMustBeChronologicalRuleSpecialCaseTests
	{
		[TestMethod]
		public void NullToMonthIsValid()
		{
			// 9/2019 - ?/2019 is valid
			try
			{
				_ = new FuzzyDateRange(new FuzzyDate(2019, 9), new FuzzyDate(2019));
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void NullToDayIsValid()
		{
			// 9/4/2019 - 9/2019 is valid
			try
			{
				_ = new FuzzyDateRange(new FuzzyDate(2019, 9, 4), new FuzzyDate(2019, 9));
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
