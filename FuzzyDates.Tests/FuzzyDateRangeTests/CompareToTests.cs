using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDates.Tests.FuzzyDateRangeTests
{
	[TestClass]
	public class CompareToTests
	{
		private FuzzyDate _fdNone = new FuzzyDate();
		private FuzzyDate _fdYear = new FuzzyDate(2019);
		private FuzzyDate _fdMonth = new FuzzyDate(2019, 9);
		private FuzzyDate _fdDay = new FuzzyDate(2019, 9, 15);

		[TestMethod]
		public void CompareToTest()
		{
			// -1 = first object comes before the second
			//  0 = objects should be sorted on the same level
			// +1 = first object comes after the second

			Assert.AreEqual(0, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdNone, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdYear, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdMonth, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdDay, _fdNone).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdDay, _fdYear).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(-1, new FuzzyDateRange(_fdDay, _fdMonth).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdNone, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdYear, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdMonth)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdMonth, _fdDay)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdNone)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdYear)));
			Assert.AreEqual(1, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdMonth)));
			Assert.AreEqual(0, new FuzzyDateRange(_fdDay, _fdDay).CompareTo(new FuzzyDateRange(_fdDay, _fdDay)));
		}

		private void TestGenerator()
		{
			var dateNames = new string[]
			{
				"_fdNone",
				"_fdYear",
				"_fdMonth",
				"_fdDay"
			};

			var dates = new FuzzyDate[]
			{
				_fdNone,
				_fdYear,
				_fdMonth,
				_fdDay
			};

			for (int firstFrom = 0; firstFrom < dates.Length; firstFrom++)
			{
				var firstFromDate = dates[firstFrom];
				var firstFromName = dateNames[firstFrom];

				for (int firstTo = 0; firstTo < dates.Length; firstTo++)
				{
					var firstToDate = dates[firstTo];
					var firstToName = dateNames[firstTo];

					for (int secondFrom = 0; secondFrom < dates.Length; secondFrom++)
					{
						var secondFromDate = dates[secondFrom];
						var secondFromName = dateNames[secondFrom];

						for (int secondTo = 0; secondTo < dates.Length; secondTo++)
						{
							var secondToDate = dates[secondTo];
							var secondToName = dateNames[secondTo];

							var compareResult = new FuzzyDateRange(firstFromDate, firstToDate).CompareTo(new FuzzyDateRange(secondFromDate, secondToDate));

							Trace.WriteLine($"Assert.AreEqual({compareResult}, new FuzzyDateRange({firstFromName}, {firstToName}).CompareTo(new FuzzyDateRange({secondFromName}, {secondToName})));");
						}
					}
				}
			}
		}
	}
}
