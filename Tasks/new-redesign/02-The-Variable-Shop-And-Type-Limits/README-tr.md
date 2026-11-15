<img src="../../../assets/prism.gif" align="right" width="96" alt="Type Crystal" />

<div align="center">

# 🧪 02 - The Variable Shop & Veri Tipi Sınırları (Type Limits)

### C# tam sayı ve ondalıklı veri tiplerinin sınırlarını (`MinValue`, `MaxValue`), taşma (`overflow`) davranışını ve kayan nokta hassasiyetini inceleyen uygulama.

![Level](https://img.shields.io/badge/Seviye-6--7%3A%20The%20C%23%20Type%20System-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Type%20System%20%26%20Overflow-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Level 6 & Level 7 — The C# Type System & Math)

C# içerisindeki sayısal veri tiplerinin sınırlarını (`MinValue`, `MaxValue`), özel ondalıklı sabitleri (`PositiveInfinity`, `NaN`), tam sayı taşmasını (**integer overflow**) ve kayan noktalı sayıların (`float`) hassasiyet sınırlarını deneyimlemek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- **Sınır Sabitleri (`MinValue` & `MaxValue`):** `int.MaxValue`, `short.MinValue` (`-32768`) ve `short.MaxValue` (`32767`) sabitlerini kullanarak tam sayı tiplerinin bellekte alabileceği uç değerleri inceledim.
- **Özel IEEE 754 Sabitleri:** `double.PositiveInfinity` ($\infty$) ve `double.NaN` (*Not a Number*) özel değerlerini konsola yazdırdım.
- **Tam Sayı Taşması (Integer Overflow Testi):** İki adet `30000` değerindeki `short` değişkenini toplayıp `(short)(a + b)` şeklinde açıkça (`explicit cast`) dönüştürerek `32767` sınırının aşılmasında oluşan negatif taşma (`-5536` wrap-around) davranışını test ettim.
- **Kayan Nokta Hassasiyeti (Floating-Point Precision):** `float` tipinde `10000` ile `0.00001f` değerlerini toplayarak 32-bit `float` tipinin anlamlı basamak (7 basamak) hassasiyet sınırını gözlemledim.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Veri tipi sınırları ve taşma deneyleri (`LevelTask.Task02.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 01 - The Triangle Farmer](../01-The-Triangle-Farmer/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [03 - The Four Sisters and the Duckbear ➡️](../03-The-Four-Sisters-and-the-Duckbear/README-tr.md)

</div>
