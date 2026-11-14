# 05 - The Defense of Consolas

## Kitaptaki Görev (Challenge)
**Level 8 - Console 2.0:** Consolas şehrini savunmak için hedef alınan satır (`Target Row`) ve sütun (`Target Column`) bilgisini kullanıcıdan alıp, hedefin etrafındaki 4 komşu koordinata (yukarı, aşağı, sağ, sol) savunma ekibini konuşlandırmak. Konsol başlığını değiştirmek, farklı renklerle göstermek ve işlem sonunda sesli uyarı (`Console.Beep`) vermek.

## Nasıl Yaptım?
- `Console.BackgroundColor = ConsoleColor.DarkMagenta` ve `Console.ForegroundColor = ConsoleColor.White` ile konsol renklerini özelleştirdim.
- `Console.Title = "The Defense of Consolas"` ile pencere başlığını ayarladım.
- Kullanıcıdan hedef satır ve sütun koordinatlarını alıp `Console.Beep(440, 1000)` ile sesli uyarı verdim.
- Tek bir string interpolation ifadesinde `
` kaçış karakterlerini kullanarak `(row+1, column)`, `(row-1, column)`, `(row, column+1)` ve `(row, column-1)` koordinatlarını ekrana yazdırdım.
