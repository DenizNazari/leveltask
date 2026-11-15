<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Quest Scroll" />

<div align="center">

# 🦆🐻 03 - The Four Sisters and the Duckbear

### Tam sayı bölmesi (`/`) ve kalan (`%`) operatörleriyle çikolata yumurtalarını paylaştıran ve Duckbear'ın daha karlı çıktığı sayıları döngüyle bulan uygulama.

![Level](https://img.shields.io/badge/Seviye-7%3A%20Math-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Division%20%26%20Modulo-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: The Four Sisters and the Duckbear — 100 XP)

**Level 7 — Math:**
Dört kız kardeş bir çikolata çiftliğine sahiptir ve her gün çikolata tavuklarının yumurtladığı çikolata yumurtalarını toplarlar. Ancak çoğu zaman yumurta sayısı dört kardeş arasında tam bölünmez ve bir çikolata yumurtasını kırmak onu mahveder. Kasabanın hakemi Chandra'nın planına göre dört kız kardeşin her biri her gün eşit sayıda çikolata yumurtası alacak ve kalan yumurtalar evcil hayvanları **Duckbear**'a yedirilecektir.

### Hedefler (Objectives):
- Kullanıcının o gün toplanan çikolata yumurtası sayısını girmesini sağlayan bir program oluşturmak.
- `/` ve `%` operatörlerini kullanarak her kız kardeşin kaç yumurta alması gerektiğini ve Duckbear'a kaç yumurta kaldığını hesaplamak.
- **Soruyu Yanıtla:** *Duckbear'ın her bir kız kardeşten daha fazla yumurta aldığı üç toplam yumurta sayısı nedir?*

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

### 1. Tam Sayı Bölmesi (`/`) ve Modülüs (`%`) Hesaplaması
- Kullanıcıdan toplanan yumurta sayısını (`eggs`) aldım.
- Her bir kız kardeşin alacağı eşit payı `(int)eggs / 4` (`eggsneeded`) ile, Duckbear'a kalan artığı ise `(int)eggs % 4` (`eggremainder`) ile hesaplayıp ekrana yazdırdım.

### 2. Kitaptaki Sorunun Algoritmik Çözümü (`if (i / 4 < i % 4)`)
> *"Duckbear'ın her bir kız kardeşten daha fazla yumurta aldığı toplam yumurta sayıları nelerdir?"*

Sayıları kağıt üzerinde tek tek denemek yerine, programa `1`'den `20`'ye kadar dönen bir `for` döngüsü ekledim ve `if (i / 4 < i % 4)` koşuluyla Duckbear'ın payının (`i % 4`) bir kız kardeşin payından (`i / 4`) büyük olduğu **tüm olası yumurta sayılarını (`1`, `2`, `3`, `6`, `7`, `11`)** otomatik olarak tespit edip ekrana yazdırdım:

| Toplam Yumurta (`i`) | Her Kız Kardeşin Payı (`i / 4`) | Duckbear'ın Payı (`i % 4`) |
|:---:|:---:|:---:|
| **1, 2, 3** | `0` | **1, 2, 3** |
| **6, 7** | `1` | **2, 3** |
| **11** | `2` | **3** |

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Yumurta paylaştırıcı ve `i / 4 < i % 4` analiz döngüsü (`LevelTask.Task03.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 02 - The Variable Shop & Type Limits](../02-The-Variable-Shop-And-Type-Limits/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [04 - The Dominion of Kings ➡️](../04-The-Dominion-of-Kings/README-tr.md)

</div>
