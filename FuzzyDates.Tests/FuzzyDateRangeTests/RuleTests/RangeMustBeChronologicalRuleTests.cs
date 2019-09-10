using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateRangeTests.RuleTests
{
	[TestClass]
	public class RangeMustBeChronologicalRuleTests
	{
		[TestMethod]
		public void FromBeforeToIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(new FuzzyDate(2019), new FuzzyDate(2019, 5));
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void FromEqualToToIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(new FuzzyDate(2019, 5), new FuzzyDate(2019, 5));
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void FromAfterToIsInvalid()
		{
			Assert.ThrowsException<ArgumentException>(() => _ = new FuzzyDateRange(new FuzzyDate(2019, 5), new FuzzyDate(2019, 1)));
		}

		[TestMethod]
		public void FromUnknownIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(FuzzyDate.Unknown, FuzzyDate.Today);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ToUnknownIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(FuzzyDate.Today, FuzzyDate.Unknown);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void BothUnknownIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(FuzzyDate.Unknown, FuzzyDate.Unknown);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
