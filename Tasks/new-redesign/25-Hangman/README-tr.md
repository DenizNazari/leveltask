<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Hangman Scroll" />

<div align="center">

# 🪢 25 - Boss Battle: Hangman

### Kelime maskeleme (`_`), harf tahmini (`ReadKey`) ve kalan hak takibi yapan nesne yönelimli Adam Asmaca (`Hangman`) oyunu.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20String%20Manipulation-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: Hangman — 150 XP)

**Level 24 — The Catacombs of the Class (Üçüncü Tasarım Kaidesi):**
Üçüncü tasarım kaidesi, kelime tahmin oyunu **Hangman (Adam Asmaca)** için nesne yönelimli bir tasarım oluşturmanı ister:

- Oyun oyuncunun tahmin etmesi için bir kelime seçer ve başlangıçta tüm harfleri alt çizgi (`_`) olarak gösterir.
- Oyuncu her turda bir harf tahmin eder; harf kelimede varsa ilgili tüm konumlarda açılır, yoksa kalan tahmin hakkı azalır ve yanlış harfler listesine eklenir.
- Oyuncu tüm harfleri açtığında kazanır, tahmin hakkı bittiğinde kaybeder.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

Kitaptaki görev yalnızca kağıt üzerinde kavramsal bir sınıf tasarımı istese de, bu mimariyi `Hangman` sınıfı etrafında çalışan bir C# konsol oyununa dönüştürdüm:

- **`Hangman` Sınıfı ve Maskeleme:** Kurucu metotta gizli kelimeyi (`WordToGuess`) alıp `CurrentWordState = new string('_', wordToGuess.Length)` ile kelime uzunluğu kadar `_` maskesi oluşturdum.
- **`GuessLetter(char letter)` Metodu:**
  - Tahmin edilen harf `WordToGuess.Contains(letter)` koşulunu sağlıyorsa kelime taranır ve eşleşen her indeks `CurrentWordState.Remove(i, 1).Insert(i, letter.ToString())` ile gerçek harfe dönüştürülür.
  - Harf kelimede yoksa `wrongLetters` dizgesine eklenir ve kalan hak (`AttemptsLeft`) bir azaltılır.
- **Tek Tuşla Harf Girişi:** `Console.ReadKey().KeyChar` kullanarak oyuncunun Enter'a basmasına gerek kalmadan doğrudan harf tahmini yapmasını sağladım.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `Hangman` sınıfı ve oyun döngüsü (`leveltask.Tasks.new_redesign._25_Hangman.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 24 - The 15-Puzzle](../24-15-Puzzle/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; *Son Görev* ➡️

</div>
