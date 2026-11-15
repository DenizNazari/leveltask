<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Scroll of Freach" />

<div align="center">

# 🔁 12 - The Laws of Freach

### Refactoring `for`-based array iteration to use `foreach` loops and LINQ aggregation methods.

![Level](https://img.shields.io/badge/Level-12%3A%20Arrays-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-50%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Foreach%20%26%20Arrays-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (The Laws of Freach — 50 XP)

**Level 12 — Arrays:**
The town of Freach recently suffered a looping disaster caused by a faulty `++` operator in an old `for` loop, prompting the town council to ban all loops except the `foreach` loop. You are hired to rework their existing array-processing code to use `foreach` loops instead of `for` loops.

### Objectives:
- Start with the array-processing code for computing values across an `int` array.
- Modify the code to use `foreach` loops instead of `for` loops.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- Replaced the indexed `for` loop with a `foreach (var i in strings)` loop over the 5-element `int[] strings` array.
- Computed and printed the array's sum (`strings.Sum()`) and average (`strings.Average()`), and replicated the contents into `strings2` using `strings.CopyTo(strings2, 0)`.

---

## 📁 Files

- [`Program.cs`](Program.cs) — `foreach` array iteration implementation (`LevelTask.Task12.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 11 - The Replicator of D'To](../11-The-Replicator-of-DTo/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [13 - Taking a Number ➡️](../13-Taking-a-Number/README.md)

</div>
