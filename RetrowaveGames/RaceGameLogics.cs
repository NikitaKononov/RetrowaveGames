using System.Xml.Serialization;

namespace RetrowaveGames
{
    public static class RaceGameLogics
    {
        private static int[,] PlayerCar =
        {
            {0, 1, 0},
            {1, 1, 1},
            {0, 1, 0},
            {1, 0, 1}
        };

        private static int[,] EnemyCar =
        {
            {1, 0, 1},
            {0, 1, 0},
            {1, 1, 1},
            {0, 1, 0}
        };

        private static int FieldWidth = 10, FieldHeight = 20;
        private static int CurrentPlayerLine = 0;
        private static int[,] GameField = new int[FieldWidth, FieldHeight];

        private static void ResetGame()
        {
            for (int i = 0; i < FieldWidth; i++)
            {
                for (int j = 0; j < FieldHeight; j++)
                {
                    GameField[i, j] = 0;
                }
            }

            CurrentPlayerLine = 0;
        }

        public static void MoveLeft()
        {
            if (CurrentPlayerLine == 0)
                return;
            CurrentPlayerLine = 0;
        }

        public static void MoveRight()
        {
            if (CurrentPlayerLine == 1)
                return;
            CurrentPlayerLine = 1;
        }
    }
}
