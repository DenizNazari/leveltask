<img src="../../../assets/door-key.gif" align="right" width="96" alt="Password Validator" />

<div align="center">

# 🔐 22 - Boss Battle: The Password Validator

### Karakter analizi yapan ve ihlal edilen tüm güvenlik kurallarını tek seferde raporlayan `PasswordValidator` sınıfı.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-String%20Validation%20%26%20OOP-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: The Password Validator — 100 XP)

**Level 24 — The Catacombs of the Class (Beşinci Kaide):**
Beşinci ve son kaide, bir şifrenin geçerli olup olmadığını aşağıdaki kurallara göre belirleyebilen bir sınıf oluşturmanı ister:

- Şifreler en az **6 harf/karakter** ve en fazla **13 harf/karakter** uzunluğunda olmalıdır.
- Şifreler en az bir **büyük harf (`Uppercase`)**, bir **küçük harf (`Lowercase`)** ve bir **rakam (`Number`)** içermelidir.
- Şifreler büyük **`T`** harfini veya **`&`** (ampersand) karakterini **içeremez** (BT'den Ingelmar bu karakterleri yasaklamıştır).

### Hedefler (Objectives):
- Bir şifrenin yukarıdaki kurallara göre geçerli olup olmadığını belirleyebilen yeni bir `PasswordValidator` sınıfı tanımlamak.
- `Main` metodunda sonsuz bir döngü kurarak kullanıcıdan bir şifre girmesini istemek ve `PasswordValidator` sınıfını kullanarak şifrenin geçerli olup olmadığını bildirmek.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

### 1. Tek Geçişli Karakter Analizi (`foreach` & `System.Char` Metotları)
Şifreyi birden fazla kez taramak yerine `foreach (char c in password)` döngüsüyle tek geçişte (`O(N)`) tüm karakter bayraklarını (`bool`) güncelledim:
- `char.IsUpper(c)` ile büyük harf kontrolü (`hasUpper`),
- `char.IsLower(c)` ile küçük harf kontrolü (`hasLower`),
- `char.IsDigit(c)` ile rakam kontrolü (`hasDigit`),
- `c == 'T' || c == '&'` ile yasaklı karakter kontrolü (`hasSpecial`).

### 2. Çoklu Kural İhlali Raporlama Sistemi (`warningMsj`)
Kitaptaki görev yalnızca şifrenin geçerli veya geçersiz olduğunu söylemeyi istese de, kullanıcı deneyimini güçlendirmek için şifre reddedildiğinde **hangi kuralların ihlal edildiğini tek tek listeleyen** dinamik bir uyarı mesajı sistemi kurdum:
- Uzunluk, büyük harf, küçük harf, rakam ve yasaklı karakter (`T` veya `&`) ihlallerinin tamamı birleştirilerek kullanıcıya aynı anda gösterilir ve `do-while` döngüsü geçerli bir şifre girilene kadar devam eder.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `PasswordValidator` sınıfı ve doğrulama döngüsü (`LevelTask.Task22.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 21 - The Locked Door](../21-The-Locked-Door/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [23 - Rock-Paper-Scissors ➡️](../23-Rock-Paper-Scissors/README-tr.md)

</div>
