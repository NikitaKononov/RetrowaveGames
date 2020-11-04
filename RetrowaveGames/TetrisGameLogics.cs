using System;
using System.Drawing;

namespace RetrowaveGames {
    public struct tetrisBlock
    {
        private int x, y;
        private Color figColor;
        private int type;

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public Color getColor()
        {
            return figColor;
        }

        public int getType()
        {
            return type;
        }
        public void setX(int xx)
        {
            x = xx;
        }
        public void setY(int yy)
        {
            y = yy;
        }

        public void setColor(Color c)
        {
            figColor = c;
        }

        public void setType(int t)
        {
            type = t;
        }
    }
    public static class TetrisGameLogics
    {
        public static int FieldHeight = 20, FieldWidth = 10;
        public static Color[] FigureColors = new Color[] {Color.DeepPink, Color.Yellow, Color.DarkOrange};

        public static tetrisBlock[,] GameField = new tetrisBlock[FieldHeight,FieldWidth], DisplayNextFigure = new tetrisBlock[2,4] ;
        public static tetrisBlock[] CurrentFigure = new tetrisBlock[4], NextFigure = new tetrisBlock[4];

        public static int Score, Lines, Level;

        public static int[,] Figures = new int[,]
        {
            {1,3,5,7}, // I
            {2,4,5,7}, // Z
            {3,5,4,6}, // S
            {3,5,4,7}, // T
            {2,3,5,7}, // L
            {3,5,7,6}, // J
            {2,3,4,5}, // cube
        };

        public static void ResetGame()
        {
            Score = 0;
            Lines = 0;
            Level = 0;

            for (int i = 0; i < FieldHeight; i++)
            {
                for (int j = 0; j < FieldWidth; j++)
                {
                    GameField[i,j].setColor(Color.Black);
                }
            }

            GenerateFig();
            GenerateFig();
        }
        private static void GenerateFig()
        {
            for (int i = 0; i < 4; i++) {
                CurrentFigure[i] = NextFigure[i];
            }

            Random rnd = new Random();
            int n = rnd.Next(0, 7);
            Color c = FigureColors[rnd.Next(0, 3)];
            for (int i = 0; i < 4; i++) {
                NextFigure[i].setX(Figures[n, i] % 2);
                NextFigure[i].setY(Figures[n, i] / 2);
                NextFigure[i].setColor(c);
                NextFigure[i].setType(n);
                if (n == 0 || n == 6)
                    NextFigure[i].setY(NextFigure[i].getY() + 3);
                else
                    NextFigure[i].setY(NextFigure[i].getY() + 2);
                if (n == 0)
                    NextFigure[i].setX(NextFigure[i].getX() - 1);
            }
        }
        private static void PutFigureToField()
        {
            for (int k = 0; k < 4; k++) {
                GameField[CurrentFigure[k].getX(), CurrentFigure[k].getY()].setColor(CurrentFigure[k].getColor());
            }
        }
        public static void FigureActions(string KeyDirection)
        {

        }
        private static void MoveFigureLeft()
        {

        }
        private static void MoveFigureRight() {

        }
        private static void RotateFigureLeft() {

        }
        private static void RotateFigureRight() {

        }
        public static void TickActions()
        {

        }
        public static bool CheckEndGame()
        {
            return false;
        }
        private static bool CheckFigureCanFall()
        {
            return false;
        }
    }
}
