# 14 - Boss Battle: Hunting the Manticore

## Kitaptaki Görev (Challenge)
**Level 14 - Memory Management (Part 1 Boss Battle):** Şimdiye kadar öğrenilen tüm konuları (değişkenler, koşullar, döngüler, metotlar ve büyülü top) birleştirerek Consolas şehrini uçan canavar **Manticore**'a karşı savunma oyunu geliştirmek:
- 1. Oyuncu Manticore'un şehre olan mesafesini (`1-100`) belirler.
- Şehrin `15`, Manticore'un `10` canı vardır.
- Her turda büyülü topun vereceği hasar hesaplanır (`3`'ün veya `5`'in katında `3`, `15`'in katında `10`, diğerlerinde `1` hasar).
- 2. Oyuncu menzil tahmini yapar; tam isabet (`direct hit`) olursa Manticore hasar alır, kısa (`undershot`) veya uzun (`overshot`) düşerse bilgi verilir.

## Nasıl Yaptım?
- Daha önce yazdığım `askforNumber` metodunu kullanarak Manticore'un mesafesini `1-100` arasında güvenli şekilde aldım ve `Console.Clear()` ile ekranı temizledim.
- `for (int round = 15; round >= 0; round--)` döngüsüyle hem şehrin kalan canını (`round`) hem de mevcut tur sayısını (`15 - round`) aynı değişken üzerinden yönettim.
- Tur hasarını (`damage`) ve atış durumunu (`statusRange`: `0` tam isabet, `1` uzun, `-1` kısa) ternary operatörlerle tek satırda hesapladım.
- Tam isabette Manticore'un canını düşürdüm ve `manticoreHealth <= 0` olduğunda zafer mesajını, `round == 0` olduğunda ise yenilgi mesajını yazdırıp oyunu bitirdim.
