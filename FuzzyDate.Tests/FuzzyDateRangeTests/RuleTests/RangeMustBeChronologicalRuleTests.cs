using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDate.Tests.FuzzyDateRangeTests.RuleTests
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
		public void FromNullIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(null, FuzzyDate.Today);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ToNullIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(FuzzyDate.Today, null);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void BothNullIsValid()
		{
			try
			{
				_ = new FuzzyDateRange(null, null);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
