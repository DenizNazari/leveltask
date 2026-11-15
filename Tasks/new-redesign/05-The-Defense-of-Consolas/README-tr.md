<img src="../../../assets/shield.gif" align="right" width="96" alt="Shield of Consolas" />

<div align="center">

# 🛡️ 05 - The Defense of Consolas

### Hedeflenen şehir bloğunun 4 komşu savunma koordinatını hesaplayan, konsol renklerini/başlığını özelleştiren ve sesli uyarı (`Console.Beep`) veren savunma sistemi.

![Level](https://img.shields.io/badge/Seviye-8%3A%20Console%202.0-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-200%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-Console%202.0%20UI-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: The Defense of Consolas — 200 XP)

**Level 8 — Console 2.0:**
Uncoded One, hareketli hava gemisi *Manticore* ile Consolas şehrine ateş topları fırlatmaktadır. Satranç tahtası gibi numaralandırılmış şehir bloklarını korumak için 4 kişilik büyülü bariyer ekibinin, hedef alınan bloğun **4 komşu bloğuna** (sol, alt, sağ, üst) konuşlandırılması gerekir:

| | 4 | 5 | 6 |
|:---:|:---:|:---:|:---:|
| **7** | ` ` | 🛡️ **(7, 5)** | ` ` |
| **6** | 🛡️ **(6, 4)** | 🎯 **Hedef (6, 5)** | 🛡️ **(6, 6)** |
| **5** | ` ` | 🛡️ **(5, 5)** | ` ` |

```text
Target Row? 6
Target Column? 5
Deploy to:
(6, 4)
(5, 5)
(6, 6)
(7, 5)
```

### Hedefler (Objectives):
- Kullanıcıdan hedef satır (`Target Row`) ve sütun (`Target Column`) bilgisini istemek.
- Ekibin konuşlandırılacağı komşu satır ve sütunları hesaplamak.
- Konuşlanma talimatlarını seçtiğin farklı bir renkte göstermek.
- Pencere başlığını `"Defense of Consolas"` olarak değiştirmek.
- Sonuçlar hesaplanıp gösterildiğinde `Console.Beep` ile bir ses çalmak.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- **Konsol Özelleştirmesi:** `Console.BackgroundColor = ConsoleColor.DarkMagenta`, `Console.ForegroundColor = ConsoleColor.White` ve `Console.Title = "The Defense of Consolas"` ayarlarıyla konsol arayüzünü özelleştirdim.
- **Koordinat Hesaplama ve Sesli Uyarı:** Kullanıcıdan hedef `row` ve `column` değerlerini aldıktan sonra `Console.Beep(440, 1000)` ile 440 Hz frekansında 1 saniyelik alarm sesi çaldırdım ve 4 komşu koordinatı (`(row + 1, column)`, `(row - 1, column)`, `(row, column + 1)`, `(row, column - 1)`) tek bir string interpolation ifadesiyle ekrana yazdırdım.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Consolas savunma konuşlandırma hesaplayıcısı (`LevelTask.Task05.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 04 - The Dominion of Kings](../04-The-Dominion-of-Kings/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [06 - Repairing the Clocktower ➡️](../06-Repairing-the-Clocktower/README-tr.md)

</div>
