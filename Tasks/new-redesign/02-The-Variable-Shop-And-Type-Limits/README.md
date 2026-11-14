# 02 - The Variable Shop & Veri Tipi Sınırları (Type Limits)

## Kitaptaki Görev (Challenge)
**Level 6 & Level 7 - The C# Type System / Math:** C# içerisindeki sayısal veri tiplerinin sınırlarını (`MinValue`, `MaxValue`), özel ondalıklı değerleri (`PositiveInfinity`, `NaN`), tip taşmasını (overflow) ve kayan noktalı sayıların (`float`) hassasiyet sınırlarını deneyimlemek.

## Nasıl Yaptım?
- `int.MaxValue`, `short.MinValue` ve `short.MaxValue` özelliklerini kullanarak tam sayı tiplerinin alabileceği en küçük ve en büyük değerleri inceledim.
- `double.PositiveInfinity` ve `double.NaN` sabitlerini ekrana yazdırdım.
- İki adet `30000` değerindeki `short` değişkenini toplayıp `(short)(a + b)` şeklinde cast ederek `short` sınırının (`32767`) aşılmasında oluşan **overflow (taşma)** durumunu test ettim.
- `float` tipinde çok büyük bir sayı (`10000`) ile çok küçük bir sayıyı (`0.00001f`) toplayarak kayan noktalı sayıların hassasiyet (precision) davranışını gözlemledim.
