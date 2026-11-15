<img src="../../../assets/prism.gif" align="right" width="96" alt="Cartesian Point" />

<div align="center">

# 📍 18 - Boss Battle: The Point

### Encapsulated 2D Cartesian `Point` class utilizing `private set` immutability and constructor chaining.

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-75%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20Constructors-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: The Point — 75 XP)

**Level 24 — The Catacombs of the Class (First Pedestal):**
The first pedestal asks you to create a `Point` class to store a point in two dimensions. Each point is represented by an `x`-coordinate (horizontal distance from the origin) and a `y`-coordinate (vertical distance from the origin).

### Objectives:
- Define a new `Point` class with properties for `X` and `Y`.
- Add a constructor to create a point from a specific `x`- and `y`-coordinate.
- Add a parameterless constructor to create a point at the origin `(0, 0)`.
- In `Main`, create points and display them in `(x, y)` format to illustrate that the class works.
- **Answer this question:** *Are your `X` and `Y` properties immutable? Why did you choose what you did?*

---

## 🛠️ How I Built It (Architecture & Implementation Details)

### 1. External Immutability & Encapsulation (`private set`)
- Defined `X` and `Y` as `public float X { get; private set; } = 0;` and `public float Y { get; private set; } = 0;`, choosing `float` over `int` so the class can represent fractional coordinates as well as integers.
- **Answering the Book's Question:** From outside the class, `X` and `Y` are **immutable** (`private set`). Treating a 2D coordinate pair `(x, y)` as an immutable value object prevents external code from unexpectedly mutating a point's position after creation.

### 2. Constructor Chaining (`: this(0, 0)`)
To avoid duplicating assignment logic, the parameterless origin constructor delegates directly to the two-parameter constructor:
```csharp
public Point() : this(0, 0)
{
}

public Point(float x, float y)
{
    X = x;
    Y = y;
}
```

---

## 📁 Files

- [`Program.cs`](Program.cs) — `Point` class and coordinate display test (`LevelTask.Task18.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 17 - Vin Fletcher's Arrows](../17-Vin-Fletchers-Arrows/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [19 - The Color ➡️](../19-The-Color/README.md)

</div>
