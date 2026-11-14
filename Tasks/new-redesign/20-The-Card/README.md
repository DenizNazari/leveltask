# 20 - The Card

## Kitaptaki Görev (Challenge)
**Level 24 - Catacombs of the Class:** 4 renk (`Red`, `Green`, `Blue`, `Yellow`) ve 14 kart değerinden (`1-10` arası sayılar ve `$`, `%`, `^`, `&` sembolleri) oluşan `56` kartlık bir deste oluşturmak. Kartın sayı mı yoksa sembol mü olduğunu ayırt etmek ve tüm desteyi ekrana yazdırmak.

## Nasıl Yaptım?
- `CartColors` ve `CartTypes` enum'larını oluşturup `Cart` sınıfını tasarladım.
- Kartın sembol olup olmadığını `public string cartcarakter => (int)Type > 10 ? "Special Character" : "Regular Character";` expression-bodied property'si ile belirledim.
- **Ekstra Görselleştirme:** Bir önceki görevde yazdığım `color` sınıfını buraya entegre ederek ve `PadRight(25)` ile metin hizalaması yaparak her kartı kendi renginde (Kırmızı, Yeşil, Mavi, Sarı) **ASCII çerçeveli bir oyun kartı** görünümünde konsola çizdirdim.
