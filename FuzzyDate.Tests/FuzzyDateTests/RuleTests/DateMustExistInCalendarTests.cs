using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDate.Tests.RuleTests.FuzzyDateTests
{
	[TestClass]
	public class DateMustExistInCalendarTests
	{
		[TestMethod]
		public void NormalDayIsValid()
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

		[TestMethod]
		public void ThirtyFirstOfSeptemberIsinvalid()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => _ = new FuzzyDate(2019, 9, 31));
		}

		[TestMethod]
		public void TwentyNinthOfFebruaryIsinvalid()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => _ = new FuzzyDate(2019, 2, 29));
		}

		[TestMethod]
		public void TwentyNinthOfFebruaryInLeapYearIsValid()
		{
			try
			{
				_ = new FuzzyDate(2020, 2, 29);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
