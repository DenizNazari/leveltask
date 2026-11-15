<img src="../../../assets/prism.gif" align="right" width="96" alt="Replicator Crystal" />

<div align="center">

# 🧬 11 - The Replicator of D'To

### Populating a 5-element integer array from user input, computing sum/average statistics, and replicating it into a second array.

![Level](https://img.shields.io/badge/Level-12%3A%20Arrays-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Arrays%20%26%20LINQ-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (The Replicator of D'To — 100 XP)

**Level 12 — Arrays:**
While searching an abandoned storage building containing strange code artifacts, you uncover the ancient **Replicator of D'To**, capable of replicating the contents of any `int` array into another array. You must reforge the magic that allows it to replicate once again.

### Objectives:
- Create an array of length `5`.
- Ask the user for five numbers and put them in the array.
- Make a second array of length `5`.
- Copy the values out of the original array and into the new one.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- Declared `int[] strings = new int[5];` and populated all 5 indices via a `for (int i = 0; i < strings.Length; i++)` loop reading integer inputs from the user.
- Computed and displayed the sum (`strings.Sum()`) and arithmetic mean (`strings.Average()`) of the entered numbers.
- Allocated a second 5-element array (`int[] strings2 = new int[5];`) and copied the original array into it using `strings.CopyTo(strings2, 0)`.

---

## 📁 Files

- [`Program.cs`](Program.cs) — Array population, LINQ statistics, and `CopyTo` replication (`LevelTask.Task11.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 10 - The Magic Cannon](../10-The-Magic-Cannon/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [12 - The Laws of Freach ➡️](../12-The-Laws-of-Freach/README.md)

</div>
