# 13 - Taking a Number

## Kitaptaki Görev (Challenge)
**Level 13 - Methods:** Kullanıcıdan sayı isteme işlemini tekrar kullanılabilir metotlara dönüştürmek:
1. Parametre olarak soru metnini (`string text`) alıp kullanıcının girdiği tam sayıyı döndüren bir metot.
2. Soru metniyle birlikte `min` ve `max` sınırlarını alıp, kullanıcı bu aralıkta bir sayı girene kadar tekrar soran ikinci bir metot.

## Nasıl Yaptım?
- İlk metot olan `askForNumber(string text)` içinde metni ekrana yazdırıp `int.Parse(Console.ReadLine())` değerini döndürdüm.
- İkinci metot olan `askforNumber(string text, int min, int max)` içinde `while (true)` döngüsü kurarak girilen sayının `number >= min && number <= max` aralığında olup olmadığını kontrol ettim; aralık dışındaysa uyarı verip tekrar girdi istedim.
