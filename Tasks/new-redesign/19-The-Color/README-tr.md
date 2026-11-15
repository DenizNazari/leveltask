<img src="../../../assets/prism.gif" align="right" width="96" alt="RGB Color Prism" />

<div align="center">

# 🎨 19 - Boss Battle: The Color

### 24-bit TrueColor ANSI kaçış kodlarıyla konsolda gerçek RGB renk önizlemesi sunan nesne yönelimli `Color` sınıfı.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20ANSI%20TrueColor-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: The Color — 100 XP)

**Level 24 — The Catacombs of the Class (İkinci Kaide):**
İkinci kaide, bir rengi kırmızı (`R`), yeşil (`G`) ve mavi (`B`) kanallarıyla (`0–255` arası; `0` tamamen kapalı, `255` tamamen açık) temsil eden bir `Color` sınıfı oluşturmanı ister:

```text
┌──────────┐   R ───────────────● 255 ↕
│          │   G ─────────●────── 165 ↕
│          │   B ●───────────────   0 ↕
└──────────┘
```

Kaide üzerinde sık kullanılan 8 renk ve RGB kanal değerleri tanımlanmıştır:

| Renk | Kırmızı (`R`) | Yeşil (`G`) | Mavi (`B`) |
|---|:---:|:---:|:---:|
| **White (Beyaz)** | `255` | `255` | `255` |
| **Black (Siyah)** | `0` | `0` | `0` |
| **Red (Kırmızı)** | `255` | `0` | `0` |
| **Orange (Turuncu)** | `255` | `165` | `0` |
| **Yellow (Sarı)** | `255` | `255` | `0` |
| **Green (Yeşil)** | `0` | `128` | `0` |
| **Blue (Mavi)** | `0` | `0` | `255` |
| **Purple (Mor)** | `128` | `0` | `128` |

### Hedefler (Objectives):
- Kırmızı (`R`), yeşil (`G`) ve mavi (`B`) kanalları için property'lere sahip yeni bir `Color` sınıfı tanımlamak.
- Yeni `Color` nesneleri oluşturmak için uygun kurucu metotlar (`constructors`) eklemek.
- Yaygın kullanılan sekiz renge kolay erişim sağlamak için `static` property'ler oluşturmak.
- `Main` metodunda `Color` türünde iki değişken oluşturmak; birini constructor ile, diğerini static property ile tanımlayıp her ikisinin R, G, B kanal değerlerini ekrana yazdırmak.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

Kitaptaki görev yalnızca RGB sayılarını tutan bir veri sınıfı ve ekrana sayısal kanal değerlerini (`R, G, B`) yazdırmayı istese de, oluşturulan rengin gerçekten nasıl göründüğünü terminalde canlı olarak deneyimleyebilmek için sınıfa **24-bit TrueColor ANSI Escape Sequence** motoru ekledim.

### 1. Kapsülleme (Encapsulation) ve Constructor Chaining
- `_r`, `_g`, `_b` özel alanlarını (`private field`) `R`, `G`, `B` property'leri üzerinden kapsülledim ve sınır dışı değerler için `ArgumentOutOfRangeException` kontrolü tanımladım.
- Parametresiz kurucu metodu `public color() : this(0, 0, 0)` şeklinde **constructor chaining** ile ana kurucuya (`color(int r, int g, int b)`) bağlayarak varsayılan siyah rengi oluşturmasını sağladım.
- Hazır renk paletini `public static color Orange => new color(255, 165, 0);` gibi statik fabrika property'leri olarak tanımladım.

### 2. ANSI 24-Bit TrueColor Konsol Renklendirme Motoru
Standart `System.ConsoleColor` yalnızca 16 sabit rengi desteklerken, yazdığım `color` sınıfı `\x1b[38;2;{R};{G};{B}m` ANSI kaçış dizisini kullanarak **16.7 milyon rengin tamamını** doğrudan konsol çıktısına uygular:
- **`testYourColor()`:** Nesnenin kendi RGB değerlerini kullanarak metni o rengin gerçek tonuyla ekrana basar ve ardından `\x1b[0m` ile konsol rengini sıfırlar.
- **`setConsoleColor()` & `resetConsoleColor()`:** Konsolun aktif yazı rengini ilgili `color` nesnesinin RGB tonuna geçirir (bu özellik bir sonraki görev olan **20 - The Card** içinde ASCII kartları renklendirmek için de yeniden kullanılmıştır).
- **`setColorText(color color, string text)`:** Herhangi bir metni verilen RGB rengiyle sarmalayıp döndüren statik yardımcı metot.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `color` sınıfı ve ANSI TrueColor konsol renklendirme metotları (`LevelTask.Task19.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 18 - The Point](../18-The-Point/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [20 - The Card ➡️](../20-The-Card/README-tr.md)

</div>
