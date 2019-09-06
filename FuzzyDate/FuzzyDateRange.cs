using System;
using FuzzyDate.Rules;

namespace FuzzyDate
{
	public class FuzzyDateRange
	{
		public FuzzyDate From { get; }
		public FuzzyDate To { get; }

		public FuzzyDateRange(FuzzyDate from, FuzzyDate to)
		{
			From = from ?? FuzzyDate.Unknown;
			To = to ?? FuzzyDate.Unknown;

			RulesRunner.RunRules(this);
		}

		/// <summary>
		/// For testing purposes only. You should be using
		/// some sort of display adapter to control how
		/// dates are displayed to a consumer.
		/// </summary>
		/// <returns>A human-readable string representation of the date range.</returns>
		public override string ToString()
		{
			return $"{From}-{To}";
		}

		public TimeSpan ToTimeSpan()
		{
			var from = From.ToDateTime();
			var to = To.ToDateTime();
			return to - from;
		}
	}
}
