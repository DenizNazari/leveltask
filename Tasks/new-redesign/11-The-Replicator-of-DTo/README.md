# 11 - The Replicator of D'To

## Kitaptaki Görev (Challenge)
**Level 12 - Arrays:** `5` elemanlı bir tam sayı dizisi oluşturup kullanıcıdan aldığı 5 sayıyı bu diziye kaydetmek, ardından bu dizinin elemanlarını yeni bir `5` elemanlı diziye kopyalamak.

## Nasıl Yaptım?
- `int[] strings = new int[5];` ile 5 elemanlı ilk diziyi tanımladım ve `for` döngüsüyle kullanıcıdan aldığım 5 değeri diziye atadım.
- Ek olarak dizideki sayıların toplamını (`strings.Sum()`) ve ortalamasını (`strings.Average()`) ekrana yazdırdım.
- İkinci diziyi (`strings2`) oluşturup `strings.CopyTo(strings2, 0)` metoduyla ilk diziyi ikinci diziye kopyaladım.
