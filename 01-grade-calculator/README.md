# Grade Calculator

Reads a numeric score and prints a letter grade band (A to F).

## Run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (the project file targets .NET 8).

```
cd 01-grade-calculator
dotnet run
```

## Concepts practised

if / else if chains, comparison operators, string variables, `Convert.ToDouble`.

## Example session

```
Enter your score: 85

Your Grade: Very Good (B)
```

## Known limitations

Input is parsed with `Convert.ToDouble`, so non-numeric input throws a `FormatException`. Scores outside 0 to 100 are not rejected.

## Origin

`Program.cs` is the original, unmodified file from the repository `Grade-Calculator` (uploaded February 2025). Only this README and the `.csproj` were added when the exercises were collected here.
