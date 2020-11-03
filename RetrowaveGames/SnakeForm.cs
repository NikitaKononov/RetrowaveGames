using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetrowaveGames {
    public partial class SnakeForm : Form
    {

        private bool GameStarted;

        public SnakeForm()
        {
            GameStarted = false;
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            SnakeGameLogics.ResetGame();
            GameStarted = true;
        }

        private void SnakeForm_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    SnakeGameLogics.ChangeDirection("UP");
                    break;
                case Keys.Right:
                    SnakeGameLogics.ChangeDirection("RIGHT");
                    break;
                case Keys.Down:
                    SnakeGameLogics.ChangeDirection("DOWN");
                    break;
                case Keys.Left:
                    SnakeGameLogics.ChangeDirection("LEFT");
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            paintGameField();
            if (GameStarted)
            {
                SnakeGameLogics.MoveSnake();
                if (SnakeGameLogics.CheckEndGame())
                {
                    GameStarted = false;
                    MessageBox.Show("GAME OVER BRUH");
                    return;
                }
                paintGameField();
                scoreLabel.Text = SnakeGameLogics.GetScore().ToString();
            }
        }

        private void paintGameField()
        {
            Graphics g = gameField.CreateGraphics();
            g.Clear(Color.Black);

            SolidBrush snakeBrush = new SolidBrush(Color.DeepPink);
            SolidBrush fruitBrush = new SolidBrush(Color.Brown);

            for (int i = 0; i < SnakeGameLogics.getFieldWidth(); i++)
            {
                for (int j = 0; j < SnakeGameLogics.getFieldHeight(); j++)
                {
                    if (SnakeGameLogics.CheckPointBelongsToSnake(i, j))
                    {
                        g.FillRectangle(snakeBrush, 20*i, 20*j, 20, 20);
                    }
                }
            }

            int[] mas = SnakeGameLogics.GetFruit();
            g.FillRectangle(fruitBrush, 20 * mas[0], 20 * mas[1], 20, 20);

        }
    }
}
