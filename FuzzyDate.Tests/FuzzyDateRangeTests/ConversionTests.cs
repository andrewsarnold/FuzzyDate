using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDate.Tests.FuzzyDateRangeTests
{
	[TestClass]
	public class ConversionTests
	{
		[TestMethod]
		public void ConstructTest()
		{
			var dateRange = new FuzzyDateRange(new FuzzyDate(2019, 1), FuzzyDate.Today);
			Trace.WriteLine(dateRange);
		}
	}
}
