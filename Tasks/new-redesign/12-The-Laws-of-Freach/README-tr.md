<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Scroll of Freach" />

<div align="center">

# 🔁 12 - The Laws of Freach

### `for` döngüsünün yasaklandığı Freach kasabasında dizi işlemlerini `foreach` döngüsü ve LINQ metotlarıyla gerçekleştiren uygulama.

![Level](https://img.shields.io/badge/Seviye-12%3A%20Arrays-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-50%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Foreach%20%26%20Arrays-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: The Laws of Freach — 50 XP)

**Level 12 — Arrays:**
Freach kasabasında eski bir `for` döngüsündeki hatalı `++` operatörü yüzünden korkunç bir döngü felaketi yaşanmıştır. Kasaba konseyi `foreach` döngüsü dışındaki tüm döngüleri yasaklamaya karar vermiştir. Bir `int` dizisindeki değerleri işleyen ve ortalama/toplam hesaplayan mevcut `for` tabanlı kodun `foreach` döngüsü kullanacak şekilde yeniden yazılması gerekmektedir.

### Hedefler (Objectives):
- Dizi işlemlerini gerçekleştiren başlangıç kodunu temel almak.
- Kodu `for` döngüleri yerine `foreach` döngülerini kullanacak şekilde değiştirmek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- `for` döngüsü yerine `foreach (var i in strings)` yapısını kullanarak 5 elemanlı `int[] strings` dizisi üzerinde gezindim.
- Dizideki sayıların toplamını `strings.Sum()` ve ortalamasını `strings.Average()` LINQ metotlarıyla hesaplayıp ekrana yazdırdım ve `strings.CopyTo(strings2, 0)` ile ikinci diziye kopyaladım.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `foreach` tabanlı dizi uygulaması (`LevelTask.Task12.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 11 - The Replicator of D'To](../11-The-Replicator-of-DTo/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [13 - Taking a Number ➡️](../13-Taking-a-Number/README-tr.md)

</div>
