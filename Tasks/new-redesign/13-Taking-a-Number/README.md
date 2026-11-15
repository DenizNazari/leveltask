<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Quest Scroll" />

<div align="center">

# 🔢 13 - Taking a Number

### Reusable helper methods for prompting and range-validating integer console input.

![Level](https://img.shields.io/badge/Level-13%3A%20Methods-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Methods%20%26%20Validation-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Taking a Number — 100 XP)

**Level 13 — Methods:**
Many previous tasks have required getting a number from a user. To save time writing this code repeatedly, you decide to make reusable methods to handle this common task.

### Objectives:
- Make a method with the signature `int AskForNumber(string text)` that displays the `text` parameter in the console window, reads a response from the user, converts it to an `int`, and returns it:
  ```csharp
  int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
  ```
- Make a second method with the signature `int AskForNumberInRange(string text, int min, int max)` that only returns if the entered number is between `min` and `max`, prompting again otherwise.
- Place these methods in at least one previous or subsequent program to improve it.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- **Basic Prompt Helper (`askForNumber(string text)`):** Prints `text` to the console and returns `int.Parse(Console.ReadLine())`.
- **Range-Validated Helper (`askforNumber(string text, int min, int max)`):** Displays the allowed `[min, max]` bounds and loops inside `while (true)` until the parsed integer satisfies `number >= min && number <= max`.
- Reused this range-validated helper directly in **`14 - Hunting the Manticore`** to collect the Manticore's distance (`1–100`).

---

## 📁 Files

- [`Program.cs`](Program.cs) — `askForNumber` helper methods (`LevelTask.Task13.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 12 - The Laws of Freach](../12-The-Laws-of-Freach/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [14 - Hunting the Manticore ➡️](../14-Hunting-the-Manticore/README.md)

</div>
