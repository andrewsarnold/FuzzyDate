using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.RuleTests.FuzzyDateTests
{
	[TestClass]
	public class DayMustBeInRangeTests
	{
		[TestMethod]
		public void DayLessThanOneIsInvalid()
		{
			Assert.ThrowsException<ArgumentException>(() => _ = new FuzzyDate(2018, 9, 0));
		}

		[TestMethod]
		public void DayGreaterThanTwelveIsInvalid()
		{
			Assert.ThrowsException<ArgumentException>(() => _ = new FuzzyDate(2018, 9, 32));
		}

		[TestMethod]
		public void DayInRangeIsValid()
		{
			try
			{
				_ = new FuzzyDate(2019, 9, 3);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
