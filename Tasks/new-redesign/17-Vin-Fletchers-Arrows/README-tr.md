<img src="../../../assets/arrow.gif" align="right" width="96" alt="Vin Fletcher's Arrow" />

<div align="center">

# 🏹 17 - Vin Fletcher's Arrows

### 4 ardışık kitap görevini (Classes, Information Hiding, Properties, Static) tek bir kapsüllenmiş `Arrow` sınıfında birleştiren tasarım.

![Level](https://img.shields.io/badge/Seviye-18--21%3A%20Classes%20%26%20Properties-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-350%20XP%20(4%20Görev)-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Challenge%20Serisi-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Encapsulation%20%26%20Properties-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görevler (4 Ardışık Görev — Toplam 350 XP)

Bu klasör, *The C# Player's Guide* kitabında Level 18'den Level 21'e kadar adım adım evrilen **4 ardışık ok yapımcılığı görevini** tek bir `Arrow` sınıfı üzerinde birleştirir:

### 1. Vin Fletcher's Arrows (Level 18 — Classes | 100 XP)
Usta ok yapımcısı Vin Fletcher için ok tasarımını ve maliyet hesaplamasını temsil eden bir `Arrow` sınıfı oluşturmak:

| Bileşen | Seçenekler ve Maliyetleri |
|---|---|
| **Ok Ucu (`Arrowhead`)** | `Steel` (**10 gold**), `Obsidian` (**5 gold**), `Wood` (**3 gold**) |
| **Tüy (`Fletching`)** | `Plastic` (**10 gold**), `Turkey Feathers` (**5 gold**), `Goose Feathers` (**3 gold**) |
| **Gövde Uzunluğu (`Shaft`)** | `60 cm` ile `100 cm` arası — santimetre başına **`0.05 gold`** |

### 2. Vin's Trouble (Level 19 — Information Hiding | 50 XP)
Alanların (`fields`) dışarıdan kontrolsüzce değiştirilmesini önlemek için `private` erişim belirleyicisiyle bilgi gizleme (encapsulation) uygulamak.

### 3. The Properties of Arrows (Level 20 — Properties | 100 XP)
Geleneksel `Get`/`Set` metotları yerine C# **Property** (`get; private set;` ve doğrulamalı `set`) yapısına geçmek.

### 4. Arrow Factories (Level 21 — Static | 100 XP)
Standart ok tipleri veya sınıf genelinde paylaşılan kurallar için `static` üyeler ve metotlar kullanmak:
- **Elite Arrow:** `Steel` ok ucu, `Plastic` tüy, `95 cm` gövde
- **Beginner Arrow:** `Wood` ok ucu, `Goose Feathers` tüy, `75 cm` gövde
- **Marksman Arrow:** `Steel` ok ucu, `Goose Feathers` tüy, `65 cm` gövde

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

### 1. Enum Sabitlerine Doğrudan Maliyet Atama (`: int`)
`GetCost()` metodunda uzun `switch-case` veya `if-else` blokları yazmak yerine, `ArrowHeadTypeEnum` ve `FletchingTypeEnum` sabitlerinin arka plandaki tam sayı (`int`) değerlerine doğrudan altın maliyetlerini atadım:
```csharp
enum ArrowHeadTypeEnum : int { Steel = 10, WOOD = 3, Obsidian = 5 }
enum FletchingTypeEnum : int { Plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3 }
```
Bu sayede `GetCost()` metodu yalnızca `(int)ArrowHeadType + (int)FletchingType + (ShaftLength * 0.05f)` işlemini yaparak maliyeti `O(1)` sürede doğrudan hesaplar.

### 2. Property Setter İçinde Sınır Doğrulaması (`ArgumentOutOfRangeException`)
Gövde uzunluğunu (`ShaftLength`) kapsülleyerek `set` bloğunda değerin `MinShaftLength` (`60`) ile `MaxShaftLength` (`100`) arasında olup olmadığını kontrol ettim; geçersiz bir uzunluk verildiğinde nesnenin bozuk durumda oluşmasını engellemek için `ArgumentOutOfRangeException` fırlattım.

### 3. Statik Konfigürasyon Yönetimi (`ChangeMinShaftLenght`)
Tüm `Arrow` örnekleri için geçerli olan minimum gövde uzunluğu sınırını (`private static int MinShaftLength`) çalışma zamanında güvenli bir şekilde güncelleyebilmek için doğrulamalı `public static void ChangeMinShaftLenght(int newMinShaftLength)` metodunu ekledim.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `Arrow` sınıfı ve enum tanımları (`LevelTask.Task17.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 16 - Simula's Soup](../16-Simulas-Soup/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [18 - The Point ➡️](../18-The-Point/README-tr.md)

</div>
