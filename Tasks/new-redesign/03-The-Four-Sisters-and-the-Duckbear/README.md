# 03 - The Four Sisters and the Duckbear

## Kitaptaki Görev (Challenge)
**Level 7 - Math:** Toplanan çikolata yumurtalarını 4 kız kardeş arasında eşit olarak paylaştırmak ve kalan yumurtaları evcil hayvanları **Duckbear**'a vermek. Ayrıca hangi yumurta sayılarında Duckbear'ın kız kardeşlerin her birinden daha fazla yumurta aldığını bulmak.

## Nasıl Yaptım?
- Kullanıcıdan yumurta sayısını alıp tam sayı bölmesi (`/ 4`) ile her bir kız kardeşin alacağı yumurta sayısını (`eggsneeded`), mod alma operatörü (`% 4`) ile de Duckbear'a kalan yumurta sayısını (`eggremainder`) hesapladım.
- Kitaptaki *"Hangi durumlarda Duckbear kardeşlerden daha fazla alır?"* sorusunu tek tek elle denemek yerine `1`'den `20`'ye kadar dönen bir `for` döngüsü kurdum ve `if (i / 4 < i % 4)` koşuluyla Duckbear'ın daha karlı çıktığı yumurta sayılarını (`1`, `2`, `3`, `6`, `7`, `11`) otomatik olarak bulup ekrana yazdırdım.
