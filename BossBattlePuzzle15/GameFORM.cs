using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossBattlePuzzle15
{
    public partial class GameFORM : Form
    {
        private int _gridSize;
        private Objects.GameObject _gameObject;
        private Size _baseFormSize;
        public GameFORM(int gridSize)
        {

            _gridSize = gridSize;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void ScaleAndCenterUI()
        {
            if (_baseFormSize.Width == 0 || _baseFormSize.Height == 0 || flowLayoutPanel1.Controls.Count == 0)
                return;

            // 1. Mevcut pencere boyutuna göre en küçük ölçek oranını bul
            float scaleX = (float)this.ClientSize.Width / _baseFormSize.Width;
            float scaleY = (float)this.ClientSize.Height / _baseFormSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            // 2. OYUN başlığını oranla ve yatayda ortala
            label1.Font = new Font(label1.Font.FontFamily, Math.Max(8f, 24f * scale), FontStyle.Bold);
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (int)(20 * scale);

            // 3. Butonları, boşlukları ve yazı boyutunu oranla
            int btnSize = Math.Max(20, (int)(60 * scale));
            int margin = Math.Max(1, (int)(3 * scale));
            float btnFontSize = Math.Max(6f, 14f * scale);

            int totalStep = btnSize + (margin * 2);
            int panelSize = _gridSize * totalStep;
            flowLayoutPanel1.Size = new Size(panelSize, panelSize);

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                ctrl.Size = new Size(btnSize, btnSize);
                ctrl.Margin = new Padding(margin);
                ctrl.Font = new Font(ctrl.Font.FontFamily, btnFontSize, FontStyle.Bold);
            }

            // 4. Tabloyu başlığın altındaki alanda tam ortaya yerleştir
            flowLayoutPanel1.Left = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
            int availableTop = label1.Bottom + (int)(10 * scale);
            int availableHeight = this.ClientSize.Height - availableTop;
            flowLayoutPanel1.Top = availableTop + Math.Max(0, (availableHeight - flowLayoutPanel1.Height) / 2);
        }

        private void TileButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                bool moved = _gameObject.Move(clickedButton, flowLayoutPanel1.Controls);

                // Eğer hamle yapıldıysa ileride burada kazanma (IsSolved) kontrolü yapabilirsin
                if (moved)
                {
                    if (_gameObject.IsSolved())
                    {
                        MessageBox.Show("Congratulations! You solved the puzzle.");
                        this.Close(); // Oyun formunu kapat
                    }
                }
            }
        }

        private void GameFORM_Load(object sender, EventArgs e)
        {
            _gameObject = new Objects.GameObject(_gridSize);
            _gameObject.GenerateGame();

            _baseFormSize = this.ClientSize;


            Button[] buttons = _gameObject.GetButtons();
            flowLayoutPanel1.Size = new Size(_gridSize * 70 + (_gridSize - 1) * 6, _gridSize * 70 + (_gridSize - 1) * 6);
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true; // Satır dolunca alt satıra geçmesini sağlar
            flowLayoutPanel1.Padding = new Padding(0);
            foreach (Button btn in buttons)
            {
                btn.Margin = new Padding(3);
                btn.Click += TileButton_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScaleAndCentral(object sender, EventArgs e)
        {
            ScaleAndCenterUI();

        }
    }
}
