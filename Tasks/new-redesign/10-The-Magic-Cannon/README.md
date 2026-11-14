# 10 - The Magic Cannon

## Kitaptaki Görev (Challenge)
**Level 11 - Looping:** Consolas'taki büyülü top her turda atış yapar: tur sayısı `3`'ün katıysa **Fire** (Ateş), `5`'in katıysa **Electric** (Elektrik), hem `3` hem `5`'in (`15`'in) katıysa **Combined Blast** (Birleşik Patlama), diğer turlarda ise **Normal** atış yapar.

## Nasıl Yaptım?
- Önce `do-while` döngüsü kullanarak kullanıcıdan `0` ile `100` arasında geçerli bir atış sayısı (`blast`) aldım.
- Ardından `for` döngüsü içinde uzun `if-else` blokları yazmak yerine **iç içe ternary operator** (`i % 15 == 0 ? "combined blast" : i % 3 == 0 ? "Fire" : i % 5 == 0 ? "Electric" : "Normal"`) kullanarak tek satırda hem `15`, hem `3`, hem `5` bölünebilirliğini kontrol edip ekrana yazdırdım.
