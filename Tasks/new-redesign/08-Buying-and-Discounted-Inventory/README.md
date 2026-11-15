<img src="../../../assets/chest.gif" align="right" width="96" alt="Shop Chest" />

<div align="center">

# 🛒 08 - Buying Inventory & Discounted Inventory

### Shop pricing system using `switch` statements, Raw String Literals, and a 50% name-based discount via ternary expressions.

![Level](https://img.shields.io/badge/Level-10%3A%20Switches-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP%20(2%20Quests)-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Switch%20%26%20Ternary-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenges (Buying Inventory — 100 XP & Discounted Inventory — 50 XP)

**Level 10 — Switches:**
Build a program for Tortuga's outfitter shop that displays the available equipment menu, asks the user to choose an item number, and applies a 50% discount if the customer enters your name:

| Menu # | Item | Base Cost | Discounted Cost (50%) |
|:---:|---|:---:|:---:|
| **1** | Rope | `10 gold` | `5 gold` |
| **2** | Torches | `15 gold` | `7 gold` |
| **3** | Climbing Equipment | `25 gold` | `12 gold` |
| **4** | Clean Water | `1 gold` | `0 gold` |
| **5** | Machete | `20 gold` | `10 gold` |
| **6** | Canoe | `200 gold` | `100 gold` |
| **7** | Food Supplies | `1 gold` | `0 gold` |

### Objectives:
- Display the numbered menu above and ask the user to enter a number from the menu.
- Using the information above, use a `switch` (either type) to show the item's cost.
- **Discounted Inventory (50 XP):** Also ask the user for their name; if their name matches yours, divide the cost in half.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

- **Raw String Literal (`""" ... """`):** Rendered the multi-line shop menu cleanly without manual `\n` escape sequences.
- **Inline 50% Discount via Ternary Operator:** Inside each `case` of `switch (itemNumber)`, evaluated `(playerName == "Deniz" ? 2 : 1)` as the divisor so that entering `"Deniz"` automatically halves the item's price in a single interpolated string.

---

## 📁 Files

- [`Program.cs`](Program.cs) — Outfitter shop menu and discount calculator (`LevelTask.Task08.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 07 - Watchtower](../07-Watchtower/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [09 - The Prototype ➡️](../09-The-Prototype/README.md)

</div>
