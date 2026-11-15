<img src="../../../assets/shield.gif" align="right" width="96" alt="Watchtower Shield" />

<div align="center">

# 🗼 07 - Watchtower

### Mapping enemy $(x, y)$ coordinates relative to a watchtower into 9 compass directions using two distinct conditional algorithms.

![Level](https://img.shields.io/badge/Level-9%3A%20Decision%20Making-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Conditionals%20%26%20Coordinates-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Watchtower — 100 XP)

**Level 9 — Decision Making:**
Watchtowers around Consolas alert the city when an enemy is spotted. Given the enemy's $(x, y)$ coordinates relative to the watchtower, determine which compass direction the enemy is approaching from using the grid below:

| | `x < 0` | `x = 0` | `x > 0` |
|:---:|:---:|:---:|:---:|
| **`y > 0`** | **NW** *(Northwest)* | **N** *(North)* | **NE** *(Northeast)* |
| **`y = 0`** | **W** *(West)* | **!** *(Here / Origin)* | **E** *(East)* |
| **`y < 0`** | **SW** *(Southwest)* | **S** *(South)* | **SE** *(Southeast)* |

### Objectives:
- Ask the user for an `x` value and a `y` value representing the enemy's coordinates relative to the watchtower.
- Using the table above, `if` statements, and relational operators (`<`, `>`, `==`), display the direction the enemy is coming from.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

I implemented **two different solutions (Version 1 and Version 2)** side-by-side to compare algorithmic conciseness against explicit boolean branching:

1. **Approach 1 (`direction1` — Orthogonal String Composition):**
   Instead of writing 9 separate branches, I decoupled the vertical (`y`) and horizontal (`x`) axes:
   - The first `if / else if` checks `y > 0` (`"N"`) or `y < 0` (`"S"`).
   - The second independent `if / else if` appends `"E"` (`x > 0`) or `"W"` (`x < 0`).
   With just 4 checks, composite diagonals (`NE`, `NW`, `SE`, `SW`) are formed automatically.
2. **Approach 2 (`direction2` — Explicit Compound `&&` Conditions):**
   Evaluates all 9 cells of the 3×3 matrix explicitly using logical AND (`&&`) operators (e.g., `y > 0 && x > 0` -> `"NE"`, falling back to `"Origin"` when `x == 0 && y == 0`).

---

## 📁 Files

- [`Program.cs`](Program.cs) — Dual-algorithm watchtower direction finder (`LevelTask.Task07.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 06 - Repairing the Clocktower](../06-Repairing-the-Clocktower/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [08 - Buying & Discounted Inventory ➡️](../08-Buying-and-Discounted-Inventory/README.md)

</div>
