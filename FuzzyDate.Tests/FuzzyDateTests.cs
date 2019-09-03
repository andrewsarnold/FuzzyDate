using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzyDate.Tests
{
	[TestClass]
	public class FuzzyDateTests
	{
		[TestMethod]
		public void CompareToTests()
		{
			// -1 = first object comes before the second
			//  0 = objects should be sorted on the same level
			// +1 = first object comes after the second

			Assert.AreEqual(0, new FuzzyDate().CompareTo(new FuzzyDate()));

			Assert.AreEqual(-1, new FuzzyDate().CompareTo(new FuzzyDate(2019)));
			Assert.AreEqual(1, new FuzzyDate(2019).CompareTo(new FuzzyDate()));

			Assert.AreEqual(-1, new FuzzyDate(2018).CompareTo(new FuzzyDate(2019)));
			Assert.AreEqual(0, new FuzzyDate(2019).CompareTo(new FuzzyDate(2019)));
			Assert.AreEqual(1, new FuzzyDate(2019).CompareTo(new FuzzyDate(2018)));

			Assert.AreEqual(-1, new FuzzyDate(2019).CompareTo(new FuzzyDate(2019, 4)));
			Assert.AreEqual(0, new FuzzyDate(2019, 4).CompareTo(new FuzzyDate(2019, 4)));
			Assert.AreEqual(1, new FuzzyDate(2019, 4).CompareTo(new FuzzyDate(2019)));

			Assert.AreEqual(-1, new FuzzyDate(2019, 4).CompareTo(new FuzzyDate(2019, 4, 15)));
			Assert.AreEqual(0, new FuzzyDate(2019, 4, 15).CompareTo(new FuzzyDate(2019, 4, 15)));
			Assert.AreEqual(1, new FuzzyDate(2019, 4, 15).CompareTo(new FuzzyDate(2019, 4)));

			Assert.AreEqual(-1, new FuzzyDate(2019).CompareTo(new FuzzyDate(2019, 4, 15)));
			Assert.AreEqual(1, new FuzzyDate(2019, 4, 15).CompareTo(new FuzzyDate(2019)));
		}
	}
}
