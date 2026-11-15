<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Hangman Scroll" />

<div align="center">

# 🪢 25 - Boss Battle: Hangman

### Object-oriented Hangman console game featuring underscore word masking, single-keystroke letter guessing (`ReadKey`), and wrong-letter tracking.

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20String%20Manipulation-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: Hangman — 150 XP)

**Level 24 — The Catacombs of the Class (Third Design Pedestal):**
The third design pedestal asks for an object-oriented design for the word-guessing game **Hangman**:

- The game stores a secret word and displays unguessed characters as underscores (`_`).
- On each turn, the player guesses a single letter; matching letters are revealed in all matching positions, while incorrect guesses decrement the remaining attempts and are added to the wrong-letters list.
- The player wins by revealing the entire word before running out of attempts.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

Rather than stopping at a conceptual paper design, I implemented the `Hangman` class and interactive console loop in C#:

- **`Hangman` Class & Word Masking:** The constructor stores `WordToGuess` and initializes `CurrentWordState = new string('_', wordToGuess.Length)` with `private set` encapsulation.
- **`GuessLetter(char letter)` Method:**
  - When `WordToGuess.Contains(letter)` is true, it iterates across the secret word and reveals every matching index via `CurrentWordState.Remove(i, 1).Insert(i, letter.ToString())`.
  - When the letter is not present, it appends the character to `wrongLetters` and decrements `AttemptsLeft`.
- **Instant Keystroke Input:** Uses `Console.ReadKey().KeyChar` to capture letter guesses immediately without requiring the Enter key.

---

## 📁 Files

- [`Program.cs`](Program.cs) — `Hangman` class and game loop (`leveltask.Tasks.new_redesign._25_Hangman.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 24 - The 15-Puzzle](../24-15-Puzzle/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; *Latest Quest* ➡️

</div>
