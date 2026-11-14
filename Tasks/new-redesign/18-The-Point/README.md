# 18 - The Point

## Kitaptaki Görev (Challenge)
**Level 24 - Catacombs of the Class:** 2 boyutlu düzlemde `(X, Y)` koordinatlarını temsil eden bir `Point` sınıfı oluşturmak. Hem `(x, y)` koordinatlarını alan bir kurucu metot (constructor) hem de orijin `(0, 0)` noktasını oluşturan parametresiz bir kurucu metot tanımlamak.

## Nasıl Yaptım?
- `X` ve `Y` özelliklerini `public float X { get; private set; } = 0;` şeklinde tanımladım.
- Parametresiz constructor'ı `: this(0, 0)` (constructor chaining) kullanarak iki parametreli `Point(float x, float y)` kurucusuna yönlendirdim.
- İki farklı nokta (`(5, 10)` ve `(15, 20)`) oluşturup koordinatlarını ekrana yazdırdım.
