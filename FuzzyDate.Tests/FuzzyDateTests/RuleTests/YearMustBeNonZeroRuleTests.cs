using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDate.Tests.RuleTests.FuzzyDateTests
{
	[TestClass]
	public class YearMustBeNonZeroRuleTests
	{
		[TestMethod]
		public void YearGreaterThanZeroIsValid()
		{
			try
			{
				_ = new FuzzyDate(1950);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void YearLessThanZeroIsValid()
		{
			try
			{
				_ = new FuzzyDate(-6000);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void YearEqualToZeroIsInvalid()
		{
			Assert.ThrowsException<ArgumentException>(() => _ = new FuzzyDate(0));
		}
	}
}
