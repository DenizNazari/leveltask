<img src="../../../assets/puzzle15.gif" align="right" width="96" alt="15-Puzzle Grid" />

<div align="center">

# 🧩 24 - Boss Battle: The 15-Puzzle

### Object-oriented 15-Puzzle desktop game featuring dynamic $N \times N$ board sizing, an inversion-parity solvability algorithm, and a responsive Windows Forms UI.

![Level](https://img.shields.io/badge/Level-24%3A%20The%20Catacombs%20of%20the%20Class-512BD4?style=for-the-badge)
![XP](https://img.shields.io/badge/XP-150%20XP-success?style=for-the-badge)
![Type](https://img.shields.io/badge/Type-Boss%20Battle-red?style=for-the-badge)
![UI](https://img.shields.io/badge/UI-Windows%20Forms%20%26%20OOP-0078D6?style=for-the-badge)

🇬🇧 English · [🇹🇷 Türkçe](README-tr.md)

</div>

---

## 🎯 The Challenge (Boss Battle: 15-Puzzle — 150 XP)

**Level 24 — The Catacombs of the Class (Second Pedestal):**
The second pedestal requires an object-oriented design for the classic **15-Puzzle** game. The board consists of numbered tiles and a single open slot, and the goal is to slide the tiles into sequential order with the empty space positioned in the bottom-right corner:

<table>
<tr>
<th>Scrambled Starting Board (Example)</th>
<th></th>
<th>Solved Target Board</th>
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

### Game Requirements:
- Allow the player to manipulate the board and rearrange tiles.
- Display the current board state to the user.
- Detect when the puzzle has been solved and notify the player that they won.
- Generate random puzzles for the player to solve.
- Track and display the number of moves made by the player.

### Objectives:
- Outline the objects and classes required to build the game of 15-Puzzle using CRC cards (or a suitable alternative).
- **Answer this question:** *Would your design need to change if we also wanted 3×3 or 5×5 boards?*

---

## 🛠️ How I Built It (Architecture & Implementation Details)

While the book only required a conceptual class design on paper, I implemented the architecture as a **fully playable, object-oriented Windows Forms desktop application (`BossBattlePuzzle15`)** and integrated it directly into the main console launcher (`LevelTask.Task24`).

### 1. Layered OOP Architecture (Separating UI from the Game Engine)
To keep the core puzzle rules decoupled from UI rendering, I structured the project into three components:
- **`GameObject` (`BossBattlePuzzle15/Objects/GameObject.cs`):** The core game engine encapsulating the 2D board matrix (`int[,] grid`), the empty slot coordinates (`(int row, int col) emptyCell`), the solvability algorithm, adjacency/movement rules, and win-state verification.
- **`Form1` (`BossBattlePuzzle15/Form1.cs`):** The setup screen where the player selects the board dimension (`gridSize`) dynamically via a `NumericUpDown` control before launching the match.
- **`GameFORM` (`BossBattlePuzzle15/GameFORM.cs`):** The interactive game window that generates tile buttons inside a `FlowLayoutPanel`, handles click events (`TileButton_Click`), and dynamically scales the UI on window resize.

### 2. Answering the Book's Question in Code: Dynamic $N \times N$ Board Support
> *"Would your design need to change if we also wanted 3×3 or 5×5 boards?"*

Instead of hardcoding a `4×4` grid, I designed `GameObject(int gridSize)` to be **completely parametric ($N \times N$)**:
- Using `grid = new int[gridSize, gridSize]` and `Enumerable.Range(1, gridSize * gridSize - 1)`, the exact same class supports **3×3 (8-Puzzle)**, **4×4 (15-Puzzle)**, **5×5 (24-Puzzle)**, or any larger $N \times N$ dimension without modifying a single line of code.

### 3. Mathematical Solvability Guarantee (`IsSolvable` & Inversion Parity)
Shuffling tiles purely at random (`OrderBy(x => random.Next())`) produces an **unsolvable board 50% of the time** (where the final two tiles remain swapped, such as `8-7` or `15-14`). To prevent impossible boards, I implemented the **Inversion Parity** algorithm inside `GameObject.cs`:
- `GenerateGame()` shuffles the tile list inside a `do-while` loop and validates each permutation with `IsSolvable(numbers)`.
- For every pair of indices $(i < j)$, it counts an inversion whenever $\text{list}[i] > \text{list}[j]$.
- Because the empty cell (`0`) starts in the bottom-right corner, a permutation is solvable if and only if the total inversion count is even (`inversions % 2 == 0`). Every generated board is **100% solvable**.

### 4. Coordinate-Based Movement (`Move`) & Win Detection (`IsSolved`)
- **Storing Coordinates in `Tag`:** Each `Button` stores its own row and column position in `button.Tag = new Point(row, col)`.
- **Manhattan Distance Adjacency Check:** When a tile is clicked, `Move()` checks whether the clicked tile is orthogonally adjacent (distance of `1`) to `emptyCell`:
  ```csharp
  if ((row == emptyCell.row && Math.Abs(col - emptyCell.col) == 1) ||
      (col == emptyCell.col && Math.Abs(row - emptyCell.row) == 1))
  ```
- On a valid move, both the UI button labels and the underlying `grid[row, col]` matrix / `emptyCell` tuple are updated in sync.
- **`IsSolved()` Verification:** After each valid move, the matrix is scanned to verify that tiles `1` through `gridSize² - 1` are in strictly ascending order and the bottom-right cell (`[gridSize - 1, gridSize - 1]`) is `0`.

### 5. Responsive UI Scaling (`ScaleAndCenterUI`) & STA Thread Bridge
- **`ScaleAndCenterUI()`:** Whenever the window is resized (`OnResize`), the form calculates the available client area, dynamically resizes every tile (`tileSize`) and its font (`fontSize = tileSize * 0.3f`), and centers the `FlowLayoutPanel`.
- **Console-to-WinForms STA Thread Bridge:** To launch the Windows Forms UI cleanly from the console menu (`LevelTask`), `Tasks/new-redesign/24-15-Puzzle/Program.cs` spawns a dedicated UI thread configured with `ApartmentState.STA` and runs `BossBattlePuzzle15.Form1`.

---

## 📁 Files

- [`Program.cs`](Program.cs) — STA Thread bridge launching the WinForms app from the console menu (`LevelTask.Task24.Program.Main`)
- [`../../BossBattlePuzzle15/Objects/GameObject.cs`](../../BossBattlePuzzle15/Objects/GameObject.cs) — Core 15-Puzzle engine (`GenerateGame`, `IsSolvable`, `Move`, `IsSolved`)
- [`../../BossBattlePuzzle15/GameFORM.cs`](../../BossBattlePuzzle15/GameFORM.cs) — Dynamic grid UI and `ScaleAndCenterUI` responsive layout logic
- [`../../BossBattlePuzzle15/Form1.cs`](../../BossBattlePuzzle15/Form1.cs) — Dynamic board size (`gridSize`) configuration form

<!-- RPG-NAV -->
---

<div align="center">

[⬅️ 23 - Rock-Paper-Scissors](../23-Rock-Paper-Scissors/README.md) &nbsp;·&nbsp; [🏠 Quest Log Hub](../../../README.md) &nbsp;·&nbsp; [25 - Hangman ➡️](../25-Hangman/README.md)

</div>
