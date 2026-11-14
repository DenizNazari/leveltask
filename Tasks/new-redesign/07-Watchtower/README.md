# 07 - Watchtower

## Kitaptaki Görev (Challenge)
**Level 9 - Decision Making:** Gözetleme kulesinden düşmanın `x` ve `y` koordinatlarını alıp, düşmanın kuleye göre hangi yönde (`N`, `S`, `E`, `W`, `NE`, `NW`, `SE`, `SW` veya tam merkezde `Origin`) olduğunu tespit etmek.

## Nasıl Yaptım?
Bu görevi **iki farklı yaklaşımla (Version 1 ve Version 2)** çözdüm:
1. **1. Yöntem (`direction1` - String Birleştirme):** Önce `y` koordinatına bakarak kuzey (`N`) veya güney (`S`) harfini boş bir string'e ekledim, ardından bağımsız bir `if` ile `x` koordinatına bakarak doğu (`E`) veya batı (`W`) harfini sonuna ekledim. Böylece ekstra kombinasyon yazmadan `NE`, `SW` gibi ara yönler otomatik oluştu.
2. **2. Yöntem (`direction2` - Mantıksal `&&` Operatörü):** `&&` (VE) operatörü ile tüm 9 olasılığı (`y > 0 && x > 0`, vb. ve merkez için `Origin`) açıkça `if - else if - else` zinciriyle kontrol ettim.
