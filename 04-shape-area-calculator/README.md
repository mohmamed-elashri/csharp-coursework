# Shape Area Calculator

Menu to compute the area of a circle, rectangle, triangle or square.

## Run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (the project file targets .NET 8).

```
cd 04-shape-area-calculator
dotnet run
```

## Concepts practised

`switch` with integer menu choices, `Math.PI`, `double` arithmetic, variables scoped per case.

## Example session

```
Choose a shape (1-4): 1
Enter the radius: 2

The area is: 12.566370614359172
```

## Known limitations

Input is parsed with `Convert`, so invalid text throws a `FormatException`. Negative values are not rejected.

## Origin

`Program.cs` is the original, unmodified file from the repository `Shape-Area-Calculator` (uploaded February 2025). Only this README and the `.csproj` were added when the exercises were collected here.
