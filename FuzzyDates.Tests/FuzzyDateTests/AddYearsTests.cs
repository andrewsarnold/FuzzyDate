using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateTests
{
	[TestClass]
	public class AddYearsTests
	{
		[TestMethod]
		public void AddToNullTest()
		{
			try
			{
				var fd = new FuzzyDate();
				var newDate = fd.AddYears(10);
				Assert.IsFalse(newDate.Year.HasValue);
				Assert.IsFalse(newDate.Month.HasValue);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddNegativeYearsTest()
		{
			try
			{
				var fd = new FuzzyDate(2019);
				var newDate = fd.AddYears(-5);
				Assert.AreEqual(2014, newDate.Year);
				Assert.IsFalse(newDate.Month.HasValue);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddZeroYearsTest()
		{
			try
			{
				var fd = new FuzzyDate(2019);
				var newDate = fd.AddYears(0);
				Assert.AreEqual(2019, newDate.Year);
				Assert.IsFalse(newDate.Month.HasValue);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddPositiveYearsTest()
		{
			try
			{
				var fd = new FuzzyDate(2019);
				var newDate = fd.AddYears(10);
				Assert.AreEqual(2029, newDate.Year);
				Assert.IsFalse(newDate.Month.HasValue);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void AddPositiveYearsWithMonthTest()
		{
			try
			{
				var fd = new FuzzyDate(2019, 6);
				var newDate = fd.AddYears(10);
				Assert.AreEqual(2029, newDate.Year);
				Assert.AreEqual(6, newDate.Month);
				Assert.IsFalse(newDate.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
