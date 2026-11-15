<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Clocktower Gear" />

<div align="center">

# 🕰️ 06 - Repairing the Clocktower

### Determining even (`tick`) vs. odd (`tock`) pendulum swings using the remainder operator (`% 2`) and `if-else` branching.

![Level](https://img.shields.io/badge/Level-9%3A%20Decision%20Making-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-If%2FElse%20%26%20Modulo-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Repairing the Clocktower — 100 XP)

**Level 9 — Decision Making:**
Recent attacks damaged the great Clocktower of Consolas. Only the piece that makes the clock tick and tock remains: if the input number is **even**, the pendulum should swing left (`"Tick"`); if the number is **odd**, the pendulum should swing right (`"Tock"`).

### Objectives:
- Take a number as input from the console.
- Display the word `"Tick"` if the number is even, or `"Tock"` if the number is odd.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- Parsed the console input into `int clock` and evaluated parity with `if (clock % 2 == 0)`.
- Printed `"tick"` when divisible by `2`, and `"tock"` in the `else` branch.

---

## 📁 Files

- [`Program.cs`](Program.cs) — Clocktower parity check implementation (`LevelTask.Task06.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 05 - The Defense of Consolas](../05-The-Defense-of-Consolas/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [07 - Watchtower ➡️](../07-Watchtower/README.md)

</div>
