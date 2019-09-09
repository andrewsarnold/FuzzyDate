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
		public void ParseFromEmptyTest()
		{
			try
			{
				var date = FuzzyDate.Parse("");
				Assert.IsFalse(date.Year.HasValue);
				Assert.IsFalse(date.Month.HasValue);
				Assert.IsFalse(date.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromYearTest()
		{
			try
			{
				var date = FuzzyDate.Parse("2019");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.IsFalse(date.Month.HasValue);
				Assert.IsFalse(date.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromYearMonthTest()
		{
			try
			{
				var date = FuzzyDate.Parse("2019/09");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(9, date.Month.Value);
				Assert.IsFalse(date.Day.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromYearMonthDayTest()
		{
			try
			{
				var date = FuzzyDate.Parse("2019/09/15");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(9, date.Month.Value);
				Assert.AreEqual(15, date.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
