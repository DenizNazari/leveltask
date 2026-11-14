# 21 - The Locked Door

## Kitaptaki Görev (Challenge)
**Level 24 - Catacombs of the Class:** Şifreli bir kapı (`Door`) sınıfı tasarlamak. Kapı üç durumda olabilir: `Open` (Açık), `Closed` (Kapalı) ve `Locked` (Kilitli). Kapı yalnızca kurallara uygun geçiş yapabilir (örneğin açık kapı doğrudan kilitlenemez, kilitli kapı şifre girilmeden açılamaz) ve eski şifre doğrulanarak yeni şifre belirlenebilir.

## Nasıl Yaptım?
- Kapının durumlarını `DoorStateEnum` (`Open`, `Closed`, `Locked`) ile modelledim ve şifreyi dışarıdan erişilemeyecek şekilde `private string Password { get; set; }` olarak sakladım.
- `openDoor()`, `closeDooor()`, `lockDoor(string password)` ve `unlockDoor(string password)` metotlarıyla durum geçiş kurallarını ve şifre doğrulamasını kontrol ettim.
- `changePassword(string oldPassword, string newPassword)` metoduyla mevcut şifre doğruysa şifrenin güncellenmesini sağladım.
