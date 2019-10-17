using System;
using System.Text.RegularExpressions;

namespace FuzzyDates.Parsers
{
	internal abstract class FuzzyDateParser
	{
		protected Match Match;

		internal abstract Regex Regex { get; }
		internal abstract Func<FuzzyDate> Constructor { get; }

		internal bool Matches(string value)
		{
			Match = Regex.Match(value);
			return Match.Success;
		}
	}
}
