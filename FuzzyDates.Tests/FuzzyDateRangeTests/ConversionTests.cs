using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateRangeTests
{
	[TestClass]
	public class ConversionTests
	{
		[TestMethod]
		public void ConvertToTimeSpanTest()
		{
			try
			{
				var dayFrom = 2;
				var dayTo = 15;

				var from = new FuzzyDate(2019, 9, dayFrom);
				var to = new FuzzyDate(2019, 9, dayTo);
				var range = new FuzzyDateRange(from, to);
				var converted = range.ToTimeSpan();
				Assert.AreEqual(dayTo - dayFrom, converted.TotalDays);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ConvertToTimeSpanUnknownDayTest()
		{
			try
			{
				var monthFrom = 2;
				var monthTo = 5;

				var from = new FuzzyDate(2019, monthFrom);
				var to = new FuzzyDate(2019, monthTo);
				var range = new FuzzyDateRange(from, to);
				var converted = range.ToTimeSpan();
				Assert.AreEqual(monthTo - monthFrom, (int)Math.Round(converted.TotalDays / 30)); // close enough
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ConvertToTimeSpanUnknownMonthTest()
		{
			try
			{
				var yearFrom = 2013;
				var yearTo = 2018;

				var from = new FuzzyDate(yearFrom);
				var to = new FuzzyDate(yearTo);
				var range = new FuzzyDateRange(from, to);
				var converted = range.ToTimeSpan();
				Assert.AreEqual(yearTo - yearFrom, (int)Math.Round(converted.TotalDays / 365.25)); // also close enough
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
