<img src="../../../assets/puzzle15.gif" align="right" width="96" alt="15-Puzzle Grid" />

<div align="center">

# 🧩 24 - Boss Battle: The 15-Puzzle

### Dinamik $N \times N$ tahta boyutuna, çözülebilirlik (Inversion Parity) algoritmasına ve duyarlı (responsive) Windows Forms arayüzüne sahip 15-Puzzle oyunu.

![Level](https://img.shields.io/badge/Seviye-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Tür-Boss%20Battle-red?style=for-the-badge)
![UI](https://img.shields.io/badge/Arayüz-Windows%20Forms%20%26%20OOP-0078D6?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## 🎯 Kitaptaki Görev (Boss Battle: 15-Puzzle — 150 XP)

**Level 24 — The Catacombs of the Class (İkinci Kaide):**
İkinci kaide, klasik **15-Puzzle** oyunu için nesne yönelimli bir tasarım oluşturmanı ister. 15-Puzzle oyunu, üzerinde numaralı taşların ve tek bir boş yuvanın bulunduğu bir tahtadan oluşur. Amaç, taşları kaydırarak sayıları sıraya dizmek ve boş alanı sağ alt köşeye getirmektir:

<table>
<tr>
<th>Karışık Başlangıç Tahtası (Örnek)</th>
<th></th>
<th>Çözülmüş Hedef Tahtası</th>
</tr>
<tr>
<td>

| | | | |
|:---:|:---:|:---:|:---:|
| **1** | **3** | **10** | **13** |
| **4** | **2** | ` ` | **6** |
| **11** | **8** | **7** | **12** |
| **9** | **14** | **5** | **15** |

</td>
<td align="center"><h1>➡️</h1></td>
<td>

| | | | |
|:---:|:---:|:---:|:---:|
| **1** | **2** | **3** | **4** |
| **5** | **6** | **7** | **8** |
| **9** | **10** | **11** | **12** |
| **13** | **14** | **15** | ` ` |

</td>
</tr>
</table>

### Oyun Gereksinimleri:
- Oyuncu tahtadaki taşları yeniden düzenlemek için hamle yapabilmelidir.
- Oyunun güncel durumu kullanıcıya gösterilmelidir.
- Oyun çözüldüğünde algılanmalı ve oyuncuya kazandığı bildirilmelidir.
- Oyun, çözülmek üzere rastgele bulmacalar üretebilmelidir.
- Oyun, oyuncunun kaç hamle yaptığını takip etmeli ve göstermelidir.

### Hedefler (Objectives):
- 15-Puzzle oyununu oluşturmak için gerekebilecek nesneleri ve sınıfları CRC kartları (veya uygun bir alternatif) ile ana hatlarıyla belirlemek.
- **Soruyu Yanıtla:** *Eğer 3×3 veya 5×5 tahtalar da istenseydi tasarımının değişmesi gerekir miydi?*

---

## 🛠️ Nasıl Yaptım? (Mimari ve Uygulama Detayları)

Kitaptaki görev yalnızca kağıt üzerinde kavramsal bir sınıf tasarımı istese de, bu mimariyi doğrudan test edilebilir, etkileşimli ve görsel bir deneyime dönüştürmek için projeyi **nesne yönelimli bir Windows Forms masaüstü uygulaması (`BossBattlePuzzle15`)** olarak geliştirdim ve konsol başlatıcısına (`LevelTask.Task24`) entegre ettim.

### 1. Katmanlı OOP Mimarisi (UI ve Oyun Motorunun Ayrıştırılması)
Oyun mantığını arayüz kodundan izole etmek için projeyi üç ana bileşene ayırdım:
- **`GameObject` (`BossBattlePuzzle15/Objects/GameObject.cs`):** Tahta matrisini (`int[,] grid`), boş hücre koordinatını (`(int row, int col) emptyCell`), çözülebilirlik algoritmasını, komşuluk/hareket kurallarını ve kazanma kontrolünü barındıran çekirdek oyun sınıfı.
- **`Form1` (`BossBattlePuzzle15/Form1.cs`):** Kullanıcının oyun başlamadan önce `NumericUpDown` kontrolü ile ızgara boyutunu (`gridSize`) belirlediği yapılandırma ve başlatma ekranı.
- **`GameFORM` (`BossBattlePuzzle15/GameFORM.cs`):** `FlowLayoutPanel` üzerinde dinamik taş butonlarını oluşturan, tıklama olaylarını (`TileButton_Click`) yöneten ve pencere boyutuna göre arayüzü gerçek zamanlı ölçekleyen oyun ekranı.

### 2. Kitaptaki Sorunun Kodla Yanıtı: Dinamik $N \times N$ Tahta Desteği
> *"3×3 veya 5×5 tahtalar da istenseydi tasarımının değişmesi gerekir miydi?"*

Tasarımı sabit `4×4` boyutuna bağımlı kurmak yerine, `GameObject(int gridSize)` kurucu metodu üzerinden **tamamen parametrik ($N \times N$)** olarak inşa ettim:
- `grid = new int[gridSize, gridSize]` ve `Enumerable.Range(1, gridSize * gridSize - 1)` yapısı sayesinde sınıf; **3×3 (8-Puzzle)**, **4×4 (15-Puzzle)**, **5×5 (24-Puzzle)** veya daha büyük boyutlarda hiçbir kod değişikliğine gerek kalmadan çalışır.

### 3. Matematiksel Çözülebilirlik Garantisi (`IsSolvable` & Inversion Parity)
Kaydırmalı bulmacalarda taşları tamamen rastgele dizmek (`OrderBy(x => random.Next())`), matematiksel olarak **%50 olasılıkla çözülmesi imkânsız** (son iki taşın `8-7` veya `15-14` şeklinde ters kaldığı) bir tahta üretir. Bunu önlemek için `GameObject.cs` içinde **Inversion (Terslik) Sayısı** algoritmasını uyguladım:
- `GenerateGame()` metodu sayıları karıştırdıktan sonra `IsSolvable(numbers)` metodunu çağırır.
- Dizideki her sayı çifti $(i < j)$ için $\text{list}[i] > \text{list}[j]$ durumu sayılarak toplam inversiyon (`inversions`) hesaplanır.
- Boş hücre (`0`) son konumda yer aldığından, yalnızca `inversions % 2 == 0` (çift sayıda terslik) koşulunu sağlayan permütasyonlar kabul edilir; aksi halde `do-while` döngüsü yeni bir dizilim üretir. Böylece üretilen her oyun **%100 çözülebilirdir**.

### 4. Koordinat Tabanlı Hareket (`Move`) ve Kazanma Kontrolü (`IsSolved`)
- **`Tag` Üzerinde Koordinat Tutma:** Her `Button` oluşturulurken `button.Tag = new Point(row, col)` ile kendi satır ve sütun koordinatını taşır.
- **Manhattan Mesafesi ile Komşuluk Kontrolü:** Bir taşa tıklandığında `Move()` metodu, tıklanan hücrenin boş hücreye (`emptyCell`) yatay veya dikey olarak tam 1 birim uzaklıkta olup olmadığını kontrol eder:
  ```csharp
  if ((row == emptyCell.row && Math.Abs(col - emptyCell.col) == 1) ||
      (col == emptyCell.col && Math.Abs(row - emptyCell.row) == 1))
  ```
- Geçerli hamlede hem arayüzdeki buton metinleri hem de arka plandaki `grid[row, col]` matrisi ve `emptyCell` tuple değeri güncellenir.
- **`IsSolved()` Doğrulaması:** Her geçerli hamleden sonra matris taranarak hücrelerin `1`'den `gridSize² - 1`'e kadar sıralı olup olmadığı ve sağ alt köşenin (`[gridSize - 1, gridSize - 1]`) `0` (boş) olup olmadığı denetlenir.

### 5. Duyarlı (Responsive) Ölçekleme (`ScaleAndCenterUI`) ve STA Thread Köprüsü
- **`ScaleAndCenterUI()`:** Pencere yeniden boyutlandırıldığında (`OnResize`), kullanılabilir alan hesaplanarak her bir taşın piksel boyutu (`tileSize`) ve yazı tipi boyutu (`fontSize = tileSize * 0.3f`) dinamik olarak güncellenir; `FlowLayoutPanel` formun tam ortasına hizalanır.
- **Konsoldan WinForms'a STA Thread Köprüsü:** Ana konsol menüsünden (`LevelTask`) seçildiğinde WinForms bileşenlerinin sorunsuz çalışması için `Tasks/new-redesign/24-15-Puzzle/Program.cs` içinde `ApartmentState.STA` olarak yapılandırılmış özel bir UI iş parçacığı (`Thread`) üzerinden `BossBattlePuzzle15.Form1` başlatılır.

---

## 📁 Dosyalar

- [`Program.cs`](Program.cs) — Konsol menüsünden WinForms uygulamasını STA Thread ile başlatan köprü (`LevelTask.Task24.Program.Main`)
- [`../../BossBattlePuzzle15/Objects/GameObject.cs`](../../BossBattlePuzzle15/Objects/GameObject.cs) — Çekirdek 15-Puzzle motoru (`GenerateGame`, `IsSolvable`, `Move`, `IsSolved`)
- [`../../BossBattlePuzzle15/GameFORM.cs`](../../BossBattlePuzzle15/GameFORM.cs) — Dinamik ızgara arayüzü ve `ScaleAndCenterUI` ölçekleme mantığı
- [`../../BossBattlePuzzle15/Form1.cs`](../../BossBattlePuzzle15/Form1.cs) — Dinamik tahta boyutu (`gridSize`) seçim formu

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 23 - Rock-Paper-Scissors](../23-Rock-Paper-Scissors/README-tr.md) &nbsp;·&nbsp; [🏠 Ana Görev Günlüğü](../../../README-tr.md) &nbsp;·&nbsp; [25 - Hangman ➡️](../25-Hangman/README-tr.md)

</div>
