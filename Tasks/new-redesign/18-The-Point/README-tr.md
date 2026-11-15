<img src="../../../assets/prism.gif" align="right" width="96" alt="Cartesian Point" />

<div align="center">

# 📍 18 - Boss Battle: The Point

### İki boyutlu Kartezyen koordinat sisteminde noktaları temsil eden kapsüllenmiş `Point` sınıfı ve constructor chaining yapısı.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-75%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20Constructors-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: The Point — 75 XP)

**Level 24 — The Catacombs of the Class (Birinci Kaide):**
İlk kaide, iki boyutlu uzayda bir noktayı saklamak için bir `Point` sınıfı oluşturmanı ister. Her nokta, orijin adı verilen özel merkezi noktadan yatay uzaklığı belirten bir `x` koordinatı ve dikey uzaklığı belirten bir `y` koordinatı ile temsil edilir.

### Hedefler (Objectives):
- `X` ve `Y` özelliklerine (properties) sahip yeni bir `Point` sınıfı tanımlamak.
- Belirli bir `x` ve `y` koordinatından nokta oluşturmak için bir kurucu metot (`constructor`) eklemek.
- Orijin `(0, 0)` noktasında bir nokta oluşturmak için parametresiz bir kurucu metot eklemek.
- `Main` metodunda `(2, 3)` ve `(-4, 0)` konumlarında iki nokta oluşturup sınıfın çalıştığını göstermek üzere konsol ekranına `(x, y)` formatında yazdırmak.
- **Soruyu Yanıtla:** *`X` ve `Y` özelliklerin değiştirilemez (`immutable`) mi? Neden bu seçimi yaptın?*

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

### 1. Değiştirilemezlik (Immutability) ve Kapsülleme (`private set`)
- `X` ve `Y` koordinatlarını `public float X { get; private set; } = 0;` ve `public float Y { get; private set; } = 0;` olarak tanımladım; ayrıca tam sayı dışındaki ara koordinatları da destekleyebilmesi için `int` yerine `float` veri tipini tercih ettim.
- **Kitaptaki Sorunun Yanıtı:** Dışarıdan bakıldığında `X` ve `Y` özellikleri `private set` ile korunduğu için nesne oluşturulduktan sonra dış kod tarafından değiştirilemezdir (**external immutability**). Matematiksel bir nokta `(x, y)` değer nesnesi (value object) niteliği taşır; koordinatlarının rastgele dış müdahaleyle değişmemesi durum tutarlılığını korur.

### 2. Kurucu Metot Zincirleme (`Constructor Chaining` — `: this(0, 0)`)
Kod tekrarını önlemek amacıyla parametresiz kurucu metodu doğrudan iki parametreli ana kurucu metoda yönlendirdim:
```csharp
public Point() : this(0, 0)
{
}

public Point(float x, float y)
{
    X = x;
    Y = y;
}
```

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `Point` sınıfı ve koordinat testi (`LevelTask.Task18.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 17 - Vin Fletcher's Arrows](../17-Vin-Fletchers-Arrows/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [19 - The Color ➡️](../19-The-Color/README-tr.md)

</div>
