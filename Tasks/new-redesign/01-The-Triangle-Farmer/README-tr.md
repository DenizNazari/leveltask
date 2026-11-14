<div align="center">

# 📐 01 - The Triangle Farmer

### Kullanıcıdan alınan taban ve yükseklik değerleriyle üçgenin alanını hesaplama.

![Level](https://img.shields.io/badge/Seviye-6%3A%20The%20C%23%20Type%20System-512BD4)
![C#](https://img.shields.io/badge/C%23-.NET%209-239120)
![Type](https://img.shields.io/badge/Tür-Görev%20(Challenge)-blue)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Challenge)

**Level 6 — The C# Type System** (*The C# Player's Guide*):

Kullanıcıdan bir üçgenin **taban (`Base`)** ve **yükseklik (`Height`)** değerlerini alıp aşağıdaki formülle alanını hesaplayarak konsola yazdıran bir program yazmak:

$$\text{Alan} = \frac{\text{Taban} \times \text{Yükseklik}}{2}$$

## 🛠️ Nasıl Yaptım?

- **Ondalıklı Hassasiyet:** Hem taban hem de yükseklik için ondalıklı sayıları desteklemek amacıyla `double` veri tipini kullandım.
- **Tür Dönüşümü:** İlk girdiyi `double.Parse(Console.ReadLine())` ile, ikinci girdiyi ise farklı bir dönüşüm yöntemi olan `Convert.ToDouble(Console.ReadLine())` ile sayıya çevirdim.
- **Çıktı:** `(bases * heights) / 2` işlemini doğrudan `Console.WriteLine(...)` içinde hesaplayıp ekrana yazdırdım.

## ▶️ Örnek Çıktı

```text
Base:
10.5
Height:
4
21
```

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Görev giriş noktası (`LevelTask.Task01.Program.Main`)
