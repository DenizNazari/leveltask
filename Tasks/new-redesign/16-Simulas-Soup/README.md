<img src="../../../assets/cauldron.gif" align="right" width="96" alt="Simula's Cauldron" />

<div align="center">

# 🍲 16 - Simula's Soup

### Recipe builder combining three distinct `enum` types (food type, main ingredient, seasoning) into a named `ValueTuple`.

![Level](https://img.shields.io/badge/Level-17%3A%20Tuples-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Challenge-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Tuples%20%26%20Enums-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Simula's Soup — 100 XP)

**Level 17 — Tuples:**
With her chest unlocked, Simula recovers her vials of seasoning powder and begins cooking again. She asks you to build a program that lets the user pick a recipe type, a main ingredient, and a seasoning from the allowed choices and tracks the resulting dish using a tuple:

| Category | Allowed Choices |
|---|---|
| **Food Type** | `Soup`, `Stew`, `Gumbo` |
| **Main Ingredient** | `Mushrooms`, `Chicken`, `Carrots`, `Potatoes` |
| **Seasoning** | `Spicy`, `Salty`, `Sweet` |

### Objectives:
- Define enumerations for the three variations on food: type (`soup`, `stew`, `gumbo`), main ingredient (`mushrooms`, `chicken`, `carrots`, `potatoes`), and seasoning (`spicy`, `salty`, `sweet`).
- Make a tuple variable to represent a soup composed of the three enumeration types above.
- Let the user pick a type, main ingredient, and seasoning from the allowed choices and populate the tuple.
- Display the contents of the soup tuple in a format like `"Sweet Chicken Gumbo"`.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

### 1. Named `ValueTuple` Local Function (`food()`)
To group the three enumerations (`FoodTypeEnum`, `FoodManingredientEnum`, `FoodSeasoningEnum`) without creating a dedicated class, I defined a local function returning a named tuple: **`(FoodTypeEnum FType, FoodManingredientEnum FMain, FoodSeasoningEnum FSeason)`**.

### 2. Case-Insensitive Input Parsing via `Enum.TryParse`
All three user inputs are validated simultaneously inside a `while (true)` loop using `Enum.TryParse<...>(input, ignoreCase: true, out ...)`:
- When all three inputs match valid enum members, the function returns `(foodType, foodMain, foodSeasoning)` and prints the formatted dish.
- If any input is invalid, the loop prompts the user again.

---

## 📁 Files

- [`Program.cs`](Program.cs) — `FoodTypeEnum`, `FoodManingredientEnum`, `FoodSeasoningEnum`, and Tuple implementation (`LevelTask.Task16.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 15 - Simula's Test](../15-Simulas-Test/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [17 - Vin Fletcher's Arrows ➡️](../17-Vin-Fletchers-Arrows/README.md)

</div>
