<img src="../../../assets/door-key.gif" align="right" width="96" alt="The Locked Door" />

<div align="center">

# 🚪 21 - Boss Battle: The Locked Door

### Durum makinesi (State Machine) geçiş kurallarına ve şifre doğrulama mekanizmasına sahip güvenli `Door` sınıfı.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-100%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-State%20Machine%20%26%20Encapsulation-239120?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: The Locked Door — 100 XP)

**Level 24 — The Catacombs of the Class (Dördüncü Kaide):**
Dördüncü kaide, kilidini açmak için benzersiz bir şifre gerektiren kilit mekanizmasına sahip bir kapı (`Door`) sınıfı inşa etmeni ister. Kapının çalışma kuralları şunlardır:

- Açık bir kapı her zaman kapatılabilir (`Open ➔ Closed`).
- Kapalı (ancak kilitli olmayan) bir kapı her zaman açılabilir (`Closed ➔ Open`).
- Kapalı bir kapı her zaman kilitlenebilir (`Closed ➔ Locked`).
- Kilitli bir kapının kilidi açılabilir (`Locked ➔ Closed`), ancak bunun için şifre gerekir ve kapı yalnızca verilen kod kapının mevcut şifresiyle eşleşirse açılır.
- Bir kapı oluşturulduğunda ona bir başlangıç şifresi verilmelidir.
- Ek olarak, mevcut şifreyi ve yeni bir şifreyi vererek şifreyi değiştirebilmelisin. Şifre yalnızca doğru mevcut kod verildiğinde değişmelidir.

### Hedefler (Objectives):
- Kilitli (`Locked`), açık (`Open`) veya kapalı (`Closed`) olduğunu takip edebilen bir `Door` sınıfı tanımlamak.
- Yukarıda tanımlanan dört durum geçişini metotlarla gerçekleştirebilmek.
- Başlangıç şifresini zorunlu kılan bir kurucu metot (`constructor`) oluşturmak.
- Mevcut şifreyi ve yeni şifreyi vererek mevcut bir kapının şifresini değiştirmeye izin veren bir metot oluşturmak.
- `Main` metodunda kullanıcıdan bir başlangıç şifresi isteyerek yeni bir `Door` nesnesi oluşturmak, ardından kullanıcının metin komutlarıyla dört geçişi ve şifre değiştirmeyi denemesine olanak tanıyan bir döngü kurmak.

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

### 1. Gizli Şifre Kapsüllemesi (`private string Password`) ve Durum Modellemesi
- Kapının durumlarını `DoorStateEnum` (`Open`, `Closed`, `Locked`) ile tanımladım ve `DoorState` özelliğini dışarıdan yalnızca okunabilir (`public DoorStateEnum DoorState { get; private set; }`) yaptım.
- Güvenlik gereği kapının şifresini dış sınıfların okuyamayacağı şekilde `private string Password { get; set; }` olarak tamamen gizledim.

### 2. Kontrollü Durum Geçiş Metotları ve Şifre Değiştirme
Geçersiz durum geçişlerini (örneğin kilitli bir kapıyı doğrudan açmaya çalışmak veya açık bir kapıyı kapatmadan kilitlemeye çalışmak) engellemek için her eylemi ayrı metotlarda doğruladım:
- **`openDoor()`:** Yalnızca `DoorState == DoorStateEnum.Closed` ise kapıyı `Open` durumuna geçirir; kapı kilitliyse önce kilidin açılması gerektiğini bildirir.
- **`closeDooor()`:** Yalnızca `DoorState == DoorStateEnum.Open` ise kapıyı `Closed` yapar.
- **`lockDoor(string password)` & `unlockDoor(string password)`:** Kapının durumunu ve girilen `password == Password` eşleşmesini kontrol ederek kilitleme/kilit açma işlemini gerçekleştirir.
- **`changePassword(string oldPassword, string newPassword)`:** Yalnızca `oldPassword == Password` koşulu sağlandığında şifreyi günceller; aksi halde yetkisiz şifre değişimini reddeder.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — `Door` sınıfı, `DoorStateEnum` ve etkileşimli komut döngüsü (`LevelTask.Task21.Program.Main`)

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 20 - The Card](../20-The-Card/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [22 - The Password Validator ➡️](../22-The-Password-Validator/README-tr.md)

</div>
