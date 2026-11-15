<img src="assets/chibi-dragon.gif" align="right" width="130" alt="Chibi Ejderha Maskotu" />

<div align="center">

# 🐉 The C# Player's Guide — Görev Günlüğü & XP Takipçisi

### Çıraklıktan Gerçek Programcılığa, her görevle bir seviye daha atla.

***The C# Player's Guide (5th Edition)* kitabındaki görevler ve Boss Savaşları için yazdığım çözümleri barındıran interaktif C# konsol & WinForms görev merkezi; [xp-tracker.sor.nz](https://xp-tracker.sor.nz/) ile senkronize RPG ilerleme günlüğü.**

![Level](https://img.shields.io/badge/Karakter%20Seviyesi-6-blueviolet?style=for-the-badge)
![XP](https://img.shields.io/badge/Toplam%20XP-3%2C650%20%2F%2012%2C125-gold?style=for-the-badge)
![Quests](https://img.shields.io/badge/Tamamlanan-41%20%2F%20114%20Görev-success?style=for-the-badge)
![DotNet](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge)

[🇬🇧 English](README.md) · 🇹🇷 Türkçe

</div>

---

## ⚔️ Karakter Kartı ve XP İlerlemesi

> [**C# Player's Guide XP Tracker**](https://xp-tracker.sor.nz/) baz alınmıştır · Formül: `XP Eşiği = (Seviye² × 100) - (100 × Seviye)` (+25 Başlangıç XP Bonusu)

| Özellik | Değer |
|---|---|
| **Mevcut Seviye** | **Seviye 6** *(Seviye 7 için 550 XP kaldı!)* |
| **Toplam XP** | **3.650 XP** *(3.625 Görev XP + 25 Başlangıç XP)* / 12.125 XP |
| **Tamamlanan Görev** | **41 / 114** *(24 proje görevi + Bölüm 1–2 temel görevler & bilgi kontrolleri)* |
| **Bölüm 1: The Basics** | `2.275 / 2.275 XP` (27 / 27) 🏆 |
| **Bölüm 2: Object-Oriented Programming** | `1.350 / 3.800 XP` (14 / 33) |
| **Bölüm 3: Advanced Features** | `0 / 2.350 XP` (0 / 33) |
| **Bölüm 4: The Endgame** | `0 / 3.600 XP` (0 / 18) |
| **Bölüm 5: Bonus Levels** | `0 / 75 XP` (0 / 3) |

### 📊 Seviye Haritası (Seviye 1 – 10)

| Seviye | Gereken XP | Durum |
|---|---|---|
| **Seviye 1** | 0 XP | ✅ Açıldı |
| **Seviye 2** | 200 XP | ✅ Açıldı |
| **Seviye 3** | 600 XP | ✅ Açıldı |
| **Seviye 4** | 1.200 XP | ✅ Açıldı |
| **Seviye 5** | 2.000 XP | ✅ Açıldı |
| **Seviye 6** | 3.000 XP | ✅ **Mevcut Seviye** (`3.650 XP`) |
| **Seviye 7** | 4.200 XP | 🔒 *550 XP gerekiyor* |
| **Seviye 8** | 5.600 XP | 🔒 Kilitli |
| **Seviye 9** | 7.200 XP | 🔒 Kilitli |
| **Seviye 10** | 9.000 XP | 🔒 Maksimum Seviye |

---

## 📜 Görev Günlüğü (Tamamlanan 25 Görev)

<img src="assets/manticore.gif" align="right" width="90" alt="Manticore Boss Sprite" />

Tamamlanan görevlerin tamamı [`Program.cs`](Program.cs) içindeki interaktif menüden (WinForms **15-Puzzle Boss Battle** dahil) doğrudan çalıştırılabilir.

| Durum | # | Görev Adı | Kitap Bölümü / Konu | XP | Klasör |
|---|---|---|---|---|---|
| ✅ | 01 | [The Triangle Farmer](./Tasks/new-redesign/01-The-Triangle-Farmer/README-tr.md) | Bölüm 1 · Level 6: The C# Type System | 100 XP | `01-The-Triangle-Farmer` |
| ✅ | 02 | [The Variable Shop & Returns](./Tasks/new-redesign/02-The-Variable-Shop-And-Type-Limits/README-tr.md) | Bölüm 1 · Level 6–7: Types & Overflow | 150 XP | `02-The-Variable-Shop-And-Type-Limits` |
| ✅ | 03 | [The Four Sisters and the Duckbear](./Tasks/new-redesign/03-The-Four-Sisters-and-the-Duckbear/README-tr.md) | Bölüm 1 · Level 7: Math (`/` & `%`) | 100 XP | `03-The-Four-Sisters-and-the-Duckbear` |
| ✅ | 04 | [The Dominion of Kings](./Tasks/new-redesign/04-The-Dominion-of-Kings/README-tr.md) | Bölüm 1 · Level 7: Math | 100 XP | `04-The-Dominion-of-Kings` |
| ✅ | 05 | [The Defense of Consolas](./Tasks/new-redesign/05-The-Defense-of-Consolas/README-tr.md) | Bölüm 1 · Level 8: Console 2.0 | 200 XP | `05-The-Defense-of-Consolas` |
| ✅ | 06 | [Repairing the Clocktower](./Tasks/new-redesign/06-Repairing-the-Clocktower/README-tr.md) | Bölüm 1 · Level 9: Decision Making | 100 XP | `06-Repairing-the-Clocktower` |
| ✅ | 07 | [Watchtower](./Tasks/new-redesign/07-Watchtower/README-tr.md) | Bölüm 1 · Level 9: Koordinat & Mantık | 100 XP | `07-Watchtower` |
| ✅ | 08 | [Buying & Discounted Inventory](./Tasks/new-redesign/08-Buying-and-Discounted-Inventory/README-tr.md) | Bölüm 1 · Level 10: Switch & Ternary | 150 XP | `08-Buying-and-Discounted-Inventory` |
| ✅ | 09 | [The Prototype](./Tasks/new-redesign/09-The-Prototype/README-tr.md) | Bölüm 1 · Level 11: Döngüler (`while`) | 100 XP | `09-The-Prototype` |
| ✅ | 10 | [The Magic Cannon](./Tasks/new-redesign/10-The-Magic-Cannon/README-tr.md) | Bölüm 1 · Level 11: Döngüler (`for`, `do-while`) | 100 XP | `10-The-Magic-Cannon` |
| ✅ | 11 | [The Replicator of D'To](./Tasks/new-redesign/11-The-Replicator-of-DTo/README-tr.md) | Bölüm 1 · Level 12: Diziler (`for`) | 100 XP | `11-The-Replicator-of-DTo` |
| ✅ | 12 | [The Laws of Freach](./Tasks/new-redesign/12-The-Laws-of-Freach/README-tr.md) | Bölüm 1 · Level 12: Diziler (`foreach`) | 50 XP | `12-The-Laws-of-Freach` |
| ✅ | 13 | [Taking a Number](./Tasks/new-redesign/13-Taking-a-Number/README-tr.md) | Bölüm 1 · Level 13: Metotlar & Overloading | 100 XP | `13-Taking-a-Number` |
| ✅ | 14 | [Hunting the Manticore (Boss Battle)](./Tasks/new-redesign/14-Hunting-the-Manticore/README-tr.md) | Bölüm 1 · Level 14: Memory Management | 250 XP | `14-Hunting-the-Manticore` |
| ✅ | 15 | [Simula's Test](./Tasks/new-redesign/15-Simulas-Test/README-tr.md) | Bölüm 2 · Level 16: Enumerations | 100 XP | `15-Simulas-Test` |
| ✅ | 16 | [Simula's Soup](./Tasks/new-redesign/16-Simulas-Soup/README-tr.md) | Bölüm 2 · Level 17: Tuples | 100 XP | `16-Simulas-Soup` |
| ✅ | 17 | [Vin Fletcher's Arrows](./Tasks/new-redesign/17-Vin-Fletchers-Arrows/README-tr.md) | Bölüm 2 · Level 18–21: Sınıflar & Static | 350 XP | `17-Vin-Fletchers-Arrows` |
| ✅ | 18 | [The Point](./Tasks/new-redesign/18-The-Point/README-tr.md) | Bölüm 2 · Level 24: Catacombs of the Class | 75 XP | `18-The-Point` |
| ✅ | 19 | [The Color](./Tasks/new-redesign/19-The-Color/README-tr.md) | Bölüm 2 · Level 24: Catacombs of the Class | 100 XP | `19-The-Color` |
| ✅ | 20 | [The Card](./Tasks/new-redesign/20-The-Card/README-tr.md) | Bölüm 2 · Level 24: Catacombs of the Class | 100 XP | `20-The-Card` |
| ✅ | 21 | [The Locked Door](./Tasks/new-redesign/21-The-Locked-Door/README-tr.md) | Bölüm 2 · Level 24: Durum Yönetimi | 100 XP | `21-The-Locked-Door` |
| ✅ | 22 | [The Password Validator](./Tasks/new-redesign/22-The-Password-Validator/README-tr.md) | Bölüm 2 · Level 24: Doğrulama | 100 XP | `22-The-Password-Validator` |
| ✅ | 23 | [Rock-Paper-Scissors](./Tasks/new-redesign/23-Rock-Paper-Scissors/README-tr.md) | Bölüm 2 · Level 24: OOP Tasarım & Dosya Kaydı | 150 XP | `23-Rock-Paper-Scissors` |
| ✅ | 24 | [The 15-Puzzle (Boss Battle)](./Tasks/new-redesign/24-15-Puzzle/README-tr.md) | Bölüm 2 · Level 24: OOP & WinForms Arayüz | 150 XP | `24-15-Puzzle` |
| ✅ | 25 | [Hangman (Boss Battle)](./Tasks/new-redesign/25-Hangman/README-tr.md) | Bölüm 2 · Level 24: OOP & Kelime Maskeleme | 150 XP | `25-Hangman` |

---

## 🗺️ Tüm XP Takip Listesi (114 Görev)

<details>
<summary><b>Bölüm 1: The Basics (27 / 27 Tamamlandı · 2.275 / 2.275 XP) 🏆</b></summary>

- [x] Knowledge Check - C# (25 XP)
- [x] Install Visual Studio (75 XP)
- [x] Hello, World! (50 XP)
- [x] What Comes Next (50 XP)
- [x] The Makings of a Programmer (50 XP)
- [x] Consolas and Telim (50 XP)
- [x] The Thing Namer 3000 (100 XP)
- [x] Knowledge Check - Variables (25 XP)
- [x] **The Variable Shop** (100 XP) — [Görev 02](./Tasks/new-redesign/02-The-Variable-Shop-And-Type-Limits)
- [x] **The Variable Shop Returns** (50 XP) — [Görev 02](./Tasks/new-redesign/02-The-Variable-Shop-And-Type-Limits)
- [x] Knowledge Check - Type System (25 XP)
- [x] **The Triangle Farmer** (100 XP) — [Görev 01](./Tasks/new-redesign/01-The-Triangle-Farmer)
- [x] **The Four Sisters and the Duckbear** (100 XP) — [Görev 03](./Tasks/new-redesign/03-The-Four-Sisters-and-the-Duckbear)
- [x] **The Dominion of Kings** (100 XP) — [Görev 04](./Tasks/new-redesign/04-The-Dominion-of-Kings)
- [x] **The Defense of Consolas** (200 XP) — [Görev 05](./Tasks/new-redesign/05-The-Defense-of-Consolas)
- [x] **Repairing the Clocktower** (100 XP) — [Görev 06](./Tasks/new-redesign/06-Repairing-the-Clocktower)
- [x] **Watchtower** (100 XP) — [Görev 07](./Tasks/new-redesign/07-Watchtower)
- [x] **Buying Inventory** (100 XP) — [Görev 08](./Tasks/new-redesign/08-Buying-and-Discounted-Inventory)
- [x] **Discounted Inventory** (50 XP) — [Görev 08](./Tasks/new-redesign/08-Buying-and-Discounted-Inventory)
- [x] **The Prototype** (100 XP) — [Görev 09](./Tasks/new-redesign/09-The-Prototype)
- [x] **The Magic Cannon** (100 XP) — [Görev 10](./Tasks/new-redesign/10-The-Magic-Cannon)
- [x] **The Replicator of D’To** (100 XP) — [Görev 11](./Tasks/new-redesign/11-The-Replicator-of-DTo)
- [x] **The Laws of Freach** (50 XP) — [Görev 12](./Tasks/new-redesign/12-The-Laws-of-Freach)
- [x] **Taking a Number** (100 XP) — [Görev 13](./Tasks/new-redesign/13-Taking-a-Number)
- [x] Countdown (100 XP)
- [x] Knowledge Check - Memory (25 XP)
- [x] **Hunting the Manticore** (250 XP) — [Görev 14](./Tasks/new-redesign/14-Hunting-the-Manticore)

</details>

<details>
<summary><b>Bölüm 2: Object-Oriented Programming (14 / 33 Tamamlandı · 1.350 / 3.800 XP)</b></summary>

- [x] Knowledge Check - Objects (25 XP)
- [x] **Simula’s Test** (100 XP) — [Görev 15](./Tasks/new-redesign/15-Simulas-Test)
- [x] **Simula’s Soups** (100 XP) — [Görev 16](./Tasks/new-redesign/16-Simulas-Soup)
- [x] **Vin Fletcher’s Arrows** (100 XP) — [Görev 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] Vin’s Trouble (50 XP) — [Görev 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] The Properties of Arrows (100 XP) — [Görev 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] Arrow Factories (100 XP) — [Görev 17](./Tasks/new-redesign/17-Vin-Fletchers-Arrows)
- [x] **The Point** (75 XP) — [Görev 18](./Tasks/new-redesign/18-The-Point)
- [x] **The Color** (100 XP) — [Görev 19](./Tasks/new-redesign/19-The-Color)
- [x] **The Card** (100 XP) — [Görev 20](./Tasks/new-redesign/20-The-Card)
- [x] **The Locked Door** (100 XP) — [Görev 21](./Tasks/new-redesign/21-The-Locked-Door)
- [x] **The Password Validator** (100 XP) — [Görev 22](./Tasks/new-redesign/22-The-Password-Validator)
- [x] **Rock-Paper-Scissors** (150 XP) — [Görev 23](./Tasks/new-redesign/23-Rock-Paper-Scissors)
- [x] **15-Puzzle** (150 XP) — [Görev 24](./Tasks/new-redesign/24-15-Puzzle)
- [ ] Hangman (150 XP) *(Sıradaki Görev!)*
- [ ] Tic-Tac-Toe (300 XP)
- [ ] Packing Inventory (150 XP)
- [ ] Labeling Inventory (50 XP)
- [ ] The Old Robot (200 XP)
- [ ] Robotic Interface (75 XP)
- [ ] Room Coordinates (50 XP)
- [ ] War Preparations (100 XP)
- [ ] Colored Items (100 XP)
- [ ] The Fountain of Objects (500 XP)
- [ ] Small, Medium, or Large (100 XP)
- [ ] Pits (100 XP)
- [ ] Maelstroms (100 XP)
- [ ] Amaroks (100 XP)
- [ ] Getting Armed (100 XP)
- [ ] Getting Help (100 XP)
- [ ] The Robot Pilot (50 XP)
- [ ] Time in the Cavern (50 XP)
- [ ] Lists of Commands (75 XP)

</details>

<details>
<summary><b>Bölüm 3: Advanced Features (0 / 33 Tamamlandı · 0 / 2.350 XP)</b></summary>

- [ ] Knowledge Check - Large Programs (25 XP)
- [ ] The Feud (75 XP)
- [ ] Dueling Traditions (100 XP)
- [ ] Safer Number Crunching (50 XP)
- [ ] Knowledge Check - Methods (25 XP)
- [ ] Better Random (100 XP)
- [ ] Exepti’s Game (100 XP)
- [ ] The Sieve (100 XP)
- [ ] Knowledge Check - Events (25 XP)
- [ ] Charberry Trees (100 XP)
- [ ] Knowledge Check - Lambdas (25 XP)
- [ ] The Lambda Sieve (50 XP)
- [ ] The Long Game (100 XP)
- [ ] The Potion Masters of Pattren (150 XP)
- [ ] Knowledge Check - Operators (25 XP)
- [ ] Navigating Operand City (100 XP)
- [ ] Indexing Operand City (75 XP)
- [ ] Converting Directions to Offsets (50 XP)
- [ ] Knowledge Check - Queries (25 XP)
- [ ] The Three Lenses (100 XP)
- [ ] The Repeating Stream (150 XP)
- [ ] Knowledge Check - Async (25 XP)
- [ ] Asynchronous Random Words (150 XP)
- [ ] Many Random Words (50 XP)
- [ ] Uniter of Adds (75 XP)
- [ ] The Robot Factory (100 XP)
- [ ] Knowledge Check - Unsafe Code (25 XP)
- [ ] Knowledge Check - Other Features (25 XP)
- [ ] Colored Console (100 XP)
- [ ] The Great Humanizer (100 XP)
- [ ] Knowledge Check - Compiling (25 XP)
- [ ] Knowledge Check - .NET (25 XP)
- [ ] Altar of Publication (100 XP)

</details>

<details>
<summary><b>Bölüm 4: The Endgame (0 / 18 Tamamlandı · 0 / 3.600 XP)</b></summary>

- [ ] Core Game: Building Character (300 XP)
- [ ] Core Game: The True Programmer (100 XP)
- [ ] Core Game: Actions and Players (300 XP)
- [ ] Core Game: Attacks (200 XP)
- [ ] Core Game: Damage and HP (150 XP)
- [ ] Core Game: Death (150 XP)
- [ ] Core Game: Battle Series (150 XP)
- [ ] Core Game: The Uncoded One (100 XP)
- [ ] Core Game: The Player Decides (200 XP)
- [ ] Expansion: The Game’s Status (100 XP)
- [ ] Expansion: Items (200 XP)
- [ ] Expansion: Gear (300 XP)
- [ ] Expansion: Stolen Inventory (200 XP)
- [ ] Expansion: Vin Fletcher (200 XP)
- [ ] Expansion: Attack Modifiers (200 XP)
- [ ] Expansion: Damage Types (200 XP)
- [ ] Expansion: Making it Yours (400 XP)
- [ ] Expansion: Restoring Balance (150 XP)

</details>

<details>
<summary><b>Bölüm 5: Bonus Levels (0 / 3 Tamamlandı · 0 / 75 XP)</b></summary>

- [ ] Knowledge Check - Visual Studio (25 XP)
- [ ] Knowledge Check - Compiler Errors (25 XP)
- [ ] Knowledge Check - Debugging (25 XP)

</details>

---

## 🚀 Görev Merkezini Çalıştırma (Kullanım Rehberi)

<img src="assets/quest-scroll.gif" align="right" width="90" alt="Görev Parşömeni" />

### 1. Projeyi İndirme ve Başlatma
Bilgisayarınızda [.NET 9.0 SDK](https://dotnet.microsoft.com/download) kurulu olduğundan emin olun, ardından terminalde şu komutları çalıştırın:

```bash
git clone https://github.com/DenizNazari/the-csharp-players-guide-quests.git
cd the-csharp-players-guide-quests
dotnet run --project leveltask.csproj
```

### 2. Açılan Menüden Görev Seçme ve Oynama
Uygulama çalıştığında karşınıza tüm görevlerin listelendiği **İnteraktif Görev Seçim Ekranı** (`Program.cs`) gelir:

```text
============================================================
       THE C# PLAYER'S GUIDE - GÖREV SEÇİM EKRANI           
============================================================
  [01] The Triangle Farmer               [13] Taking a Number
  [02] The Variable Shop & Type Limits   [14] Hunting the Manticore (Boss)
  [03] The Four Sisters & the Duckbear   [15] Simula's Test
  [04] The Dominion of Kings             [16] Simula's Soup
  [05] The Defense of Consolas           [17] Vin Fletcher's Arrows
  [06] Repairing the Clocktower          [18] The Point
  [07] Watchtower                        [19] The Color (ANSI RGB)
  [08] Buying & Discounted Inventory     [20] The Card (ASCII Cards)
  [09] The Prototype                     [21] The Locked Door
  [10] The Magic Cannon                  [22] The Password Validator
  [11] The Replicator of D'To            [23] Rock-Paper-Scissors
  [12] The Laws of Freach                [24] 15-Puzzle (Boss Battle)
  [00] Çıkış (Exit)                      [25] Hangman (Boss Battle)
------------------------------------------------------------
Çalıştırmak istediğiniz görevin numarasını girin (1-25, Çıkış: 0):
```

1. **Görev Başlatma:** Açılan pencerede çalıştırmak istediğiniz uygulamanın/görevin numarasını (`1` ile `25` arasında) yazıp **`Enter`** tuşuna basın.
   - **`1–23`** veya **`25`** numaralı görevlerden birini seçtiğinizde ilgili konsol uygulaması doğrudan terminal ekranında başlar.
   - **`24`** (`15-Puzzle`) numarasını yazıp **`Enter`**'a bastığınızda ise **Windows Forms masaüstü arayüzü** ayrı bir pencere olarak açılır; buradan tahta boyutunu ($N \times N$) seçip fare ile bulmacayı oynayabilirsiniz.
2. **Ana Menüye Dönüş ve Çıkış:** Çalıştırdığınız görev tamamlandığında herhangi bir tuşa basarak ana menüye geri dönebilir ve başka bir görev seçebilirsiniz. Uygulamadan tamamen çıkmak için görev sonunda **`ESC`** tuşuna basabilir veya ana menüde **`0`** yazıp **`Enter`**'a basabilirsiniz.
