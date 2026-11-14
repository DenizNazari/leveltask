# 04 - The Dominion of Kings

## Kitaptaki Görev (Challenge)
**Level 7 - Math:** Üç kralın krallıklarının toplam puanını hesaplamak. Her **Estate** `1` puan, her **Duchy** `3` puan ve her **Province** `6` puan değerindedir. Kullanıcıdan bu üç mülkün sayısını alıp toplam puanı hesaplamak.

## Nasıl Yaptım?
- Toplam puanı tutmak için `score = 0` başlangıç değişkeni tanımladım.
- Kullanıcıdan sırasıyla `provinces`, `duchies` ve `estates` adetlerini `int.Parse(Console.ReadLine())` ile aldım.
- Her birini kendi katsayısıyla (`6`, `3` ve `1`) çarparak `score` değişkenine ekledim ve string interpolation (`$"score:{score}"`) kullanarak sonucu ekrana yazdırdım.
