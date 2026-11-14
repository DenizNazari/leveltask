<img src="assets/chibi-dragon.gif" align="right" width="130" alt="Chibi Dragon Mascot" />

<div align="center">

# 🐉 The C# Player's Guide — Quest Log & XP Tracker

### Level up from Apprentice to True Programmer, one challenge at a time.

**An interactive C# console & WinForms quest hub containing my solutions to the challenges and Boss Battles from *The C# Player's Guide (5th Edition)*, paired with an RPG progression log synced with [xp-tracker.sor.nz](https://xp-tracker.sor.nz/).**

![Level](https://img.shields.io/badge/Character%20Level-6-blueviolet?style=for-the-badge)
![XP](https://img.shields.io/badge/Total%20XP-3%2C650%20%2F%2012%2C125-gold?style=for-the-badge)
![Quests](https://img.shields.io/badge/Challenges%20Cleared-41%20%2F%20114-success?style=for-the-badge)
![DotNet](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## ⚔️ Character Sheet & XP Progression

> Tracked via [**C# Player's Guide XP Tracker**](https://xp-tracker.sor.nz/) · Formula: `XP Threshold = (Level² × 100) - (100 × Level)` (+25 Base Starting XP)

| Stat | Value |
|---|---|
| **Current Level** | **Level 6** *(550 XP away from Level 7!)* |
| **Total XP** | **3,650 XP** *(3,625 Quest XP + 25 Starting XP)* / 12,125 XP |
| **Challenges Cleared** | **41 / 114** *(24 implemented project tasks + Part 1–2 basics & checks)* |
| **Part 1: The Basics** | `2,275 / 2,275 XP` (27 / 27) 🏆 |
| **Part 2: Object-Oriented Programming** | `1,350 / 3,800 XP` (14 / 33) |
| **Part 3: Advanced Features** | `0 / 2,350 XP` (0 / 33) |
| **Part 4: The Endgame** | `0 / 3,600 XP` (0 / 18) |
| **Part 5: Bonus Levels** | `0 / 75 XP` (0 / 3) |

### 📊 Level Map (Levels 1 – 10)

| Level | Required XP | Status |
|---|---|---|
| **Level 1** | 0 XP | ✅ Unlocked |
| **Level 2** | 200 XP | ✅ Unlocked |
| **Level 3** | 600 XP | ✅ Unlocked |
| **Level 4** | 1,200 XP | ✅ Unlocked |
| **Level 5** | 2,000 XP | ✅ Unlocked |
| **Level 6** | 3,000 XP | ✅ **Current Level** (`3,650 XP`) |
| **Level 7** | 4,200 XP | 🔒 *550 XP needed* |
| **Level 8** | 5,600 XP | 🔒 Locked |
| **Level 9** | 7,200 XP | 🔒 Locked |
| **Level 10** | 9,000 XP | 🔒 Max Level |

---

## 📜 Quest Log (24 Completed Quests)

All 24 solved challenges can be launched directly from the interactive menu in [`Program.cs`](Program.cs) (including the WinForms **15-Puzzle Boss Battle** in [`BossBattlePuzzle15`](./BossBattlePuzzle15)).

| Status | # | Quest Name | Book Part / Topic | XP | Folder |
|---|---|---|---|---|---|
| ✅ | 01 | [The Triangle Farmer](./Tasks/new-redesign/01-The-Triangle-Farmer) | Part 1 · Level 6: The C# Type System | 100 XP | `01-The-Triangle-Farmer` |
| ✅ | 02 | [The Variable Shop & Returns](./Tasks/new-redesign/02-The-Variable-Shop-And-Type-Limits) | Part 1 · Level 6–7: Types & Overflow | 150 XP | `02-The-Variable-Shop-And-Type-Limits` |
| ✅ | 03 | [The Four Sisters and the Duckbear](./Tasks/new-redesign/03-The-Four-Sisters-and-the-Duckbear) | Part 1 · Level 7: Math (`/` & `%`) | 100 XP | `03-The-Four-Sisters-and-the-Duckbear` |
| ✅ | 04 | [The Dominion of Kings](./Tasks/new-redesign/04-The-Dominion-of-Kings) | Part 1 · Level 7: Math | 100 XP | `04-The-Dominion-of-Kings` |
| ✅ | 05 | [The Defense of Consolas](./Tasks/new-redesign/05-The-Defense-of-Consolas) | Part 1 · Level 8: Console 2.0 | 200 XP | `05-The-Defense-of-Consolas` |
| ✅ | 06 | [Repairing the Clocktower](./Tasks/new-redesign/06-Repairing-the-Clocktower) | Part 1 · Level 9: Decision Making | 100 XP | `06-Repairing-the-Clocktower` |
| ✅ | 07 | [Watchtower](./Tasks/new-redesign/07-Watchtower) | Part 1 · Level 9: Coordinates & Logic | 100 XP | `07-Watchtower` |
| ✅ | 08 | [Buying & Discounted Inventory](./Tasks/new-redesign/08-Buying-and-Discounted-Inventory) | Part 1 · Level 10: Switches & Ternary | 150 XP | `08-Buying-and-Discounted-Inventory` |
| ✅ | 09 | [The Prototype](./Tasks/new-redesign/09-The-Prototype) | Part 1 · Level 11: Looping (`while`) | 100 XP | `09-The-Prototype` |
| ✅ | 10 | [The Magic Cannon](./Tasks/new-redesign/10-The-Magic-Cannon) | Part 1 · Level 11: Looping (`for`, `do-while`) | 100 XP | `10-The-Magic-Cannon` |
| ✅ | 11 | [The Replicator of D'To](./Tasks/new-redesign/11-The-Replicator-of-DTo) | Part 1 · Level 12: Arrays (`for`) | 100 XP | `11-The-Replicator-of-DTo` |
| ✅ | 12 | [The Laws of Freach](./Tasks/new-redesign/12-The-Laws-of-Freach) | Part 1 · Level 12: Arrays (`foreach`) | 50 XP | `12-The-Laws-of-Freach` |
| ✅ | 13 | [Taking a Number](./Tasks/new-redesign/13-Taking-a-Number) | Part 1 · Level 13: Methods & Overloading | 100 XP | `13-Taking-a-Number` |
| ✅ | 14 | [Hunting the Manticore (Boss Battle)](./Tasks/new-redesign/14-Hunting-the-Manticore) | Part 1 · Level 14: Memory Management | 250 XP | `14-Hunting-the-Manticore` |
| ✅ | 15 | [Simula's Test](./Tasks/new-redesign/15-Simulas-Test) | Part 2 · Level 16: Enumerations | 100 XP | `15-Simulas-Test` |
| ✅ | 16 | [Simula's Soup](./Tasks/new-redesign/16-Simulas-Soup) | Part 2 · Level 17: Tuples | 100 XP | `16-Simulas-Soup` |
| ✅ | 17 | [Vin Fletcher's Arrows](./Tasks/new-redesign/17-Vin-Fletchers-Arrows) | Part 2 · Level 18–21: Classes & Static | 100 XP | `17-Vin-Fletchers-Arrows` |
| ✅ | 18 | [The Point](./Tasks/new-redesign/18-The-Point) | Part 2 · Level 24: Catacombs of the Class | 75 XP | `18-The-Point` |
| ✅ | 19 | [The Color](./Tasks/new-redesign/19-The-Color) | Part 2 · Level 24: Catacombs of the Class | 100 XP | `19-The-Color` |
| ✅ | 20 | [The Card](./Tasks/new-redesign/20-The-Card) | Part 2 · Level 24: Catacombs of the Class | 100 XP | `20-The-Card` |
| ✅ | 21 | [The Locked Door](./Tasks/new-redesign/21-The-Locked-Door) | Part 2 · Level 24: State Management | 100 XP | `21-The-Locked-Door` |
| ✅ | 22 | [The Password Validator](./Tasks/new-redesign/22-The-Password-Validator) | Part 2 · Level 24: Validation | 100 XP | `22-The-Password-Validator` |
| ✅ | 23 | [Rock-Paper-Scissors](./Tasks/new-redesign/23-Rock-Paper-Scissors) | Part 2 · Level 24: OOP Design & File I/O | 150 XP | `23-Rock-Paper-Scissors` |
| ✅ | 24 | [The 15-Puzzle (Boss Battle)](./Tasks/new-redesign/24-15-Puzzle) | Part 2 · Level 24: OOP & WinForms GUI | 150 XP | `24-15-Puzzle` |

---

## 🗺️ Full XP Tracker Checklist (114 Challenges)

<details>
<summary><b>Part 1: The Basics (27 / 27 Completed · 2,275 / 2,275 XP) 🏆</b></summary>

- [x] Knowledge Check - C# (25 XP)
- [x] Install Visual Studio (75 XP)
- [x] Hello, World! (50 XP)
- [x] What Comes Next (50 XP)
- [x] The Makings of a Programmer (50 XP)
- [x] Consolas and Telim (50 XP)
- [x] The Thing Namer 3000 (100 XP)
- [x] Knowledge Check - Variables (25 XP)
- [x] **The Variable Shop** (100 XP) — [Task 02](./Tasks/new-redesign/02-The-Variable-Shop-And-Type-Limits)
- [x] **The Variable Shop Returns** (50 XP) — [Task 02](./Tasks/new-redesign/02-The-Variable-Shop-And-Type-Limits)
- [x] Knowledge Check - Type System (25 XP)
- [x] **The Triangle Farmer** (100 XP) — [Task 01](./Tasks/new-redesign/01-The-Triangle-Farmer)
- [x] **The Four Sisters and the Duckbear** (100 XP) — [Task 03](./Tasks/new-redesign/03-The-Four-Sisters-and-the-Duckbear)
- [x] **The Dominion of Kings** (100 XP) — [Task 04](./Tasks/new-redesign/04-The-Dominion-of-Kings)
- [x] **The Defense of Consolas** (200 XP) — [Task 05](./Tasks/new-redesign/05-The-Defense-of-Consolas)
- [x] **Repairing the Clocktower** (100 XP) — [Task 06](./Tasks/new-redesign/06-Repairing-the-Clocktower)
- [x] **Watchtower** (100 XP) — [Task 07](./Tasks/new-redesign/07-Watchtower)
- [x] **Buying Inventory** (100 XP) — [Task 08](./Tasks/new-redesign/08-Buying-and-Discounted-Inventory)
- [x] **Discounted Inventory** (50 XP) — [Task 08](./Tasks/new-redesign/08-Buying-and-Discounted-Inventory)
- [x] **The Prototype** (100 XP) — [Task 09](./Tasks/new-redesign/09-The-Prototype)
- [x] **The Magic Cannon** (100 XP) — [Task 10](./Tasks/new-redesign/10-The-Magic-Cannon)
- [x] **The Replicator of D’To** (100 XP) — [Task 11](./Tasks/new-redesign/11-The-Replicator-of-DTo)
- [x] **The Laws of Freach** (50 XP) — [Task 12](./Tasks/new-redesign/12-The-Laws-of-Freach)
- [x] **Taking a Number** (100 XP) — [Task 13](./Tasks/new-redesign/13-Taking-a-Number)
- [x] Countdown (100 XP)
- [x] Knowledge Check - Memory (25 XP)
- [x] **Hunting the Manticore** (250 XP) — [Task 14](./Tasks/new-redesign/14-Hunting-the-Manticore)

</details>

<details>
<summary><b>Part 2: Object-Oriented Programming (14 / 33 Completed · 1,350 / 3,800 XP)</b></summary>

- [x] Knowledge Check - Objects (25 XP)
- [x] **Simula’s Test** (100 XP) — [Task 15](./Tasks/new-redesign/15-Simulas-Test)
- [x] **Simula’s Soups** (100 XP) — [Task 16](./Tasks/new-redesign/16-Simulas-Soup)
- [x] **Vin Fletcher’s Arrows** (100 XP) — [Task 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] Vin’s Trouble (50 XP) — [Task 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] The Properties of Arrows (100 XP) — [Task 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] Arrow Factories (100 XP) — [Task 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] **The Point** (75 XP) — [Task 18](./Tasks/new-redesign/18-The-Point)
- [x] **The Color** (100 XP) — [Task 19](./Tasks/new-redesign/19-The-Color)
- [x] **The Card** (100 XP) — [Task 20](./Tasks/new-redesign/20-The-Card)
- [x] **The Locked Door** (100 XP) — [Task 21](./Tasks/new-redesign/21-The-Locked-Door)
- [x] **The Password Validator** (100 XP) — [Task 22](./Tasks/new-redesign/22-The-Password-Validator)
- [x] **Rock-Paper-Scissors** (150 XP) — [Task 23](./Tasks/new-redesign/23-Rock-Paper-Scissors)
- [x] **15-Puzzle** (150 XP) — [Task 24](./Tasks/new-redesign/24-15-Puzzle)
- [ ] Hangman (150 XP) *(Next Quest!)*
- [ ] Tic-Tac-Toe (300 XP)
- [ ] Packing Inventory (150 XP)
- [ ] Labeling Inventory (50 XP)
- [ ] The Old Robot (200 XP)
- [ ] Robotic Interface (75 XP)
- [ ] Room Coordinates (50 XP)
- [ ] War Preparations (100 XP)
- [ ] Colored Items (100 XP)
- [ ] The Fountain of Objects (500 XP)
- [ ] Small, Medium, or Large (100 XP)
- [ ] Pits (100 XP)
- [ ] Maelstroms (100 XP)
- [ ] Amaroks (100 XP)
- [ ] Getting Armed (100 XP)
- [ ] Getting Help (100 XP)
- [ ] The Robot Pilot (50 XP)
- [ ] Time in the Cavern (50 XP)
- [ ] Lists of Commands (75 XP)

</details>

<details>
<summary><b>Part 3: Advanced Features (0 / 33 Completed · 0 / 2,350 XP)</b></summary>

- [ ] Knowledge Check - Large Programs (25 XP)
- [ ] The Feud (75 XP)
- [ ] Dueling Traditions (100 XP)
- [ ] Safer Number Crunching (50 XP)
- [ ] Knowledge Check - Methods (25 XP)
- [ ] Better Random (100 XP)
- [ ] Exepti’s Game (100 XP)
- [ ] The Sieve (100 XP)
- [ ] Knowledge Check - Events (25 XP)
- [ ] Charberry Trees (100 XP)
- [ ] Knowledge Check - Lambdas (25 XP)
- [ ] The Lambda Sieve (50 XP)
- [ ] The Long Game (100 XP)
- [ ] The Potion Masters of Pattren (150 XP)
- [ ] Knowledge Check - Operators (25 XP)
- [ ] Navigating Operand City (100 XP)
- [ ] Indexing Operand City (75 XP)
- [ ] Converting Directions to Offsets (50 XP)
- [ ] Knowledge Check - Queries (25 XP)
- [ ] The Three Lenses (100 XP)
- [ ] The Repeating Stream (150 XP)
- [ ] Knowledge Check - Async (25 XP)
- [ ] Asynchronous Random Words (150 XP)
- [ ] Many Random Words (50 XP)
- [ ] Uniter of Adds (75 XP)
- [ ] The Robot Factory (100 XP)
- [ ] Knowledge Check - Unsafe Code (25 XP)
- [ ] Knowledge Check - Other Features (25 XP)
- [ ] Colored Console (100 XP)
- [ ] The Great Humanizer (100 XP)
- [ ] Knowledge Check - Compiling (25 XP)
- [ ] Knowledge Check - .NET (25 XP)
- [ ] Altar of Publication (100 XP)

</details>

<details>
<summary><b>Part 4: The Endgame (0 / 18 Completed · 0 / 3,600 XP)</b></summary>

- [ ] Core Game: Building Character (300 XP)
- [ ] Core Game: The True Programmer (100 XP)
- [ ] Core Game: Actions and Players (300 XP)
- [ ] Core Game: Attacks (200 XP)
- [ ] Core Game: Damage and HP (150 XP)
- [ ] Core Game: Death (150 XP)
- [ ] Core Game: Battle Series (150 XP)
- [ ] Core Game: The Uncoded One (100 XP)
- [ ] Core Game: The Player Decides (200 XP)
- [ ] Expansion: The Game’s Status (100 XP)
- [ ] Expansion: Items (200 XP)
- [ ] Expansion: Gear (300 XP)
- [ ] Expansion: Stolen Inventory (200 XP)
- [ ] Expansion: Vin Fletcher (200 XP)
- [ ] Expansion: Attack Modifiers (200 XP)
- [ ] Expansion: Damage Types (200 XP)
- [ ] Expansion: Making it Yours (400 XP)
- [ ] Expansion: Restoring Balance (150 XP)

</details>

<details>
<summary><b>Part 5: Bonus Levels (0 / 3 Completed · 0 / 75 XP)</b></summary>

- [ ] Knowledge Check - Visual Studio (25 XP)
- [ ] Knowledge Check - Compiler Errors (25 XP)
- [ ] Knowledge Check - Debugging (25 XP)

</details>

---

## 🚀 How to Run the Quest Hub

```bash
dotnet run --project leveltask.csproj
```

Select any quest (`1–24`) from the interactive console menu to run it directly.
