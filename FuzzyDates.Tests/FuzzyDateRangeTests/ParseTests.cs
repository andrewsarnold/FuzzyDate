using System;
using FuzzyDates.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateRangeTests
{
	[TestClass]
	public class ParseTests
	{
		[TestMethod]
		public void ParseEmptyTest()
		{
			try
			{
				var range = FuzzyDateRange.Parse("");
				Assert.IsFalse(range.From.Year.HasValue);
				Assert.IsFalse(range.To.Year.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseDelineatorOnlyTest()
		{
			try
			{
				var range = FuzzyDateRange.Parse("-");
				Assert.IsFalse(range.From.Year.HasValue);
				Assert.IsFalse(range.To.Year.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromOnlyTest()
		{
			try
			{
				var range = FuzzyDateRange.Parse("2019-");
				Assert.AreEqual(2019, range.From.Year.Value);
				Assert.IsFalse(range.To.Year.HasValue);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseToOnlyTest()
		{
			try
			{
				var range = FuzzyDateRange.Parse("-2019");
				Assert.IsFalse(range.From.Year.HasValue);
				Assert.AreEqual(2019, range.To.Year.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseBothTest()
		{
			try
			{
				var range = FuzzyDateRange.Parse("10/2019-11/15/2019");
				Assert.AreEqual(2019, range.From.Year.Value);
				Assert.AreEqual(10, range.From.Month.Value);
				Assert.IsFalse(range.From.Day.HasValue);
				Assert.AreEqual(2019, range.To.Year.Value);
				Assert.AreEqual(11, range.To.Month.Value);
				Assert.AreEqual(15, range.To.Day.Value);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}

		[TestMethod]
		public void ParseFromInvalidRangeTest()
		{
			Assert.ThrowsException<BadDateRangeFormatException>(() => _ = FuzzyDateRange.Parse("2019"));
		}

		[TestMethod]
		public void ParseFromInvalidDateTest()
		{
			Assert.ThrowsException<BadDateFormatException>(() => _ = FuzzyDateRange.Parse("left-right"));
		}
	}
}
