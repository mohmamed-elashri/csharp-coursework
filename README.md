# C# Coursework

Six small console programs written as introductory university coursework while learning C# fundamentals. Each exercise lives in its own folder with a README (how to run it, which concepts it practises, known limitations).

These are learning exercises, not production code. They are kept as written, so some inputs are not validated.

## Exercises

| Exercise | What it does | Original repository |
| --- | --- | --- |
| [Grade Calculator](01-grade-calculator/) | Reads a numeric score and prints a letter grade band (A to F). | `Grade-Calculator` |
| [Number Guessing Game](02-number-guessing-game/) | The program picks a random number from 1 to 100 and the player guesses it with too-low and too-high hints. | `Number-Guessing-Game` |
| [Simple Calculator](03-simple-calculator/) | Reads two numbers and one operator (+, -, *, /) and prints the result. | `Simple-Calculator-App` |
| [Shape Area Calculator](04-shape-area-calculator/) | Menu to compute the area of a circle, rectangle, triangle or square. | `Shape-Area-Calculator` |
| [Text Analyzer](05-text-analyzer/) | Reads one line of text, counts characters and words, finds the five most frequent words and saves a report to `Report.txt`. | `TextAnalyzer` |
| [Donation and Aid Tracking System](06-donation-aid-tracking-system/) | Console menu to add donations, list them and print the total collected. Data is kept in memory only. | `Donation-Aid-Tracking-System` |

## Running an exercise

Install the [.NET SDK](https://dotnet.microsoft.com/download) (8.0 or later), then:

```
cd 01-grade-calculator
dotnet run
```

The `.csproj` files in each folder were added when the exercises were collected here. The `Program.cs` files are unchanged copies of the originals.

## Status

The programs were not compiled or run as part of preparing this repository (no .NET SDK was available), so run instructions are untested.
