using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateTests
{
	[TestClass]
	public class AddMonthsTests
	{
		[TestMethod]
		public void AddToNoMonthTest()
		{
			try
			{
				var fd = new FuzzyDate(2019);
				var newDate = fd.AddMonths(10);
				Assert.IsFalse(newDate.Month.HasValue);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddNegativeMonthsTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 9);
				var newDate = fd.AddMonths(-5);
				Assert.AreEqual(2019, newDate.Year);
				Assert.AreEqual(4, newDate.Month);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddZeroMonthsTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 9);
				var newDate = fd.AddMonths(0);
				Assert.AreEqual(2019, newDate.Year);
				Assert.AreEqual(9, newDate.Month);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddPositiveMonthsTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 9);
				var newDate = fd.AddMonths(10);
				Assert.AreEqual(2020, newDate.Year);
				Assert.AreEqual(7, newDate.Month);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
