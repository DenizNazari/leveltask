# 09 - The Prototype

## Kitaptaki Görev (Challenge)
**Level 11 - Looping:** İki oyunculu bir sayı tahmin oyunu yapmak. 1. kullanıcı (Pilot) `0` ile `100` arasında bir sayı girer (geçerli girene kadar tekrar sorulur). Ardından ekran temizlenir (`Console.Clear()`) ve 2. kullanıcı (Avcı) doğru sayıyı bulana kadar tahmin yapar; her tahminde `"too low"` veya `"too high"` ipucu verilir.

## Nasıl Yaptım?
- İlk `while (true)` döngüsünde 1. kullanıcının girdiği sayının `0` ile `100` arasında olup olmadığını (`NumberlOfLocation < 0 || NumberlOfLocation > 100`) kontrol ettim; geçerliyse `break` ile döngüden çıktım.
- `Console.Clear()` ile 1. kullanıcının girdiği sayıyı ekrandan gizledim.
- İkinci `while (true)` döngüsünde 2. kullanıcının tahminini (`GUessOfLocation`) hedef sayıyla karşılaştırıp düşükse `"too low"`, yüksekse `"too high"` mesajı verdim ve doğru bilindiğinde `"You guessed it!"` yazdırarak oyunu sonlandırdım.
