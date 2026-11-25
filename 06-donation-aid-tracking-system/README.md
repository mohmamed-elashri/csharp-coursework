# Donation and Aid Tracking System

Console menu to add donations, list them and print the total collected. Data is kept in memory only.

## Run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (the project file targets .NET 8).

```
cd 06-donation-aid-tracking-system
dotnet run
```

## Concepts practised

Classes and properties (`Donation`), `List<T>`, menu loop with `switch`, `double.TryParse`, `DateTime.Now`, string interpolation.

## Example session

```
Donation & Aid Tracking System
1. Add Donation
2. View Donations
3. Generate Report
4. Exit
Choose an option: 1
Enter donor name: Sara
Enter donation amount: 50
Donation added successfully.
```

## Known limitations

Nothing is saved to disk: records are lost when the program exits. Amounts are stored as `double` and printed with a dollar sign without currency formatting.

## Origin

`Program.cs` is the original, unmodified file from the repository `Donation-Aid-Tracking-System` (uploaded February 2025). Only this README and the `.csproj` were added when the exercises were collected here.
