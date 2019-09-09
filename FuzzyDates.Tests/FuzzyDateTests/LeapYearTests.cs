using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateTests
{
	[TestClass]
	public class LeapYearTests
	{
		[TestMethod]
		public void LeapYearVoidTest()
		{
			var fd = new FuzzyDate();
			Assert.IsFalse(fd.IsLeapYear());
		}

		[TestMethod]
		public void LeapYearDefinedTest()
		{
			var leapYears = new int[]
			{
				1996,
				2000,
				2004,
				2008,
				2012,
				2016
			};

			for (int year = 1995; year <= 2019; year++)
			{
				var date = new FuzzyDate(year);
				if (leapYears.Contains(year))
				{
					Assert.IsTrue(date.IsLeapYear());
				}
				else
				{
					Assert.IsFalse(date.IsLeapYear());
				}
			}
		}
	}
}
