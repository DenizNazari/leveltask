<img src="../../../assets/crown.gif" align="right" width="96" alt="Royal Crown" />

<div align="center">

# 👑 04 - The Dominion of Kings

### Üç kralın mülk sayılarına (`provinces`, `duchies`, `estates`) göre krallık puanını hesaplayan aritmetik uygulama.

![Level](https://img.shields.io/badge/Seviye-7%3A%20Math-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Arithmetic-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: The Dominion of Kings — 100 XP)

**Level 7 — Math:**
Üç kral (Melik, Casik ve Balik) bir masanın etrafında oturup kimin krallığının en büyük olduğunu tartışmaktadır. Her kral çeşitli sayıda **eyalet (`provinces`)**, **dükalık (`duchies`)** ve **mülk (`estates`)** yönetir. Ortak kabul ettikleri puan sistemine göre:

| Mülk Türü | Puan Değeri |
|---|:---:|
| **Estate (Mülk)** | `1 puan` |
| **Duchy (Dükalık)** | `3 puan` |
| **Province (Eyalet)** | `6 puan` |

### Hedefler (Objectives):
- Kullanıcıların kaç tane `province`, `duchy` ve `estate` sahibi olduklarını girmelerine olanak tanıyan bir program oluşturmak.
- Estate başına `1`, Duchy başına `3` ve Province başına `6` puan vererek kullanıcının toplam puanını toplamak.
- Toplam puanı kullanıcıya göstermek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- Toplam puanı tutmak üzere `int score = 0;` değişkenini tanımladım.
- Kullanıcıdan sırasıyla `provinces`, `duchies` ve `estates` adetlerini `int.Parse(Console.ReadLine())` ile aldım.
- Her mülk türünü kendi ağırlık katsayısıyla (`* 6`, `* 3` ve `* 1`) çarparak `score` değişkeninde topladım ve sonucu `$"score:{score}"` formatında ekrana yazdırdım.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Krallık puanı hesaplayıcısı (`LevelTask.Task04.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 03 - The Four Sisters and the Duckbear](../03-The-Four-Sisters-and-the-Duckbear/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [05 - The Defense of Consolas ➡️](../05-The-Defense-of-Consolas/README-tr.md)

</div>
