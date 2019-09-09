using System;
using System.Runtime.CompilerServices;
using FuzzyDate.Rules;

[assembly: InternalsVisibleTo("FuzzyDate.Tests")]

namespace FuzzyDate
{
	public class FuzzyDate : IComparable<FuzzyDate>
	{
		public int? Year { get; }
		public int? Month { get; }
		public int? Day { get; }

		public FuzzyDate(DateTime dateTime) : this(dateTime.Year, dateTime.Month, dateTime.Day)
		{
		}

		public FuzzyDate() : this(null, null, null)
		{
		}

		public FuzzyDate(int year, int month, int day) : this((int?)year, month, day)
		{
		}

		public FuzzyDate(int year, int month) : this(year, month, null)
		{
		}

		public FuzzyDate(int year) : this(year, null, null)
		{
		}

		/// <summary>
		/// Gets a FuzzyDate with no value. Equivalent to a constructor with no parameters.
		/// </summary>
		public static FuzzyDate Unknown
		{
			get
			{
				return new FuzzyDate();
			}
		}

		/// <summary>
		/// Gets a FuzzyDate initialized to today's date.
		/// </summary>
		public static FuzzyDate Today
		{
			get
			{
				var now = DateTime.Today;
				return new FuzzyDate(now.Year, now.Month, now.Day);
			}
		}

		private FuzzyDate(int? year, int? month, int? day)
		{
			Year = year;
			Month = month;
			Day = day;

			RulesRunner.RunRules(this);
		}

		/// <summary>
		/// Parses a date from format "YYYY", "YYYY/MM", or "YYYY/MM/DD"
		/// </summary>
		/// <param name="value"></param>
		public static FuzzyDate Parse(string value)
		{
			int? year = null;
			int? month = null;
			int? day = null;

			// Could probably be made more efficient with a regex or something
			if (value.Length >= 4)
			{
				year = int.Parse(value.Substring(0, 4));

				if (value.Length >= 7)
				{
					month = int.Parse(value.Substring(5, 2));

					if (value.Length == 10)
					{
						day = int.Parse(value.Substring(8, 2));
					}
				}
			}

			return new FuzzyDate(year, month, day);
		}

		public int CompareTo(FuzzyDate other)
		{
			// If either date's year is empty, it should go first
			if (!Year.HasValue && !other.Year.HasValue)
				return 0;
			if (Year.HasValue && !other.Year.HasValue)
				return 1;
			if (!Year.HasValue && other.Year.HasValue)
				return -1;

			// If the years are not null and different, compare those
			if (Year.HasValue && other.Year.HasValue && Year.Value != other.Year.Value)
				return Year.Value.CompareTo(other.Year.Value);

			// If either date's month is empty, it should go first
			if (!Month.HasValue && !other.Month.HasValue)
				return 0;
			if (Month.HasValue && !other.Month.HasValue)
				return 1;
			if (!Month.HasValue && other.Month.HasValue)
				return -1;

			// If the months are not null and different, compare those
			if (Month.HasValue && other.Month.HasValue && Month.Value != other.Month.Value)
				return Month.Value.CompareTo(other.Month.Value);

			// If either date's day is empty, it should go first
			if (!Day.HasValue && !other.Day.HasValue)
				return 0;
			if (Day.HasValue && !other.Day.HasValue)
				return 1;
			if (!Day.HasValue && other.Day.HasValue)
				return -1;

			// Finally, compare days
			return Day.Value.CompareTo(other.Day.Value);
		}

		/// <summary>
		/// For testing purposes only. You should be using
		/// some sort of display adapter to control how
		/// dates are displayed to a consumer.
		/// </summary>
		/// <returns>A human-readable string representation of the date.</returns>
		public override string ToString()
		{
			if (!Year.HasValue)
			{
				return "unknown date";
			}

			if (!Month.HasValue)
			{
				return Year.ToString();
			}

			if (!Day.HasValue)
			{
				return new DateTime(Year.Value, Month.Value, 1).ToString("Y");
			}

			return new DateTime(Year.Value, Month.Value, Day.Value).ToString("D");
		}

		/// <summary>
		/// Converts a fuzzy date to a .NET DateTime object. Uses "1" for unknown values.
		/// </summary>
		/// <returns></returns>
		public DateTime ToDateTime()
		{
			// DateTime years must be 1 or greater
			var year = Year.HasValue
				? Math.Max(Year.Value, 1)
				: 1;

			return new DateTime(year, Month ?? 1, Day ?? 1);
		}
	}
}
