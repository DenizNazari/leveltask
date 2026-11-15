<img src="../../../assets/cannon.gif" align="right" width="96" alt="Elemental Magic Cannon" />

<div align="center">

# 💥 10 - The Magic Cannon

### 3 ve 5'in katlarına göre Ateş, Elektrik ve Birleşik patlama türlerini iç içe ternary operatörlerle belirleyen döngü uygulaması.

![Level](https://img.shields.io/badge/Seviye-11%3A%20Looping-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Loops%20%26%20Ternary-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: The Magic Cannon — 100 XP)

**Level 11 — Looping:**
Consolas sur muhafızlarından Skorin, büyük bir ateş taşı (`fire gem`) ve elektrik taşından (`electric gem`) güç alan devasa bir büyülü top inşa etmiştir:
- Kolun her **3.** dönüşünde ateş taşı aktifleşir ve top bir **Ateş (`Fire`)** patlaması üretir.
- Kolun her **5.** dönüşünde elektrik taşı aktifleşir ve top bir **Elektrik (`Electric`)** patlaması üretir.
- İkisi aynı anda çakıştığında (hem 3'ün hem 5'in katlarında, yani her **15.** dönüşte) güçlü bir **Birleşik (`Combined / Electric and Fire`)** patlama üretir.
- Diğer tüm turlarda top **`Normal`** atış yapar.

### Hedefler (Objectives):
- `1` ile `100` arasındaki değerler üzerinde döngü kurarak mürettebatın hangi turda hangi patlama türünü beklemesi gerektiğini kalan (`%`) operatörüyle belirleyip ekrana yazdırmak.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- Sabit bir sınır yerine, önce `do-while` döngüsüyle kullanıcıdan `0` ile `100` arasında geçerli bir atış sayısı (`blast`) aldım.
- Ardından `for (int i = 0; i < blast; i++)` döngüsü içinde uzun `if - else if - else` blokları yazmak yerine **iç içe ternary (`? :`) operatörü** kullanarak tek satırda önce `15`'e (hem 3 hem 5), sonra `3`'e, sonra `5`'e bölünebilirliği kontrol edip sonucu ekrana yazdırdım:
  ```csharp
  Console.WriteLine($"{i}.{(i % 15 == 0 ? "combined blast" : i % 3 == 0 ? "Fire" : i % 5 == 0 ? "Electric" : "Normal")}");
  ```

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Büyülü top patlama türü hesaplayıcısı (`LevelTask.Task10.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 09 - The Prototype](../09-The-Prototype/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [11 - The Replicator of D'To ➡️](../11-The-Replicator-of-DTo/README-tr.md)

</div>
