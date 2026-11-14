# 15 - Simula's Test

## Kitaptaki Görev (Challenge)
**Level 16 - Enumerations:** Bir sandığın durumlarını (`Locked`, `Unlocked`, `Opened`) temsil eden bir `enum` tanımlamak ve sonsuz döngü içerisinde kullanıcının girdiği duruma göre sandığın durumunu kontrol etmek.

## Nasıl Yaptım?
- `ChestStatusEnum` adında `Locked`, `Unlocked` ve `Opened` değerlerini içeren bir `enum` tanımladım.
- Kullanıcının metin girdisini büyük/küçük harf duyarsız (`ignoreCase: true`) olarak `Enum.TryParse<ChestStatusEnum>(input, true, out ChestStatusEnum chestStatus)` ile güvenli bir şekilde parse ettim.
- Geçerli bir durum girildiğinde `switch (chestStatus)` ile ilgili bilgilendirme mesajını ekrana yazdırdım, geçersiz girdilerde ise hata mesajı gösterdim.
