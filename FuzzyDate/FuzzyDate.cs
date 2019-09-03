﻿using System;

namespace FuzzyDate
{
	public class FuzzyDate : IComparable<FuzzyDate>
	{
		public int? Year { get; }
		public int? Month { get; }
		public int? Day { get; }

		public FuzzyDate()
		{
		}

		public FuzzyDate(int year, int month, int day)
		{
			Year = year;
			Month = month;
			Day = day;
		}

		public FuzzyDate(int year, int month)
		{
			Year = year;
			Month = month;
		}

		public FuzzyDate(int year)
		{
			Year = year;
		}

		public FuzzyDate(string value)
		{
			// Of format "YYYY/MM/DD" where MM and DD are optional
			// Could definitely be made more efficient(?) with a regex or something
			if (value.Length >= 4)
			{
				Year = int.Parse(value.Substring(0, 4));

				if (value.Length >= 7)
				{
					Month = int.Parse(value.Substring(5, 2));

					if (value.Length == 10)
					{
						Day = int.Parse(value.Substring(8, 2));
					}
				}
			}
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
		/// <returns></returns>
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
	}
}