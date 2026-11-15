<img src="../../../assets/prism.gif" align="right" width="96" alt="RGB Color Prism" />

<div align="center">

# 🎨 19 - Boss Battle: The Color

### Object-oriented `Color` class with a 24-bit TrueColor ANSI escape sequence engine for live RGB rendering in the terminal.

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20ANSI%20TrueColor-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: The Color — 100 XP)

**Level 24 — The Catacombs of the Class (Second Pedestal):**
The second pedestal asks you to build a `Color` class representing a color via three channels—red (`R`), green (`G`), and blue (`B`)—each ranging from `0` (completely off) to `255` (completely on):

```text
┌──────────┐   R ───────────────● 255 ↕
│          │   G ─────────●────── 165 ↕
│          │   B ●───────────────   0 ↕
└──────────┘
```

The pedestal also defines eight commonly used preset colors and their channel values:

| Color | Red (`R`) | Green (`G`) | Blue (`B`) |
|---|:---:|:---:|:---:|
| **White** | `255` | `255` | `255` |
| **Black** | `0` | `0` | `0` |
| **Red** | `255` | `0` | `0` |
| **Orange** | `255` | `165` | `0` |
| **Yellow** | `255` | `255` | `0` |
| **Green** | `0` | `128` | `0` |
| **Blue** | `0` | `0` | `255` |
| **Purple** | `128` | `0` | `128` |

### Objectives:
- Define a new `Color` class with properties for its red, green, and blue channels.
- Add appropriate constructors for creating new `Color` instances.
- Create `static` properties to expose the eight commonly used colors for easy access.
- In `Main`, make two `Color`-typed variables—one using a constructor and the other using a static property—and display their `R`, `G`, and `B` channel values.

---

## 🛠️ How I Built It (Architecture & Implementation Details)

While the book only required storing numeric `(R, G, B)` values and printing the numbers to the console, I extended the class with a **24-bit TrueColor ANSI Escape Sequence** rendering engine so that any instantiated `color` object can paint text in its exact RGB shade directly in the console window.

### 1. Encapsulation & Constructor Chaining
- Encapsulated `_r`, `_g`, and `_b` backing fields behind `R`, `G`, and `B` properties with `private set` accessors and `ArgumentOutOfRangeException` validation.
- Chained the parameterless constructor (`public color() : this(0, 0, 0)`) to the primary `(int r, int g, int b)` constructor to default to black.
- Defined static factory properties (such as `public static color Orange => new color(255, 165, 0);`) for instant access to preset colors.

### 2. ANSI 24-Bit TrueColor Terminal Rendering Engine
Whereas standard `System.ConsoleColor` is limited to 16 preset console colors, my `color` class emits the `\x1b[38;2;{R};{G};{B}m` ANSI escape sequence to render **all 16.7 million RGB colors** in modern terminals:
- **`testYourColor()`:** Prints the `R`, `G`, and `B` values rendered in the instance's actual RGB color and resets the terminal via `\x1b[0m`.
- **`setConsoleColor()` & `resetConsoleColor()`:** Switches active console output to the object's RGB color (reused in **20 - The Card** to paint ASCII playing cards).
- **`setColorText(color color, string text)`:** Static helper that wraps any string in the specified RGB escape codes.

---

## 📁 Files

- [`Program.cs`](Program.cs) — `color` class and ANSI TrueColor console rendering methods (`LevelTask.Task19.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 18 - The Point](../18-The-Point/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [20 - The Card ➡️](../20-The-Card/README.md)

</div>
