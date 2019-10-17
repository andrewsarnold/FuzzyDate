using System;
using System.Text.RegularExpressions;

namespace FuzzyDates.Parsers
{
	internal class FuzzyDateParserMY : FuzzyDateParser
	{
		internal override Regex Regex => new Regex(@"^(\d{1,2})\/(\d{4})$");

		internal override Func<FuzzyDate> Constructor => () =>
		{
			var mm = Match.Groups[1].Value;
			var yyyy = Match.Groups[2].Value;

			return new FuzzyDate(int.Parse(yyyy), int.Parse(mm));
		};
	}
}
