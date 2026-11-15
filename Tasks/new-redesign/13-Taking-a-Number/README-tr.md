<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Quest Scroll" />

<div align="center">

# 🔢 13 - Taking a Number

### Kullanıcıdan sayı alma ve aralık doğrulama işlemlerini soyutlayan aşırı yüklenmiş (`overloaded`) yardımcı metotlar.

![Level](https://img.shields.io/badge/Seviye-13%3A%20Methods-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Methods%20%26%20Validation-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: Taking a Number — 100 XP)

**Level 13 — Methods:**
Önceki görevlerin birçoğunda kullanıcıdan bir sayı almak gerekti. Aynı kodu tekrar tekrar yazmaktan kurtulmak için bu ortak işi yapan yeniden kullanılabilir metotlar oluşturmaya karar verdin.

### Hedefler (Objectives):
- `int AskForNumber(string text)` imzasına sahip bir metot yapmak. `text` parametresini konsol penceresinde göstermek, kullanıcıdan bir yanıt almak, bunu `int`'e dönüştürmek ve döndürmek:
  ```csharp
  int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
  ```
- `int AskForNumberInRange(string text, int min, int max)` imzasına sahip ikinci bir metot yapmak. Yalnızca girilen sayı `min` ve `max` değerleri arasındaysa döndürmek; aksi takdirde tekrar sormak.
- Bu metotları önceki programlardan en az birine yerleştirerek geliştirmek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- **Temel Sayı İsteme Metodu (`askForNumber(string text)`):** Parametre olarak gelen istem metnini (`text`) ekrana yazdırır ve `int.Parse(Console.ReadLine())` ile kullanıcının girdisini tam sayı olarak döndürür.
- **Aralık Doğrulamalı Metot (`askforNumber(string text, int min, int max)`):** Aynı metot ismini 3 parametreyle aşırı yükleyerek (method overloading benzeri yerel fonksiyon yapısı) `while (true)` döngüsü içinde girdinin `number >= min && number <= max` aralığında olup olmadığını denetledim; sınır dışındaki değerlerde kullanıcıya geçerli aralığı hatırlatıp tekrar girdi istedim.
- Bu metodu bir sonraki görev olan **`14 - Hunting the Manticore`** içinde Manticore'un `1–100` arası mesafesini güvenli şekilde almak için yeniden kullandım.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `askForNumber` metotları (`LevelTask.Task13.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 12 - The Laws of Freach](../12-The-Laws-of-Freach/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [14 - Hunting the Manticore ➡️](../14-Hunting-the-Manticore/README-tr.md)

</div>
