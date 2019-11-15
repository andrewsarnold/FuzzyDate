using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace FuzzyDates.Tests.FuzzyDateTests
{
	[TestClass]
	public class SerializationTests
	{
		[TestMethod]
		public void ReserializeTest()
		{
			try
			{
				var original = FuzzyDate.Today;
				var js = JsonConvert.SerializeObject(original);
				var reconstructed = JsonConvert.DeserializeObject<FuzzyDate>(js);
				Assert.AreEqual(original, reconstructed);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Expect no exception, but got {ex.Message}");
			}
		}
	}
}
