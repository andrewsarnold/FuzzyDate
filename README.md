# FuzzyDates
A library for defining date objects where the month and day may not be known. Dates can be constructed, converted, and serialized in several ways. Date ranges are also supported.

# Documentation

## FuzzyDate usage

### Construction

The `FuzzyDate` type is a struct with three properties: `Year`, `Month`, and `Day`, all nullable ints.

Available constructors:

```c#
// Directly with integer values
var a = new FuzzyDate();
var b = new FuzzyDate(2020);
var c = new FuzzyDate(2020, 1);
var d = new FuzzyDate(2020, 1, 23);

// As a struct
var e = new FuzzyDate
{
    Year = 2020,
    Month = 1
};

// Indirectly with a DateTime object
var f = new FuzzyDate(DateTime.Today);

// Built-in default values
var g = FuzzyDate.Unknown; // all null values
var h = FuzzyDate.Today;

// Parse from a string. Accepts forward slash "/", space " ", period ".", and hyphen "-".
// Accepts "YYYY", "YYYY/MM", "YYYY/MM/DD", "MM/YYYY", "DD/MM/YYYY"*,
// "MM/DD/YYYY"*, "M/YYYY", "YYYY/M", "DD/M/YYYY", and "YYYY/M/DD".
// (*Will throw an error if it can't differentiate between MM and DD.)
var i = FuzzyDate.Parse("2020/01/03");
```

### Comparison

The `CompareTo` method is defined and will return -1 or 1 if two FuzzyDates can be said to be *definitively* before or after each other. Additionally, if missing data makes it impossible to determine which is earlier, the FuzzyDate that is missing the most data will be considered to be "before" the other.

Examples (-1 = first is before; 0 = equivalent; 1 = second is before):

| First | Second | Result |
|:------|:-------|--------|
| null | null | 0 |
| null | 2020 | -1 |
| 2020 | 2020 | 0 |
| 2020 | 2020, 1 | -1 |
| 2020, 1 | 2020 | 1 |
| 2020 | 2020, 1, 23 | -1 |
| 2020, 1 | 2020, 1, 23 | -1 |
| 2020 | 2020, 1, 23 | -1 |

### Conversion

Use `.ToIso8601()` to render an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) compatible string:

| FuzzyDate | ISO 8601 |
|:------|:-------|
| null | `""` |
| 2020 | `"2020"` |
| 2020, 1 | `"2020-01"` |
| 2020, 1, 23 | `"2020-01-23"` |

Use `ToDateTime()` to convert to a .NET DateTime object, using `1` for missing values:
``` c#
DateTime dt = new FuzzyDate(2020).ToDateTime();
// dt = 2020/1/1 0:00:00
```

FuzzyDate also implements `ISerializable`.

### Modification

While the `Year`, `Month`, and `Day` values are exposed as ints and thus can be manually modified, the library also provides built-in methods to add years, months, and days while still keeping the dates valid.

Examples:
``` c#
var a = new FuzzyDate(2020, 1, 23).AddDays(45); // result: 2020/03/08
var b = new FuzzyDate(2020, 5).AddMonths(-5); // result: 2019/12
var c = new FuzzyDate(2020).AddMonths(-5); // result: 2019/12
```

## FuzzyDateRange usage

### Construction

The `FuzzyDateRange` type is a struct with two properties: `From` and `To`, both FuzzyDates. Either or both may be null, or FuzzyDates with none of their internal values set.

Available constructors:

```c#
// Directly with FuzzyDate values
var a = new FuzzyDateRange(new FuzzyDate(2019), new FuzzyDate(2020, 1, 23));

// As a struct
var b = new FuzzyDateRange
{
    From = new FuzzyDate(2019),
    To = new FuzzyDate(2020, 1, 23)
};

// Parse from a string. Accepts hyphen "-", en dash "–", em dash "—", minus sign "−", and "to".
var c = FuzzyDateRange.Parse("2019/12/13-2020/01/03");
```

### Conversion

Use `.ToIso8601()` to render an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) compatible string. For example, `new FuzzyDateRange(new FuzzyDate(2019, 4, 5), new FuzzyDate(2020, 1, 22))` converts to `"2019-04-05/2020-01-22"`.

Use `.ToTimeSpan()` to convert to a .NET TimeSpan object, using the built-in `FuzzyDate.ToDateTime()` method internally.

FuzzyDateRange also implements `ISerializable`.
