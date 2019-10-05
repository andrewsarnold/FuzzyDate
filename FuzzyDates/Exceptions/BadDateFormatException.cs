using System;

namespace FuzzyDates.Exceptions
{
	public class BadDateFormatException : Exception
	{
		public BadDateFormatException()
			: base("Could not parse date from string.")
		{
		}
	}
}
