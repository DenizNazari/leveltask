<img src="../../../assets/shield.gif" align="right" width="96" alt="Shield of Consolas" />

<div align="center">

# 🛡️ 05 - The Defense of Consolas

### Tactical barrier deployment calculator featuring custom console styling (`ConsoleColor`, `Console.Title`) and audio alerts (`Console.Beep`).

![Level](https://img.shields.io/badge/Level-8%3A%20Console%202.0-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-200%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Console%202.0%20UI-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (The Defense of Consolas — 200 XP)

**Level 8 — Console 2.0:**
The Uncoded One's airship, the *Manticore*, is catapulting fireballs at the city of Consolas. A squad of four operates a movable magical barrier that protects a targeted city block by deploying to its **four orthogonally adjacent blocks**:

| | 4 | 5 | 6 |
|:---:|:---:|:---:|:---:|
| **7** | ` ` | 🛡️ **(7, 5)** | ` ` |
| **6** | 🛡️ **(6, 4)** | 🎯 **Target (6, 5)** | 🛡️ **(6, 6)** |
| **5** | ` ` | 🛡️ **(5, 5)** | ` ` |

```text
Target Row? 6
Target Column? 5
Deploy to:
(6, 4)
(5, 5)
(6, 6)
(7, 5)
```

### Objectives:
- Ask the user for the target row and column.
- Compute the neighboring rows and columns where the squad must deploy.
- Display the deployment instructions in a custom console color.
- Change the console window title to `"Defense of Consolas"`.
- Play a sound with `Console.Beep` when the results have been computed and displayed.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- **Console 2.0 Styling:** Customized the terminal theme with `Console.BackgroundColor = ConsoleColor.DarkMagenta`, `Console.ForegroundColor = ConsoleColor.White`, and set `Console.Title = "The Defense of Consolas"`.
- **Coordinate Math & Audio Alert:** Read `row` and `column` inputs using `\t` tab alignment, triggered a 440 Hz tone for 1000 ms via `Console.Beep(440, 1000)`, and printed all four adjacent coordinates (`(row + 1, column)`, `(row - 1, column)`, `(row, column + 1)`, `(row, column - 1)`) in a single interpolated string.

---

## 📁 Files

- [`Program.cs`](Program.cs) — Consolas defense deployment calculator (`LevelTask.Task05.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 04 - The Dominion of Kings](../04-The-Dominion-of-Kings/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [06 - Repairing the Clocktower ➡️](../06-Repairing-the-Clocktower/README.md)

</div>
