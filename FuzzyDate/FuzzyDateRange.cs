using System;
using System.Runtime.Serialization;
using FuzzyDate.Rules;

namespace FuzzyDate
{
	public class FuzzyDateRange : IComparable<FuzzyDateRange>, ISerializable
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

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException(nameof(info));
			}

			info.AddValue("From", From);
			info.AddValue("To", To);
		}

		public int CompareTo(FuzzyDateRange other)
		{
			var fromCompare = From.CompareTo(other.From);
			if (fromCompare != 0)
			{
				return fromCompare;
			}

			return To.CompareTo(other.To);
		}
	}
}
