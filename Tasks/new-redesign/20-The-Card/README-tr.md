<img src="../../../assets/cards.gif" align="right" width="96" alt="The Card Deck" />

<div align="center">

# 🃏 20 - Boss Battle: The Card

### 56 kartlık desteyi oluşturup her kartı kendi RGB renginde ve ASCII çerçeve tasarımında konsola çizen nesne yönelimli kart sistemi.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20ASCII%20Art-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: The Card — 100 XP)

**Level 24 — The Catacombs of the Class (Üçüncü Kaide):**
C# dünyasının dijital diyarlarında bizimkilere benzeyen ama bazı farklılıkları olan oyun kartları vardır:
- Her kartın bir **rengi (`Color`)** vardır: `Red` (Kırmızı), `Green` (Yeşil), `Blue` (Mavi), `Yellow` (Sarı).
- Her kartın bir **değeri/rütbesi (`Rank`)** vardır: `1`'den `10`'a kadar sayılar ve ardından gelen `$`, `%`, `^`, `&` sembolleri.
- Üçüncü kaide, bu yapıdaki bir oyun kartını temsil eden bir `Card` sınıfı oluşturmanı ister.

### Hedefler (Objectives):
- Kart renkleri ve kart değerleri (ranks) için `enum` tanımları oluşturmak.
- Yukarıda açıklandığı gibi bir renk ve değere sahip kartı temsil eden `Card` sınıfını tanımlamak.
- Bir kartın **sayı kartı (`number card`)** mı yoksa **sembol kartı (`symbol card` — resimli kartların karşılığı)** mı olduğunu belirten property veya metotlar eklemek.
- `Main` metodunda tüm deste için (her renk ile her değer kombinasyonu: $4 \times 14 = 56$ kart) birer `Card` nesnesi oluşturup her birini ekrana yazdırmak (örneğin `"The Red Ampersand"` ve `"The Blue Seven"`).
- **Soruyu Yanıtla:** *Sence neden burada renk için bir `enum` kullandık da bir önceki görevde `Color` sınıfı oluşturduk?*

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

Kitaptaki görev kartların yalnızca düz metin olarak (`"The Red Ampersand"`) alt alta yazdırılmasını istese de, bir önceki görevde (`19 - The Color`) geliştirdiğim **ANSI RGB `color` sınıfını** bu projeye entegre ederek 56 kartın tamamını **kendi gerçek renginde (Kırmızı, Yeşil, Mavi, Sarı) ve ASCII oyun kartı çerçevesi içinde** görselleştirdim.

### 1. `CartColors` ve `CartTypes` Enum Modellemesi
- Sabit 4 kart rengini `CartColors` (`Red`, `Green`, `Blue`, `Yellow`) ve 14 kart değerini `CartTypes` (`ONE`..`TEN`, `DollarSign`, `PercentSign`, `Caret`, `Ampersand`) enum'ları ile tanımladım.
- **`cartcarakter` Özelliği:** Enum değerlerinin arka plandaki tam sayı (`int`) karşılıklarından yararlanarak kartın sembol mü yoksa sayı kartı mı olduğunu tek satırlık bir expression-bodied property ile belirledim:
  ```csharp
  public string cartcarakter => (int)Type > 10 ? "Special Character" : "Regular Character";
  ```

### 2. Dinamik Metin Hizalama (`PadRight`) ve Renkli Raw String Literal ASCII Kart Çizimi
- `DisplayCartInfo()` metodu, kartın `CartColors` enum değerini bir `switch` expression ile `19 - The Color` görevindeki `color` sınıfının statik renk nesnelerine (`color.Red`, `color.Green`, `color.Blue`, `color.Yellow`) eşler.
- Kartın ismi farklı uzunluklarda olabileceği için (`"The Red 1"` vs `"The Yellow PercentSign"`), ASCII çerçevesinin sağ duvarının kaymaması adına `("    The " + cartText).PadRight(25)` ile metni sabit 25 karaktere hizaladım ve C# 11 **Raw String Literal (`$""" ... """`)** kullanarak kartı konsola çizdirdim:
  ```text
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXX
   XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX    The Red Ampersand    XXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX                         XXXX
  XXXX                         XXXX
   XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    XXXXXXXXXXXXXXXXXXXXXXXXXXXX
  ```

### 3. Kitaptaki Sorunun Yanıtı
> *"Neden burada renk için `enum` kullandık da bir önceki görevde `Color` sınıfı oluşturduk?"*

Bir önceki görevde (`The Color`) renk, her biri `0–255` arasında değişen 3 kanalın ($256^3 \approx 16.7\text{ milyon}$ olası kombinasyon) oluşturduğu karmaşık bir veri yapısıydı. Oysa bu kart oyununda kartların alabileceği renkler yalnızca **4 sabit ve önceden bilinen seçenekle (`Red`, `Green`, `Blue`, `Yellow`)** sınırlıdır; bu nedenle kapalı bir küme için `enum` kullanmak tip güvenliği ve sadelik açısından en doğru yaklaşımdır.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `Cart`, `CartColors`, `CartTypes` ve ANSI `color` sınıflarını içeren uygulama (`LevelTask.Task20.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 19 - The Color](../19-The-Color/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [21 - The Locked Door ➡️](../21-The-Locked-Door/README-tr.md)

</div>
