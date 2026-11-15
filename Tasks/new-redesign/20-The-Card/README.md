<img src="../../../assets/cards.gif" align="right" width="96" alt="The Card Deck" />

<div align="center">

# 🃏 20 - Boss Battle: The Card

### Object-oriented 56-card deck generator that renders every card inside an ANSI RGB-colored ASCII card frame.

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20ASCII%20Art-239120?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: The Card — 100 XP)

**Level 24 — The Catacombs of the Class (Third Pedestal):**
The digital Realms of C# feature playing cards with a custom deck structure:
- Each card has a **color**: `Red`, `Green`, `Blue`, or `Yellow`.
- Each card has a **rank**: numbers `1` through `10`, followed by the symbols `$`, `%`, `^`, and `&`.
- The third pedestal requires creating a `Card` class to represent a card of this nature.

### Objectives:
- Define enumerations for card colors and card ranks.
- Define a `Card` class to represent a card with a color and a rank.
- Add properties or methods that determine whether a card is a **number card** or a **symbol card** (the equivalent of a face card).
- Create a `Main` method that instantiates the entire 56-card deck (every color paired with every rank) and displays each one (for example, `"The Red Ampersand"` and `"The Blue Seven"`).
- **Answer this question:** *Why do you think we used a color enumeration here, whereas we made a `Color` class in the previous challenge?*

---

## 🛠️ How I Built It (Architecture & Implementation Details)

While the book only required printing plain card names (`"The Red Ampersand"`), I integrated the **24-bit ANSI RGB `color` class** from the previous challenge (`19 - The Color`) so that all 56 cards are rendered in **their actual RGB color (`Red`, `Green`, `Blue`, `Yellow`) inside an ASCII playing-card border**.

### 1. `CartColors` & `CartTypes` Enum Modeling
- Modeled the 4 fixed card colors with `CartColors` (`Red`, `Green`, `Blue`, `Yellow`) and the 14 ranks with `CartTypes` (`ONE`..`TEN`, `DollarSign`, `PercentSign`, `Caret`, `Ampersand`).
- **`cartcarakter` Property:** Leveraged the underlying integer value of `CartTypes` to classify symbol vs. number cards with an expression-bodied property:
  ```csharp
  public string cartcarakter => (int)Type > 10 ? "Special Character" : "Regular Character";
  ```

### 2. Dynamic Padding (`PadRight`) & Colored Raw String Literal ASCII Card Rendering
- `DisplayCartInfo()` maps the card's `CartColors` enum to the corresponding static RGB instance (`color.Red`, `color.Green`, `color.Blue`, `color.Yellow`) using a `switch` expression and activates the ANSI terminal color.
- Because card titles vary in length (`"The Red 1"` vs. `"The Yellow PercentSign"`), `("    The " + cartText).PadRight(25)` pads the inner label to a fixed 25-character width so the right border of the C# 11 **Raw String Literal (`$""" ... """`)** card frame stays aligned:
  ```text
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXX
   XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX    The Red Ampersand    XXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX                         XXXX
   XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    XXXXXXXXXXXXXXXXXXXXXXXXXXXX
  ```

### 3. Answering the Book's Question
> *"Why did we use a color enumeration here, whereas we made a `Color` class in the previous challenge?"*

In `The Color`, a color is an open-ended composite value formed by three independent `0–255` RGB channels ($256^3 \approx 16.7\text{ million}$ possible combinations). In `The Card`, card suits are restricted to a **small, fixed set of 4 discrete choices (`Red`, `Green`, `Blue`, `Yellow`)**, making an `enum` the cleanest and most type-safe representation.

---

## 📁 Files

- [`Program.cs`](Program.cs) — `Cart`, `CartColors`, `CartTypes`, and ANSI `color` implementation (`LevelTask.Task20.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 19 - The Color](../19-The-Color/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [21 - The Locked Door ➡️](../21-The-Locked-Door/README.md)

</div>
