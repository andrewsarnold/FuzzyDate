using System;
using FuzzyDates.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateTests
{
	[TestClass]
	public class ParseTests
	{
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
		public void ParseFromZeroTest()
		{
			try
			{
				var date = FuzzyDate.Parse("0");
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

		[TestMethod]
		public void ParseFromMonthYearTest()
		{
			try
			{
				var date = FuzzyDate.Parse("09/2019");
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
		public void ParseFromMonthDayYearTest()
		{
			try
			{
				var date = FuzzyDate.Parse("09/15/2019");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(9, date.Month.Value);
				Assert.AreEqual(15, date.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromDayMonthYearTest()
		{
			try
			{
				var date = FuzzyDate.Parse("15/09/2019");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(9, date.Month.Value);
				Assert.AreEqual(15, date.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromYearMonthDayAmbiguousTest()
		{
			try
			{
				var date = FuzzyDate.Parse("2019/02/10");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(2, date.Month.Value);
				Assert.AreEqual(10, date.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseWithHyphenDelimiterTest()
		{
			try
			{
				var date = FuzzyDate.Parse("09-15-2019");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(9, date.Month.Value);
				Assert.AreEqual(15, date.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromAmbiguousDateTest()
		{
			Assert.ThrowsException<AmbiguousFormatException>(() => _ = FuzzyDate.Parse("05/05/2019"));
		}

		[TestMethod]
		public void ParseFromImpossibleDateTest()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => _ = FuzzyDate.Parse("15/15/2019"));
		}

		[TestMethod]
		public void ParseFromGarbageTest()
		{
			Assert.ThrowsException<BadDateFormatException>(() => _ = FuzzyDate.Parse("not a date"));
		}

		[TestMethod]
		public void ParseFromYearSingleDigitMonthTest()
		{
			try
			{
				var date = FuzzyDate.Parse("2019/9");
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
		public void ParseFromYearSingleDigitMonthDayTest()
		{
			try
			{
				var date = FuzzyDate.Parse("2019/9/15");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(9, date.Month.Value);
				Assert.AreEqual(15, date.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromSingleDigitMonthYearTest()
		{
			try
			{
				var date = FuzzyDate.Parse("9/2019");
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
		public void ParseFromSingleDigitMonthDayYearTest()
		{
			try
			{
				var date = FuzzyDate.Parse("9/15/2019");
				Assert.AreEqual(2019, date.Year.Value);
				Assert.AreEqual(9, date.Month.Value);
				Assert.AreEqual(15, date.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromDaySingleDigitMonthYearTest()
		{
			try
			{
				var date = FuzzyDate.Parse("15/9/2019");
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
