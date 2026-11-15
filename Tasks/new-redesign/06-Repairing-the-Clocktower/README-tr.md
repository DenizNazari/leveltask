<img src="../../../assets/quest-scroll.gif" align="right" width="96" alt="Clocktower Gear" />

<div align="center">

# 🕰️ 06 - Repairing the Clocktower

### Kalan operatörü (`% 2`) ve `if-else` karar yapısıyla Saat Kulesi'nin çift/tek vuruşlarını (`tick` / `tock`) belirleyen uygulama.

![Level](https://img.shields.io/badge/Seviye-9%3A%20Decision%20Making-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-If%2FElse%20%26%20Modulo-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge: Repairing the Clocktower — 100 XP)

**Level 9 — Decision Making:**
Son saldırılar Consolas'ın büyük Saat Kulesi'ne zarar vermiştir. Kuleye giren sayı **çift (`even`)** olduğunda sarkaç sola (`"Tick"`), **tek (`odd`)** olduğunda ise sağa (`"Tock"`) sallanmalıdır.

### Hedefler (Objectives):
- Konsoldan girdi olarak bir sayı almak.
- Sayı çift ise `"Tick"`, tek ise `"Tock"` kelimesini ekrana yazdırmak.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

- Kullanıcıdan alınan tam sayının (`clock`) `2` ile bölümünden kalanı `if (clock % 2 == 0)` koşuluyla kontrol ettim.
- Kalan `0` olduğunda sayı çift olduğu için `"tick"`, aksi durumda `else` bloğunda `"tock"` çıktısını ürettim.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Saat Kulesi tek/çift kontrol uygulaması (`LevelTask.Task06.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 05 - The Defense of Consolas](../05-The-Defense-of-Consolas/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [07 - Watchtower ➡️](../07-Watchtower/README-tr.md)

</div>
