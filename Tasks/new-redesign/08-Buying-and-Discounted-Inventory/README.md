# 08 - Buying Inventory & Discounted Inventory

## Kitaptaki Görev (Challenge)
**Level 10 - Switches:** Dükkandaki 7 eşyanın menüsünü ekrana yazdırıp, kullanıcının seçtiği numaraya göre eşyanın altın (`gold`) fiyatını `switch` yapısıyla göstermek (**Buying Inventory**). Ardından kullanıcının adını sorup eğer kendi adımız girilirse fiyatları yarıya (%50 indirimli) düşürmek (**Discounted Inventory**).

## Nasıl Yaptım?
- C# Raw String Literal (`""" ... """`) özelliğini kullanarak çok satırlı menüyü temiz bir şekilde ekrana bastım.
- Kullanıcıdan hem eşya numarasını (`itemNumber`) hem de adını (`playerName`) aldım.
- `switch (itemNumber)` içerisinde her `case` durumunda **ternary operator** (`playerName == "Deniz" ? 2 : 1`) kullanarak isim `"Deniz"` ise fiyatı `2`'ye bölüp %50 indirim uyguladım, değilse normal fiyatını yazdırdım.
