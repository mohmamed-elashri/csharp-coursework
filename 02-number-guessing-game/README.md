# Number Guessing Game

The program picks a random number from 1 to 100 and the player guesses it with too-low and too-high hints.

## Run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (the project file targets .NET 8).

```
cd 02-number-guessing-game
dotnet run
```

## Concepts practised

`Random`, `while` loops, `int.TryParse` input validation, counters, `continue`.

## Example session

```
Enter your guess: 50
Too high! Try again.
Enter your guess: 25
Congratulations! You guessed the number in 2 attempts.
Thank you for playing!
```

## Known limitations

Guesses outside 1 to 100 are accepted and counted as attempts. The game ends only on a correct guess.

## Origin

`Program.cs` is the original, unmodified file from the repository `Number-Guessing-Game` (uploaded February 2025). Only this README and the `.csproj` were added when the exercises were collected here.
