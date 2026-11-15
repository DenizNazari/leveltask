<img src="../../../assets/prism.gif" align="right" width="96" alt="Type Crystal" />

<div align="center">

# 🧪 02 - The Variable Shop & Type Limits

### Exploring C# numeric type boundaries (`MinValue`, `MaxValue`), IEEE 754 special values (`PositiveInfinity`, `NaN`), integer overflow, and `float` precision limits.

![Level](https://img.shields.io/badge/Level-6--7%3A%20The%20C%23%20Type%20System-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Type%20System%20%26%20Overflow-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Level 6 & Level 7 — The C# Type System & Math)

Explore the minimum and maximum bounds of C# numeric types (`MinValue`, `MaxValue`), special IEEE 754 floating-point values (`PositiveInfinity`, `NaN`), arithmetic wrap-around (**integer overflow**), and single-precision (`float`) rounding behavior.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- **Numeric Type Bounds (`MinValue` & `MaxValue`):** Inspected `int.MaxValue`, `short.MinValue` (`-32768`), and `short.MaxValue` (`32767`) to observe signed integer ranges in memory.
- **Special IEEE 754 Values:** Printed `double.PositiveInfinity` ($\infty$) and `double.NaN` (*Not a Number*).
- **Integer Overflow Experiment:** Added two `short` variables (`30000 + 30000`) and explicitly cast the result back via `(short)(a + b)`, demonstrating how exceeding `32767` wraps around into the negative range (`-5536`).
- **Floating-Point Precision Test:** Added `10000f` and `0.00001f` using 32-bit `float` variables to observe 7-digit significant-figure precision limits.

---

## 📁 Files

- [`Program.cs`](Program.cs) — Type limits, overflow, and precision experiments (`LevelTask.Task02.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 01 - The Triangle Farmer](../01-The-Triangle-Farmer/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [03 - The Four Sisters and the Duckbear ➡️](../03-The-Four-Sisters-and-the-Duckbear/README.md)

</div>
