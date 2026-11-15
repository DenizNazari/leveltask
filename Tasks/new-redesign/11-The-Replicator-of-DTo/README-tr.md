<img src="../../../assets/prism.gif" align="right" width="96" alt="Replicator Crystal" />

<div align="center">

# 🧬 11 - The Replicator of D'To

### 5 elemanlı bir tam sayı dizisini kullanıcı girdileriyle doldurup toplam/ortalama hesaplayan ve ikinci bir diziye kopyalayan uygulama.

![Level](https://img.shields.io/badge/Seviye-12%3A%20Arrays-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Arrays%20%26%20LINQ-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: The Replicator of D'To — 100 XP)

**Level 12 — Arrays:**
Garip kod kalıntılarıyla dolu terk edilmiş bir depoyu ararken antik **Replicator of D'To**'yu bulursun. Bu cihaz herhangi bir `int` dizisinin içeriğini başka bir diziye kopyalayabilir, ancak bozuktur ve büyüsünü yeniden çalıştırmak için bir Programcıya ihtiyaç duyar.

### Hedefler (Objectives):
- Uzunluğu `5` olan bir dizi (`array`) oluşturan bir program yazmak.
- Kullanıcıdan beş sayı isteyip bunları diziye yerleştirmek.
- Uzunluğu `5` olan ikinci bir dizi oluşturmak.
- Orijinal dizideki değerleri yeni diziye kopyalamak.
- Replicator of D'To'nun tekrar çalıştığını göstermek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- `int[] strings = new int[5];` ile 5 elemanlı ilk diziyi tanımladım ve `for (int i = 0; i < strings.Length; i++)` döngüsüyle kullanıcıdan aldığım 5 tam sayıyı diziye yerleştirdim.
- Dizideki elemanların toplamını (`strings.Sum()`) ve aritmetik ortalamasını (`strings.Average()`) hesaplayarak konsola yazdırdım.
- İkinci bir `int[] strings2 = new int[5];` dizisi oluşturup `strings.CopyTo(strings2, 0)` metoduyla ilk dizinin tüm elemanlarını ikinci diziye kopyaladım.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Dizi oluşturma, LINQ hesaplamaları ve `CopyTo` kopyalama uygulaması (`LevelTask.Task11.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 10 - The Magic Cannon](../10-The-Magic-Cannon/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [12 - The Laws of Freach ➡️](../12-The-Laws-of-Freach/README-tr.md)

</div>
