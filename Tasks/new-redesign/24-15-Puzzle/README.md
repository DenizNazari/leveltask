# 24 - Boss Battle: The 15-Puzzle

## Kitaptaki Görev (Challenge)
**Level 24 - Catacombs of the Class (Boss Battle):** Klasik kaydırmalı **15-Puzzle** oyununu nesne yönelimli olarak tasarlamak:
- Taşları rastgele ve çözülebilir (solvable) bir başlangıç düzeninde oluşturmak.
- Kullanıcının boş hücreye komşu olan taşları kaydırabilmesini (`Move`) sağlamak.
- Tüm taşlar doğru sıraya (`1` .. `N² - 1` ve sonda boşluk) geldiğinde oyunun kazanıldığını (`IsSolved`) algılamak.

## Nasıl Yaptım?
- Bu görevi ayrı bir **Windows Forms** projesi (`BossBattlePuzzle15`) olarak geliştirdim ve `LevelTask.Task24` üzerinden doğrudan başlatılabilir şekilde ana menüye bağladım.
- **Başlangıç Ekranı (`Form1`):** Kullanıcının `NumericUpDown` ile dinamik olarak ızgara boyutunu (`gridSize`) seçip oyunu başlatabilmesini sağladım.
- **Oyun Mantığı (`Objects/GameObject.cs`):**
  - `GenerateGame()` ile sayıları karıştırıp **inversiyon sayısı (`IsSolvable`)** kontrolü yaparak her zaman çözülebilir bir tahta ürettim.
  - `Move()` metoduyla yalnızca boş hücreye (`emptyCell`) komşu olan taşların yer değiştirmesine izin verdim ve hem buton metinlerini hem de arka plandaki `grid` matrisini güncelledim.
  - `IsSolved()` ile taşların sırasını ve son hücrenin boş olup olmadığını kontrol ederek kazanma durumunu belirledim.
- **Duyarlı Arayüz (`GameFORM.cs`):** `FlowLayoutPanel` içinde butonları dinamik oluşturdum; pencere yeniden boyutlandırıldığında `ScaleAndCenterUI()` metoduyla butonları, yazı boyutlarını ve tabloyu otomatik ölçekleyip ortaladım.
