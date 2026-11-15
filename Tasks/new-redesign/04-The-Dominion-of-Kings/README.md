<img src="../../../assets/crown.gif" align="right" width="96" alt="Royal Crown" />

<div align="center">

# 👑 04 - The Dominion of Kings

### Kingdom point calculator weighting `provinces`, `duchies`, and `estates` using integer arithmetic.

![Level](https://img.shields.io/badge/Level-7%3A%20Math-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Arithmetic-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (The Dominion of Kings — 100 XP)

**Level 7 — Math:**
Three kings—Melik, Casik, and Balik—are debating whose kingdom is the greatest. Each king rules an assortment of **provinces**, **duchies**, and **estates**, scored according to the following point system:

| Holding Type | Point Value |
|---|:---:|
| **Estate** | `1 point` |
| **Duchy** | `3 points` |
| **Province** | `6 points` |

### Objectives:
- Allow users to enter how many provinces, duchies, and estates they have.
- Compute the total score by awarding `1` point per estate, `3` per duchy, and `6` per province.
- Display the point total to the user.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- Initialized an accumulator variable `int score = 0;`.
- Prompted the user for `provinces`, `duchies`, and `estates`, parsing each with `int.Parse(Console.ReadLine())`.
- Multiplied each holding count by its respective point weight (`* 6`, `* 3`, and `* 1`), accumulated the result into `score`, and displayed it via string interpolation (`$"score:{score}"`).

---

## 📁 Files

- [`Program.cs`](Program.cs) — Kingdom score calculator (`LevelTask.Task04.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 03 - The Four Sisters and the Duckbear](../03-The-Four-Sisters-and-the-Duckbear/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [05 - The Defense of Consolas ➡️](../05-The-Defense-of-Consolas/README.md)

</div>
