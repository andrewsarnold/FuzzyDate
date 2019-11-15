using System;

namespace FuzzyDates.Exceptions
{
	public class BadDateRangeFormatException : Exception
	{
		public BadDateRangeFormatException()
			: base("Could not parse date range from string.")
		{
		}
	}
}
