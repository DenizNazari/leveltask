# 19 - The Color

## Kitaptaki Görev (Challenge)
**Level 24 - Catacombs of the Class:** `(R, G, B)` kanallarından oluşan bir renk sınıfı (`color`) tasarlamak ve yaygın renkler (`White`, `Black`, `Red`, `Orange`, `Yellow`, `Green`, `Blue`, `Gold`) için `static` özellikler (factory properties) tanımlamak.

## Nasıl Yaptım?
- `R`, `G` ve `B` değerlerini kapsülleyerek `color(int r, int g, int b)` ve varsayılan `color() : this(0, 0, 0)` kurucularını yazdım.
- Yaygın kullanılan 8 rengi `public static color Red => new color(255, 0, 0);` gibi statik özellikler olarak tanımladım.
- **Ekstra Özellik:** Sadece sayısal RGB değerlerini tutmakla kalmayıp, **ANSI Escape Kodları** (`\x1b[38;2;{R};{G};{B}m`) kullanarak oluşturulan gerçek RGB rengini konsol ekranında canlı olarak renklendiren `testYourColor()`, `setConsoleColor()`, `resetConsoleColor()` ve `setColorText()` metotlarını ekledim!
