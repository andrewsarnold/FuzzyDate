using System;
using System.Text.RegularExpressions;

namespace FuzzyDates.Parsers
{
	internal class FuzzyDateParserY : FuzzyDateParser
	{
		internal override Regex Regex => new Regex(@"^(\d{1,4})$");

		internal override Func<FuzzyDate> Constructor => () =>
		{
			var yyyy = Match.Groups[1].Value;
			return new FuzzyDate(int.Parse(yyyy));
		};
	}
}
