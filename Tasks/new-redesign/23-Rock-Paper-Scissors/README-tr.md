<img src="../../../assets/crown.gif" align="right" width="96" alt="Arena Crown" />

<div align="center">

# 🪨📄✂️ 23 - Boss Battle: Rock-Paper-Scissors

### İki oyunculu, gizli tuş okumalı (`ReadKey`) ve dosya tabanlı skor kayıt (`StreamWriter`) sistemine sahip nesne yönelimli Taş-Kağıt-Makas oyunu.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-OOP%20%26%20File%20I%2FO-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: Rock-Paper-Scissors — 150 XP)

**Level 24 — The Catacombs of the Class (Birinci Tasarım Kaidesi):**
İlk tasarım kaidesi, aşağıda kuralları verilen **Taş-Kağıt-Makas (Rock-Paper-Scissors)** oyunu için nesne yönelimli bir tasarım (nesneler, sınıflar ve aralarındaki etkileşim) oluşturmanı ister:

- İki insan oyuncu birbirine karşı yarışır.
- Her oyuncu `Rock` (Taş), `Paper` (Kağıt) veya `Scissors` (Makas) seçer.
- Oyuncuların seçimlerine göre turun kazananı belirlenir: **Taş Makası yener, Makas Kağıdı yener, Kağıt Taşı yener.** İki oyuncu da aynı seçeneği seçerse tur berabere (`draw`) biter.
- Oyun her turun sonunda kimin kazandığını ekranda göstermelidir.
- Oyun pencere kapatılana kadar turları çalıştırmaya devam etmeli, ancak her oyuncunun kaç kez kazandığının ve kaç beraberlik olduğunun geçmiş kaydını (skor tablosunu) hafızada tutmalıdır.

### Hedefler (Objectives):
- Taş-Kağıt-Makas oyununu oluşturmak için gerekebilecek nesneleri ve sınıfları CRC kartları (veya uygun bir alternatif) ile ana hatlarıyla belirlemek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

Kitaptaki görev yalnızca kağıt üzerinde kavramsal bir sınıf/CRC tasarımı istese de, tasarladığım nesne yönelimli mimariyi doğrudan çalışan, iki oyuncunun aynı klavyede birbirinin hamlesini görmeden oynayabildiği ve maç geçmişini diske kaydeden **tam kapsamlı bir C# konsol oyununa** dönüştürdüm.

### 1. Nesne Yönelimli Sınıf Tasarımı (`RockPaperScissors`, `Player`, `rockpercentageEnum`)
- **`Player` Sınıfı:** Her oyuncunun adını (`Name`), toplam skorunu (`Score`) ve o turdaki hamle seçimini (`playerChoise`) kapsüller (`private set`). Skor artışı yalnızca `IncrementScore()` metodu üzerinden, hamle ataması ise `SetChoice(rockpercentageEnum choice)` metodu üzerinden kontrollü olarak yapılır.
- **`RockPaperScissors` Oyun Motoru Sınıfı:** İki `Player` nesnesini (`Player1`, `Player2`), tur sayacını (`raund`) ve beraberlik sayısını (`draw`) yönetir.
- **Hesaplanan Özellikler (Expression-Bodied Properties):** Maç sonundaki genel kazanan ve kaybeden, anlık skor durumuna göre dinamik olarak hesaplanır:
  ```csharp
  public string Winner => Player1.Score > Player2.Score ? Player1.Name : Player1.Score < Player2.Score ? Player2.Name : "Tie";
  public string Loser  => Player1.Score < Player2.Score ? Player1.Name : Player1.Score > Player2.Score ? Player2.Name : "Tie";
  ```

### 2. Gizli Hamle Girişi (`Console.ReadKey(true)` & `switch` Expression)
İki insan oyuncu aynı bilgisayarda sırayla seçim yaparken 1. oyuncunun bastığı tuşun ekranda görünmemesi (2. oyuncunun kopya çekmemesi) için `Console.ReadLine()` yerine **`Console.ReadKey(intercept: true)`** kullandım:
- Oyuncu `R`, `P` veya `S` tuşuna bastığında karakter konsola yazdırılmaz.
- Modern C# `switch` ifadesiyle tuş doğrudan hamleye dönüştürülür; geçersiz bir tuşa basılırsa `null` dönerek aynı oyuncudan tekrar seçim yapması istenir.

### 3. Kalıcı Skor Kayıt Sistemi (`StreamWriter` & `SaveScoresToFile`)
Oyuncular tur sonunda `F` tuşuna basarak maçı sonlandırdığında, `SaveScoresToFile()` metodu devreye girer ve `using (StreamWriter writer = new StreamWriter(SaveFile))` bloğu ile:
- Oyuncuların final skorlarını,
- Oynanan toplam tur sayısını (`raund`),
- Genel kazananı (`Winner`) ve kaybedeni (`Loser`) `RockPaperScissorsScores.txt` dosyasına kalıcı olarak yazar.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `RockPaperScissors`, `Player` ve `rockpercentageEnum` sınıflarını içeren oyun uygulaması (`LevelTask.Task23.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 22 - The Password Validator](../22-The-Password-Validator/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [24 - The 15-Puzzle ➡️](../24-15-Puzzle/README-tr.md)

</div>
