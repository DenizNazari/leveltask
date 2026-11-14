# 22 - The Password Validator

## Kitaptaki Görev (Challenge)
**Level 24 - Catacombs of the Class:** Girilen bir şifrenin kurallara uygun olup olmadığını kontrol eden bir `PasswordValidator` sınıfı yazmak:
- En az 1 büyük harf (`char.IsUpper`), 1 küçük harf (`char.IsLower`), 1 rakam (`char.IsDigit`) ve özel karakter içermeli.
- Büyük `'T'` harfi ve `'&'` (ampersand) karakterini **içermemeli**.

## Nasıl Yaptım?
- `PasswordValidator.ValidatePassword(string password)` metodunu `static` olarak tanımladım ve kullanıcı geçerli bir şifre girene kadar `do-while` döngüsü içinde çağırdım.
- `foreach (char c in password)` döngüsüyle şifredeki her karakteri tek tek inceleyerek büyük harf, küçük harf, rakam ve özel karakter bayraklarını (`bool`) güncelledim.
- Eksik olan tüm kuralları ternary operatörlerle tek bir `warningMsj` metninde birleştirerek kullanıcıya hangi kuralların eksik olduğunu detaylıca gösterdim.
