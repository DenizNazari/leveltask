<img src="../../../assets/door-key.gif" align="right" width="96" alt="Password Validator" />

<div align="center">

# 🔐 22 - Boss Battle: The Password Validator

### Single-pass `PasswordValidator` class that inspects character rules and reports all violated security constraints at once.

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-String%20Validation%20%26%20OOP-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: The Password Validator — 100 XP)

**Level 24 — The Catacombs of the Class (Fifth Pedestal):**
The fifth and final pedestal requires a class that determines whether a password is valid according to the following rules:

- Passwords must be at least **6 characters** long and no more than **13 characters** long.
- Passwords must contain at least one **uppercase letter**, one **lowercase letter**, and one **number**.
- Passwords **cannot** contain a capital **`T`** or an ampersand (**`&`**) because Ingelmar in IT has decreed it.

### Objectives:
- Define a new `PasswordValidator` class that determines whether a given password follows the rules above.
- Loop in the `Main` method, prompting the user for a password and reporting whether it is valid using `PasswordValidator`.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

### 1. Single-Pass Character Inspection (`foreach` & `System.Char` Helpers)
Instead of iterating over the string multiple times, `ValidatePassword(string password)` scans the password in a single `foreach (char c in password)` pass (`O(N)`) and updates boolean flags:
- `char.IsUpper(c)` for uppercase detection (`hasUpper`),
- `char.IsLower(c)` for lowercase detection (`hasLower`),
- `char.IsDigit(c)` for numeric digit detection (`hasDigit`),
- `c == 'T' || c == '&'` for forbidden character detection (`hasSpecial`).

### 2. Aggregated Rule-Violation Reporting (`warningMsj`)
Rather than returning a generic failure message when a password is rejected, I built an aggregated diagnostic builder (`warningMsj`) using ternary expressions:
- Every violated constraint (length bounds, missing uppercase, missing lowercase, missing digit, or forbidden `T`/`&` characters) is appended and displayed together so the user knows exactly what to fix on the next `do-while` iteration.

---

## 📁 Files

- [`Program.cs`](Program.cs) — `PasswordValidator` class and interactive validation loop (`LevelTask.Task22.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 21 - The Locked Door](../21-The-Locked-Door/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [23 - Rock-Paper-Scissors ➡️](../23-Rock-Paper-Scissors/README.md)

</div>
