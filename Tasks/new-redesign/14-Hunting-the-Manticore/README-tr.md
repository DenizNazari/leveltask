<img src="../../../assets/manticore.gif" align="right" width="96" alt="The Manticore Boss" />

<div align="center">

# 🐉 14 - Boss Battle: Hunting the Manticore

### The Prototype ve The Magic Cannon mekaniklerini iki oyunculu sıra tabanlı bir topçu savunma oyununda birleştiren ilk büyük Boss Battle.

![Level](https://img.shields.io/badge/Seviye-14%3A%20Memory%20Management-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-250%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Methods%20%26%20Game%20Loop-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: Hunting the Manticore — 250 XP)

**Level 14 — Memory Management:**
Uncoded One'ın hava gemisi **Manticore**, Consolas şehrine topyekûn bir saldırı başlatmıştır. Şehri savunmak için Mylara'nın konum tespit prototipini (*The Prototype*) ve Skorin'in büyülü topunu (*The Magic Cannon*) birleştiren iki oyunculu bir oyun oluşturman gerekir:

- **1. Oyuncu (Manticore Pilotu):** Manticore'un şehirden ne kadar uzakta olduğunu (`0` ile `100` arası) belirler, ardından ekran temizlenir (`Console.Clear()`).
- **2. Oyuncu (Şehir Savunmacısı):** Manticore (`10 HP`) veya şehir (`15 HP`) yok edilene kadar tekrar tekrar atış menzili seçer. Her denemede oyuncuya hedefi aştığı (`OVERSHOT`), kısa düştüğü (`FELL SHORT`) veya tam isabet ettirdiği (`DIRECT HIT`) söylenir.
- **Büyülü Top Hasarı:** Normal turlarda `1` hasar, tur sayısı `3`'ün veya `5`'in katı olduğunda (Ateş veya Elektrik) `3` hasar, hem `3` hem `5`'in katı olduğunda (Birleşik Ateş-Elektrik) `10` hasar verir.
- Manticore isabet sonrasında hâlâ hayattaysa şehre `1` hasar verir.

```text
STATUS: Round: 1  City: 15/15  Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 50
That round OVERSHOT the target.
```

### Hedefler (Objectives):
- Oyunun başlangıç durumunu kurmak: Manticore `10` can, şehir `15` can ile başlar; oyun `1.` turdan başlar.
- 1. oyuncudan Manticore'un şehre olan mesafesini (`0` ile `100` arası) girmesini istemek ve ekranı temizlemek.
- Manticore veya şehrin canı `0`'a ulaşana kadar oyunu bir döngü içinde çalıştırmak.
- Her turun başında tur numarasını, şehrin canını ve Manticore'un canını göstermek.
- Tur numarasına göre topun o turda ne kadar hasar vereceğini hesaplamak (`10`, `3` veya `1`).
- 2. oyuncudan hedef menzili almak ve menzilin çok yüksek, çok düşük veya tam isabet olduğunu bildirmek; isabet halinde Manticore'un canını beklenen hasar kadar azaltmak.
- Manticore hâlâ hayattaysa şehrin canını `1` azaltmak, bir sonraki tura geçmek ve oyun bittiğinde sonucu ekrana yazdırmak.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

### 1. Önceki Görevden Metot Yeniden Kullanımı (`askforNumber`)
`13 - Taking a Number` görevinde geliştirdiğim aralık doğrulamalı `askforNumber(string text, int min, int max)` yerel fonksiyonunu (local function) bu projeye taşıyarak 1. oyuncunun Manticore mesafesini yalnızca `1–100` aralığında girebilmesini garanti altına aldım.

### 2. Tek Değişkenli Tur ve Şehir Canı Yönetimi
Şehir her başarısız turda `1` can kaybettiği için, ayrı bir `cityHealth` değişkeni tutmak yerine `for (int round = 15; round >= 0; round--)` döngüsü kurarak:
- Kalan şehir canını doğrudan `round` değişkeniyle (`{round}/15`),
- Mevcut tur sayısını ise `15 - round` ifadesiyle dinamik olarak yönettim.

### 3. İç İçe Ternary Operatörlerle Hasar ve Menzil Hesaplaması
Uzun `if-else` blokları yerine hem topun o turdaki hasarını (`damage`) hem de atışın hedefe göre durumunu (`statusRange`: `0` tam isabet, `1` uzun, `-1` kısa) iç içe ternary (`? :`) operatörleriyle tek satırda hesapladım:
```csharp
int damage = (15 - round) % 15 == 0 ? 10 : ((15 - round) % 3 == 0 ? 3 : ((15 - round) % 5 == 0 ? 3 : 1));
int statusRange = cannonRange == manticoreDistance ? 0 : (cannonRange >= manticoreDistance ? 1 : -1);
```

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Hunting the Manticore Boss Battle uygulaması (`LevelTask.Task14.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 13 - Taking a Number](../13-Taking-a-Number/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [15 - Simula's Test ➡️](../15-Simulas-Test/README-tr.md)

</div>
