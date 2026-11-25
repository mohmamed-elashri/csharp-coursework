# Text Analyzer

Reads one line of text, counts characters and words, finds the five most frequent words and saves a report to `Report.txt`.

## Run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (the project file targets .NET 8).

```
cd 05-text-analyzer
dotnet run
```

## Concepts practised

`string.Split`, `Dictionary<string,int>` for word counts, LINQ (`OrderByDescending`, `Take`), file output with `File.WriteAllText`.

## Example session

```
Enter the text you want to analyze:
the cat and the dog

Character count: 19
Word count: 5

Most frequent words:
  - the: 2 times
  - cat: 1 times
  - and: 1 times
  - dog: 1 times

The report has been saved to Report.txt
```

## Known limitations

Reads a single line only. Word counting uses a different separator set for the total (spaces and tabs) than for frequencies (also punctuation), so the two can differ on punctuated text.

## Origin

`Program.cs` is the original, unmodified file from the repository `TextAnalyzer` (uploaded February 2025). Only this README and the `.csproj` were added when the exercises were collected here.
