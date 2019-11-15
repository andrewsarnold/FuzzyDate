using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace FuzzyDates.Tests.FuzzyDateRangeTests
{
	[TestClass]
	public class SerializationTests
	{
		[TestMethod]
		public void ReserializeTest()
		{
			try
			{
				var original = new FuzzyDateRange(new FuzzyDate(DateTime.Today.AddDays(-5)), FuzzyDate.Today);
				var js = JsonConvert.SerializeObject(original);
				var reconstructed = JsonConvert.DeserializeObject<FuzzyDateRange>(js);
				Assert.AreEqual(original, reconstructed);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
