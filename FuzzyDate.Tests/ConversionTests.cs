using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDate.Tests
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
	}
}
