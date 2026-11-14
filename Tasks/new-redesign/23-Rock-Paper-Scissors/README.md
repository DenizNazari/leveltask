# 23 - Rock-Paper-Scissors (Taş-Kağıt-Makas)

## Kitaptaki Görev (Challenge)
**Level 24 - Object-Oriented Design:** İki insan oyuncunun oynayabildiği nesne yönelimli bir **Taş-Kağıt-Makas (Rock-Paper-Scissors)** oyunu tasarlamak, her turun kazananını belirlemek ve oyuncuların toplam skorlarını takip etmek.

## Nasıl Yaptım?
- Oyunu `RockPaperScissors` ve `Player` sınıflarıyla nesne yönelimli olarak modelledim; hamleleri `rockpercentageEnum` (`Rock`, `Paper`, `Scissors`) ile temsil ettim.
- **Gizli Tuş Okuma (`Console.ReadKey(true)`):** İki oyuncu aynı bilgisayarda oynarken birbirlerinin seçimini görmemesi için `Console.ReadKey(true)` ve `switch expression` kullanarak `R`, `P`, `S` tuşlarını ekrana yazdırmadan okudum.
- **Dosyaya Kayıt (`StreamWriter`):** Oyuncular `F` tuşuna basıp oyunu bitirdiğinde `SaveScoresToFile()` metoduyla toplam tur sayısını, skorları, kazananı (`Winner`) ve kaybedeni (`Loser`) `RockPaperScissorsScores.txt` dosyasına kaydettim.
