using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateTests
{
	[TestClass]
	public class ConversionTests
	{
		[TestMethod]
		public void ConvertNormalDateToDateTimeTest()
		{
			try
			{
				var fDate = new FuzzyDate(2019, 9, 3);
				var converted = fDate.ToDateTime();
				Assert.AreEqual(fDate.Year.Value, converted.Year);
				Assert.AreEqual(fDate.Month.Value, converted.Month);
				Assert.AreEqual(fDate.Day.Value, converted.Day);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ConvertNegativeYearToDateTimeTest()
		{
			try
			{
				var fDate = new FuzzyDate(-50, 9, 3);
				var converted = fDate.ToDateTime();
				Assert.AreEqual(1, converted.Year);
				Assert.AreEqual(fDate.Month.Value, converted.Month);
				Assert.AreEqual(fDate.Day.Value, converted.Day);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ConvertUnknownDayToDateTimeTest()
		{
			try
			{
				var fDate = new FuzzyDate(2019, 9);
				var converted = fDate.ToDateTime();
				Assert.AreEqual(fDate.Year.Value, converted.Year);
				Assert.AreEqual(fDate.Month.Value, converted.Month);
				Assert.AreEqual(1, converted.Day);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ConvertDateToIso8601Test()
		{
			Assert.AreEqual("", new FuzzyDate().ToIso8601());
			Assert.AreEqual("2020", new FuzzyDate(2020).ToIso8601());
			Assert.AreEqual("2020-01", new FuzzyDate(2020, 1).ToIso8601());
			Assert.AreEqual("2020-01-22", new FuzzyDate(2020, 1, 22).ToIso8601());
			Assert.AreEqual("12020-01-22", new FuzzyDate(12020, 1, 22).ToIso8601());

			Assert.AreEqual("2020-01", new FuzzyDate(2020, 1).ToIso8601(false));
			Assert.AreEqual("20200122", new FuzzyDate(2020, 1, 22).ToIso8601(false));
		}

		[TestMethod]
		public void ConvertRangeToIso8601Test()
		{
			var range = new FuzzyDateRange(new FuzzyDate(2019, 4, 5), new FuzzyDate(2020, 1, 22));
			Assert.AreEqual("2019-04-05/2020-01-22", range.ToIso8601());
			Assert.AreEqual("2019-04-05--2020-01-22", range.ToIso8601(true));
		}
	}
}
