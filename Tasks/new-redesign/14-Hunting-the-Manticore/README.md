<img src="../../../assets/manticore.gif" align="right" width="96" alt="The Manticore Boss" />

<div align="center">

# 🐉 14 - Boss Battle: Hunting the Manticore

### Two-player turn-based artillery defense game combining *The Prototype* and *The Magic Cannon* mechanics.

![Level](https://img.shields.io/badge/Level-14%3A%20Memory%20Management-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-250%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Methods%20%26%20Game%20Loop-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: Hunting the Manticore — 250 XP)

**Level 14 — Memory Management:**
The Uncoded One's airship, the **Manticore**, has begun an all-out assault on the city of Consolas. To defend the city, you must combine Mylara's range-finding prototype (*The Prototype*) and Skorin's elemental cannon (*The Magic Cannon*) into a two-player game:

- **Player 1 (Manticore Pilot):** Secretly sets the Manticore's distance from the city (`0` to `100`), after which the screen is cleared (`Console.Clear()`).
- **Player 2 (City Defender):** Repeatedly picks a cannon range until either the Manticore (`10 HP`) or the city (`15 HP`) is destroyed. Each shot reports whether it `OVERSHOT`, `FELL SHORT`, or scored a `DIRECT HIT`.
- **Magic Cannon Damage:** Deals `1` damage on normal rounds, `3` damage on multiples of `3` or `5` (Fire or Electric blast), and `10` damage on multiples of both `3` and `5` (Combined Fire-Electric blast).
- Every round the Manticore survives, it deals `1` damage to the city.

```text
STATUS: Round: 1  City: 15/15  Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 50
That round OVERSHOT the target.
```

### Objectives:
- Establish the game's starting state: Manticore starts with `10` health, the city with `15` health, and the game at round `1`.
- Ask Player 1 for the Manticore's distance (`0` to `100`) and clear the screen.
- Run the game in a loop until either the Manticore's or city's health reaches `0`.
- Display the round number, city health, and Manticore health at the start of each round.
- Compute expected cannon damage for the current round (`10`, `3`, or `1`).
- Get a target range from Player 2, report whether it was too high, too low, or a direct hit, and reduce the Manticore's health on a hit.
- Reduce the city's health by `1` if the Manticore is still alive, advance to the next round, and display the final outcome when the battle ends.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

### 1. Reusing the Range-Validated Helper (`askforNumber`)
Reused the `askforNumber(string text, int min, int max)` local function built in `13 - Taking a Number` to guarantee that Player 1's Manticore distance is strictly between `1` and `100` before clearing the console.

### 2. Unified Round & City Health Loop Counter
Because the city loses `1` health point every round the Manticore survives, I drove the main loop with `for (int round = 15; round >= 0; round--)`:
- `round` directly represents the remaining city health (`{round}/15`),
- `15 - round` dynamically tracks the current round number.

### 3. Nested Ternary Operators for Damage & Range Evaluation
Computed both the elemental cannon damage (`damage`) and shot result (`statusRange`: `0` direct hit, `1` overshot, `-1` undershot) in single-line nested ternary expressions:
```csharp
int damage = (15 - round) % 15 == 0 ? 10 : ((15 - round) % 3 == 0 ? 3 : ((15 - round) % 5 == 0 ? 3 : 1));
int statusRange = cannonRange == manticoreDistance ? 0 : (cannonRange >= manticoreDistance ? 1 : -1);
```

---

## 📁 Files

- [`Program.cs`](Program.cs) — Hunting the Manticore Boss Battle implementation (`LevelTask.Task14.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 13 - Taking a Number](../13-Taking-a-Number/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [15 - Simula's Test ➡️](../15-Simulas-Test/README.md)

</div>
