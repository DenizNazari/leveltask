<img src="../../../assets/cauldron.gif" align="right" width="96" alt="Simula's Cauldron" />

<div align="center">

# 🍲 16 - Simula's Soup

### Üç farklı `enum` türünü (yemek türü, ana malzeme, baharat) isimlendirilmiş bir `ValueTuple` içinde birleştiren tarif oluşturucu.

![Level](https://img.shields.io/badge/Seviye-17%3A%20Tuples-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Tuples%20%26%20Enums-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: Simula's Soup — 100 XP)

**Level 17 — Tuples:**
Simula, sandığı bir `enum` ile yeniden çalıştırmandan etkilenir ve içindeki üç baharat şişesiyle (`HOT`, `SALTY`, `SWEET`) tekrar yemek pişirmeye başlar. Kullanıcının izin verilen seçenekler arasından bir yemek türü, bir ana malzeme ve bir baharat seçmesini sağlayan ve yapılan yemeği takip eden bir program yazman gerekir:

| Kategori | İzin Verilen Seçenekler |
|---|---|
| **Yemek Türü (`Type`)** | `Soup`, `Stew`, `Gumbo` |
| **Ana Malzeme (`Main Ingredient`)** | `Mushrooms`, `Chicken`, `Carrots`, `Potatoes` |
| **Baharat (`Seasoning`)** | `Spicy`, `Salty`, `Sweet` |

### Hedefler (Objectives):
- Yemek üzerindeki üç varyasyon için `enum` tanımları oluşturmak: tür (`soup`, `stew`, `gumbo`), ana malzeme (`mushrooms`, `chicken`, `carrots`, `potatoes`) ve baharat (`spicy`, `salty`, `sweet`).
- Yukarıdaki üç `enum` türünden oluşan bir çorbayı temsil eden bir **tuple** değişkeni oluşturmak.
- Kullanıcının izin verilen seçeneklerden bir tür, ana malzeme ve baharat seçmesini sağlayıp sonuçları tuple içine doldurmak.
- İşlem tamamlandığında çorba tuple değişkeninin içeriğini `"Sweet Chicken Gumbo"` gibi bir formatta ekrana yazdırmak.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

### 1. İsimlendirilmiş ValueTuple Döndüren Yerel Metot (`food()`)
Üç farklı `enum` türünü (`FoodTypeEnum`, `FoodManingredientEnum`, `FoodSeasoningEnum`) tek bir veri yapısında paketlemek için geriye **`(FoodTypeEnum FType, FoodManingredientEnum FMain, FoodSeasoningEnum FSeason)`** döndüren `food()` yerel fonksiyonunu yazdım.

### 2. `Enum.TryParse` ile Büyük/Küçük Harf Duyarsız Doğrulama
Kullanıcının girdiği üç metin girdisini de `Enum.TryParse<...>(input, ignoreCase: true, out ...)` ile aynı anda doğruladım:
- Üç seçim de ilgili `enum` sabitleriyle eşleşiyorsa metot doğrudan `(foodType, foodMain, foodSeasoning)` tuple değerini döndürür.
- Herhangi biri geçersizse kullanıcıyı uyarıp `while (true)` döngüsüyle tekrar seçim yapmasını ister.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `FoodTypeEnum`, `FoodManingredientEnum`, `FoodSeasoningEnum` ve Tuple uygulaması (`LevelTask.Task16.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 15 - Simula's Test](../15-Simulas-Test/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [17 - Vin Fletcher's Arrows ➡️](../17-Vin-Fletchers-Arrows/README-tr.md)

</div>
