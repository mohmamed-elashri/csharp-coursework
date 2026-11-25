# Simple Calculator

Reads two numbers and one operator (+, -, *, /) and prints the result.

## Run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (the project file targets .NET 8).

```
cd 03-simple-calculator
dotnet run
```

## Concepts practised

`switch` statements, `char` input with `Console.ReadKey`, a helper method (`GetValidNumber`) that re-prompts until the input parses, guarding against division by zero.

## Example session

```
Enter first number: 8
Enter an operator (+, -, *, /): /
Enter second number: 2
Result: 4
```

## Known limitations

Handles one operation per run. Division by zero and unknown operators print an error and exit.

## Origin

`Program.cs` is the original, unmodified file from the repository `Simple-Calculator-App` (uploaded February 2025). Only this README and the `.csproj` were added when the exercises were collected here.
