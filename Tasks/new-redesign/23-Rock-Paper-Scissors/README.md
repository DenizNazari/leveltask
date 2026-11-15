<img src="../../../assets/crown.gif" align="right" width="96" alt="Arena Crown" />

<div align="center">

# 🪨📄✂️ 23 - Boss Battle: Rock-Paper-Scissors

### Two-player object-oriented Rock-Paper-Scissors game featuring hidden key input (`ReadKey`) and persistent match history (`StreamWriter`).

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20File%20I%2FO-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: Rock-Paper-Scissors — 150 XP)

**Level 24 — The Catacombs of the Class (First Design Pedestal):**
The first design pedestal asks for an object-oriented design (classes, objects, and their interactions) for the game of **Rock-Paper-Scissors**:

- Two human players compete against one another.
- Each player chooses `Rock`, `Paper`, or `Scissors`.
- Round winner rules: **Rock beats Scissors, Scissors beats Paper, Paper beats Rock.** Choosing the same option results in a draw.
- The game displays the winner of each round.
- Rounds continue until the game ends, maintaining a running historical record of each player's win count and total draws.

### Objectives:
- Outline the objects and classes needed to build Rock-Paper-Scissors using CRC cards (or a suitable alternative).

---

## 🛠️ How I Built It (Architecture & Implementation Details)

Although the book only asked for a conceptual class/CRC design on paper, I turned the object-oriented design into a **fully playable two-player C# console game** where both players can play on the same keyboard without seeing each other's moves and save the final match summary to disk.

### 1. Object-Oriented Class Design (`RockPaperScissors`, `Player`, `rockpercentageEnum`)
- **`Player` Class:** Encapsulates each player's `Name`, cumulative `Score`, and current round choice (`playerChoise`) with `private set` accessors. Score updates are strictly controlled via `IncrementScore()` and move selection via `SetChoice(rockpercentageEnum choice)`.
- **`RockPaperScissors` Engine Class:** Coordinates both `Player` instances (`Player1`, `Player2`), the round counter (`raund`), and the draw counter (`draw`).
- **Computed Properties (Expression-Bodied):** Overall match `Winner` and `Loser` are evaluated dynamically from live player scores:
  ```csharp
  public string Winner => Player1.Score > Player2.Score ? Player1.Name : Player1.Score < Player2.Score ? Player2.Name : "Tie";
  public string Loser  => Player1.Score < Player2.Score ? Player1.Name : Player1.Score > Player2.Score ? Player2.Name : "Tie";
  ```

### 2. Hidden Move Input (`Console.ReadKey(true)` & `switch` Expression)
So that Player 2 cannot see what Player 1 typed when sharing the same keyboard, I used **`Console.ReadKey(intercept: true)`** instead of `Console.ReadLine()`:
- Pressing `R`, `P`, or `S` intercepts the keystroke without echoing it to the console window.
- A C# `switch` expression maps the key directly to the move; invalid keys evaluate to `null` and prompt the same player again.

### 3. Persistent Score Logging (`StreamWriter` & `SaveScoresToFile`)
When players press `F` at the end of a round to finish the session, `SaveScoresToFile()` writes a complete summary—final scores, total rounds played (`raund`), overall `Winner`, and `Loser`—into `RockPaperScissorsScores.txt` using a `StreamWriter`.

---

## 📁 Files

- [`Program.cs`](Program.cs) — Full game implementation containing `RockPaperScissors`, `Player`, and `rockpercentageEnum` (`LevelTask.Task23.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 22 - The Password Validator](../22-The-Password-Validator/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [24 - The 15-Puzzle ➡️](../24-15-Puzzle/README.md)

</div>
