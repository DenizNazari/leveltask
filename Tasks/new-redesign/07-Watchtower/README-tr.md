<img src="../../../assets/shield.gif" align="right" width="96" alt="Watchtower Shield" />

<div align="center">

# 🗼 07 - Watchtower

### Gözetleme kulesine göre düşmanın $(x, y)$ koordinatlarını iki farklı algoritmayla 9 pusula yönüne eşleyen karar yapısı.

![Level](https://img.shields.io/badge/Seviye-9%3A%20Decision%20Making-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Conditionals%20%26%20Coordinates-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: Watchtower — 100 XP)

**Level 9 — Decision Making:**
Consolas çevresindeki bölgede bir düşman görüldüğünde seni uyarabilen gözetleme kuleleri vardır. Kuleye göre düşmanın $(x, y)$ koordinatlarına bakarak hangi yönden yaklaştığını aşağıdaki tabloya göre bildiren bir program yazman gerekir:

| | `x < 0` | `x = 0` | `x > 0` |
|:---:|:---:|:---:|:---:|
| **`y > 0`** | **NW** *(Kuzeybatı)* | **N** *(Kuzey)* | **NE** *(Kuzeydoğu)* |
| **`y = 0`** | **W** *(Batı)* | **!** *(Burada / Origin)* | **E** *(Doğu)* |
| **`y < 0`** | **SW** *(Güneybatı)* | **S** *(Güney)* | **SE** *(Güneydoğu)* |

### Hedefler (Objectives):
- Kullanıcıdan gözetleme kulesinin konumuna göre düşmanın koordinatlarını belirten bir `x` ve bir `y` değeri istemek.
- Yukarıdaki tabloyu, `if` ifadelerini ve ilişkisel operatörleri (`<`, `>`, `==`) kullanarak düşmanın hangi yönden geldiğini bildiren bir mesaj göstermek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

Bu görevi hem algoritma kısalığını hem de açık mantıksal kombinasyonları göstermek amacıyla **iki farklı yaklaşımla (Version 1 ve Version 2)** çözdüm:

1. **1. Yaklaşım (`direction1` — Dinamik String Birleştirme):**
   9 durumu tek tek yazmak yerine problemi iki bağımsız eksene (`y` ve `x`) ayırdım:
   - İlk `if-else if` bloğu yalnızca dikey eksene (`y > 0` ise `"N"`, `y < 0` ise `"S"`) bakar.
   - İkinci `if-else if` bloğu yatay eksene (`x > 0` ise `+= "E"`, `x < 0` ise `+= "W"`) bakar.
   Böylece yalnızca 4 koşul kontrolüyle ara yönler (`NE`, `NW`, `SE`, `SW`) otomatik olarak birleşir.
2. **2. Yaklaşım (`direction2` — Mantıksal `&&` Operatörü ile Açık Kontrol):**
   Tablodaki 9 hücrenin tamamını (`y > 0 && x > 0`, vb. ve merkez için `"Origin"`) mantıksal VE (`&&`) operatörüyle açıkça kontrol ederek yazdırdım.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — İki farklı yön tespit algoritmasını içeren uygulama (`LevelTask.Task07.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 06 - Repairing the Clocktower](../06-Repairing-the-Clocktower/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [08 - Buying & Discounted Inventory ➡️](../08-Buying-and-Discounted-Inventory/README-tr.md)

</div>
