using BossBattlePuzzle15.Objects;
namespace BossBattlePuzzle15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gridSize = (int)numericUpDown1.Value;
            GameFORM gameForm = new GameFORM(gridSize);
            this.Hide();
            gameForm.ShowDialog();
            this.Show();

        }

    }
}
