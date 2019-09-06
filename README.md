# FuzzyDate
A library for defining date objects where the month and day may not be known.

# Features

## FuzzyDate

* Several ways to construct:
  * Construct objects from int values directly (`new FuzzyDate(2019, 9)`)
  * Construct using a standard string format (`new FuzzyDate("2019/09")`)
  * Construct static constructors, e.g. from today's actual date (`FuzzyDate.Today`)
* Built-in argument validation and error handling
* Convert out to a .NET DateTime or a formatted string

## FuzzyDateRange

Defines a date range bound by two FuzzyDate objects.

* Built-in validation and error handling (keeps the range chronological)
* Convert out to a .NET TimeSpan or a formatted string
