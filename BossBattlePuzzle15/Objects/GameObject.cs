using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBattlePuzzle15.Objects
{
    public class GameObject
    {
        public int gridSize { get; private set; } = 4;
        private int[,] grid;
        private (int row, int col) emptyCell;
        private List<int> numberlist { get; set; }

        public GameObject(int gridSize)
        {
            this.gridSize = gridSize;
            grid = new int[gridSize, gridSize];
            numberlist = new List<int>(gridSize * gridSize - 1);

        }

        public void GenerateGame()
        {
            Random random = new Random();
            List<int> numbers = Enumerable.Range(1, gridSize * gridSize - 1).ToList();
            do
            {
                numbers = numbers.OrderBy(x => random.Next()).ToList(); // Shuffle the numbers

            } while (!IsSolvable(numbers));


            int index = 0;
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (index < numbers.Count)
                    {
                        grid[row, col] = numbers[index];
                        index++;
                    }
                    else
                    {
                        grid[row, col] = 0; // Empty space
                        emptyCell = (row, col);
                    }
                }
            }
        }


        private bool IsSolvable(List<int> list)
        {
            int inversions = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0) continue; // Boşluğu atla
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] == 0) continue;
                    if (list[i] > list[j])
                        inversions++;
                }
            }
            return inversions % 2 == 0;
        }

        public Button[] GetButtons()
        {
            Button[] buttons = new Button[gridSize * gridSize];
            int index = 0;
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    buttons[index] = GetButton(row, col);
                    index++;
                }
            }
            return buttons;
        }

        public int[,] GetGrid()
        {
            return grid;
        }

        private Button GetButton(int row, int col)
        {
            Button button = new Button();
            button.Text = grid[row, col] == 0 ? "" : grid[row, col].ToString();
            button.Size = new Size(60, 60);
            button.Font = new Font("Arial", 10, FontStyle.Bold);
            button.BackColor = Color.LightGray;
            button.Tag = new Point(row, col); // Store the position in the Tag property
            return button;
        }
        public bool Move(Button clickedButton, Control.ControlCollection allButtons)
        {
            Point position = (Point)clickedButton.Tag;
            int row = position.X;
            int col = position.Y;

            // Tıklanan buton boş hücreye komşu mu?
            if ((row == emptyCell.row && Math.Abs(col - emptyCell.col) == 1) ||
                (col == emptyCell.col && Math.Abs(row - emptyCell.row) == 1))
            {
                // 1. Önceki boş hücrenin butonunu bul ve yazısını güncelle
                foreach (Button btn in allButtons)
                {
                    Point btnPos = (Point)btn.Tag;
                    if (btnPos.X == emptyCell.row && btnPos.Y == emptyCell.col)
                    {
                        btn.Text = clickedButton.Text;
                        break;
                    }
                }

                // 2. Tıklanan butonu boş yap
                clickedButton.Text = "";

                // 3. Arka plandaki grid matrisini ve emptyCell konumunu güncelle
                grid[emptyCell.row, emptyCell.col] = grid[row, col];
                grid[row, col] = 0;
                emptyCell = (row, col);

                return true; // Geçerli hamle yapıldı
            }

            return false; // Komşu değil, hamle yapılmadı
        }
    
        public bool IsSolved()
        {
            int expectedValue = 1;
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (row == gridSize - 1 && col == gridSize - 1)
                    {
                        // Son hücre boş olmalı
                        if (grid[row, col] != 0)
                            return false;
                    }
                    else
                    {
                        if (grid[row, col] != expectedValue)
                            return false;
                        expectedValue++;
                    }
                }
            }
            return true;
        }

    }


}
