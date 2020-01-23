namespace FuzzyDates
{
	internal class Constants
	{
		internal static int YearMin => 1;
		internal static int YearMax => 9999;

		internal static int MonthMin => (int)Months.January;
		internal static int MonthMax => (int)Months.December;

		internal static int DayMin => 1;
		internal static int DayMax => 31;

		internal static int DefaultMonth => (int)Months.January;
		internal static int DefaultDay => 1;

		internal static int MonthsInYear => (int)Months.December;

		private enum Months
		{
			January = 1,
			February = 2,
			March = 3,
			April = 4,
			May = 5,
			June = 6,
			July = 7,
			August = 8,
			September = 9,
			October = 10,
			November = 11,
			December = 12
		}
	}
}
