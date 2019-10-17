using System;
using System.Text.RegularExpressions;

namespace FuzzyDates.Parsers
{
	internal class FuzzyDateParserYM : FuzzyDateParser
	{
		internal override Regex Regex => new Regex(@"^(\d{4})\/(\d{1,2})$");

		internal override Func<FuzzyDate> Constructor => () =>
		{
			var yyyy = Match.Groups[1].Value;
			var mm = Match.Groups[2].Value;

			return new FuzzyDate(int.Parse(yyyy), int.Parse(mm));
		};
	}
}
