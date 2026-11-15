<img src="../../../assets/chest.gif" align="right" width="96" alt="Shop Chest" />

<div align="center">

# 🛒 08 - Buying Inventory & Discounted Inventory

### `switch` yapısı, Raw String Literal menü ve kullanıcı adına göre %50 dinamik indirim uygulayan mağaza fiyatlandırma sistemi.

![Level](https://img.shields.io/badge/Seviye-10%3A%20Switches-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP%20(2%20Görev)-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Switch%20%26%20Ternary-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görevler (Buying Inventory — 100 XP & Discounted Inventory — 50 XP)

**Level 10 — Switches:**
Tortuga'nın malzeme dükkanındaki ekipmanların fiyatlarını kullanıcının seçtiği menü numarasına göre gösteren ve dükkan sahibiyle olan dostluğun sayesinde kendi ismini girdiğinde tüm fiyatları yarıya (%50 indirim) indiren bir program oluşturmak:

| Menü No | Eşya (`Item`) | Normal Fiyat | İndirimli Fiyat (%50) |
|:---:|---|:---:|:---:|
| **1** | Rope | `10 gold` | `5 gold` |
| **2** | Torches | `15 gold` | `7 gold` |
| **3** | Climbing Equipment | `25 gold` | `12 gold` |
| **4** | Clean Water | `1 gold` | `0 gold` |
| **5** | Machete | `20 gold` | `10 gold` |
| **6** | Canoe | `200 gold` | `100 gold` |
| **7** | Food Supplies | `1 gold` | `0 gold` |

### Hedefler (Objectives):
- Yukarıdaki numaralandırılmış menüyü ekranda göstermek ve kullanıcıdan bir numara istemek.
- `switch` ifadesi veya deyimi kullanarak seçilen eşyanın maliyetini göstermek.
- **Discounted Inventory (50 XP):** Kullanıcıdan ayrıca adını istemek; girilen ad kendi adınla eşleşirse fiyatı yarıya düşürmek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- **Raw String Literal (`""" ... """`):** Çok satırlı mağaza menüsünü kaçış karakterleri (`\n`) kullanmadan temiz bir blok halinde ekrana yazdırdım.
- **Ternary Operatör ile Dinamik %50 İndirim:** `switch (itemNumber)` içindeki her `case` dalında ayrı `if-else` yazmak yerine `(playerName == "Deniz" ? 2 : 1)` ternary ifadesini bölen olarak kullandım; böylece kullanıcı `"Deniz"` adını girdiğinde fiyat otomatik olarak `2`'ye bölünerek %50 indirimli gösterilir.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Mağaza menüsü ve indirim hesaplayıcısı (`LevelTask.Task08.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 07 - Watchtower](../07-Watchtower/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [09 - The Prototype ➡️](../09-The-Prototype/README-tr.md)

</div>
