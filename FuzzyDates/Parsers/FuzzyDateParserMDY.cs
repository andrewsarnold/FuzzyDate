using System;
using System.Text.RegularExpressions;
using FuzzyDates.Exceptions;

namespace FuzzyDates.Parsers
{
	internal class FuzzyDateParserMDY : FuzzyDateParser
	{
		internal override Regex Regex => new Regex(@"^(\d{1,2})\/(\d{1,2})\/(\d{4})$");

		internal override Func<FuzzyDate> Constructor => () =>
		{
			var val1 = Match.Groups[1].Value;
			var val2 = Match.Groups[2].Value;
			var yyyy = Match.Groups[3].Value;

			var int1 = int.Parse(val1);
			var int2 = int.Parse(val2);

			// Is val1 month and val2 day, or is val1 day and val2 month?
			if (int2 > 12)
			{
				return new FuzzyDate(int.Parse(yyyy), int1, int2);
			}
			else if (int1 > 12)
			{
				return new FuzzyDate(int.Parse(yyyy), int2, int1);
			}

			throw new AmbiguousFormatException();
		};
	}
}
