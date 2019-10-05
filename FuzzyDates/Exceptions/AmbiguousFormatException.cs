using System;

namespace FuzzyDates.Exceptions
{
	public class AmbiguousFormatException : Exception
	{
		public AmbiguousFormatException()
			: base("Ambiguous date string. Could not determine if DD/MM/YYYY or MM/DD/YYYY")
		{
		}
	}
}
