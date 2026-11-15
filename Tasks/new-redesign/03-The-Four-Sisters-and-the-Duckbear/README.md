<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Quest Scroll" />

<div align="center">

# 🦆🐻 03 - The Four Sisters and the Duckbear

### Chocolate egg distribution using integer division (`/`) and remainder (`%`) operators, plus an automated solver for the Duckbear bonus question.

![Level](https://img.shields.io/badge/Level-7%3A%20Math-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Division%20%26%20Modulo-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (The Four Sisters and the Duckbear — 100 XP)

**Level 7 — Math:**
Four sisters own a chocolate farm and collect chocolate eggs every day. Because you cannot split a chocolate egg without ruining it, all four sisters receive an equal number of chocolate eggs each day, and the remainder is fed to their pet **duckbear**.

### Objectives:
- Create a program that lets the user enter the number of chocolate eggs gathered that day.
- Using `/` and `%`, compute how many eggs each sister should get and how many are left over for the duckbear.
- **Answer this question:** *What are three total egg counts where the duckbear gets more than each sister does?*

---

## 🛠️ How I Built It (Architecture & Implementation Details)

### 1. Integer Division (`/`) & Remainder (`%`) Calculation
- Parsed the user's egg count (`eggs`) and computed each sister's share with `(int)eggs / 4` (`eggsneeded`) and the duckbear's leftover share with `(int)eggs % 4` (`eggremainder`).

### 2. Algorithmic Solution to the Book's Question (`if (i / 4 < i % 4)`)
> *"What are the total egg counts where the duckbear gets more than each sister does?"*

Instead of guessing numbers by hand, I added a `for (int i = 1; i < 20; i++)` search loop directly into the program that checks `if (i / 4 < i % 4)` and automatically finds **all 6 total egg counts (`1`, `2`, `3`, `6`, `7`, and `11`)** where the duckbear gets more eggs than each sister:

| Total Eggs (`i`) | Each Sister Gets (`i / 4`) | Duckbear Gets (`i % 4`) |
|:---:|:---:|:---:|
| **1, 2, 3** | `0` | **1, 2, 3** |
| **6, 7** | `1` | **2, 3** |
| **11** | `2` | **3** |

---

## 📁 Files

- [`Program.cs`](Program.cs) — Egg distribution calculator and automated `i / 4 < i % 4` solver (`LevelTask.Task03.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 02 - The Variable Shop & Type Limits](../02-The-Variable-Shop-And-Type-Limits/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [04 - The Dominion of Kings ➡️](../04-The-Dominion-of-Kings/README.md)

</div>
