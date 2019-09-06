# FuzzyDate
A library for defining date objects where the month and day may not be known.

# Features
* Construct objects from int values directly (`new FuzzyDate(2019, 9)`)
* Or construct using a standard string format (`new FuzzyDate("2019/09")`)
* Built-in argument validation and error handling
* Convert out to a .NET DateTime, a formatted string, or a standardized string object
