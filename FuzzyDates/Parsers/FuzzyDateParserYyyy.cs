using System;
using System.Text.RegularExpressions;

namespace FuzzyDates.Parsers
{
	internal class FuzzyDateParserYyyy : FuzzyDateParser
	{
		internal override Regex Regex => new Regex(@"(\d\d\d\d)");

		internal override Func<FuzzyDate> Constructor => () =>
		{
			var yyyy = Match.Groups[1].Value;
			return new FuzzyDate(int.Parse(yyyy));
		};
	}
}
