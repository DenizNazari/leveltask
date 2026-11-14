<div align="center">

# 📐 01 - The Triangle Farmer

### Calculate the area of a triangle from user-provided base and height.

![Level](https://img.shields.io/badge/Level-6%3A%20The%20C%23%20Type%20System-512BD4)
![C#](https://img.shields.io/badge/C%23-.NET%209-239120)
![Type](https://img.shields.io/badge/Type-Challenge-blue)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge

**Level 6 — The C# Type System** (*The C# Player's Guide*):

Write a program that lets a user input the **base** and **height** of a triangle, computes its area using the formula below, and writes the result to the console:

$$\text{Area} = \frac{\text{Base} \times \text{Height}}{2}$$

## 🛠️ How I Built It

- **Floating-Point Precision:** Used the `double` data type to support decimal values for both base and height.
- **Type Conversion:** Parsed the first input with `double.Parse(Console.ReadLine())` and the second input with `Convert.ToDouble(Console.ReadLine())` to practice two different C# conversion methods.
- **Output:** Computed `(bases * heights) / 2` directly inside `Console.WriteLine(...)` and printed the result.

## ▶️ Example Output

```text
Base:
10.5
Height:
4
21
```

## 📁 Files

- [`Program.cs`](Program.cs) — Entry point (`LevelTask.Task01.Program.Main`)
