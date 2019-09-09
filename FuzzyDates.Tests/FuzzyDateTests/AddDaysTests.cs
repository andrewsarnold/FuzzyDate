using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateTests
{
	[TestClass]
	public class AddDaysTests
	{
		[TestMethod]
		public void AddToNoDayTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 9);
				var newDate = fd.AddDays(10);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddNegativeDaysTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 9, 9);
				var newDate = fd.AddDays(-5);
				Assert.AreEqual(2019, newDate.Year);
				Assert.AreEqual(9, newDate.Month);
				Assert.AreEqual(4, newDate.Day);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddZeroDaysTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 9, 15);
				var newDate = fd.AddDays(0);
				Assert.AreEqual(2019, newDate.Year);
				Assert.AreEqual(9, newDate.Month);
				Assert.AreEqual(15, newDate.Day);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddPositiveDaysTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 9, 29);
				var newDate = fd.AddDays(10);
				Assert.AreEqual(2019, newDate.Year);
				Assert.AreEqual(10, newDate.Month);
				Assert.AreEqual(9, newDate.Day);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
