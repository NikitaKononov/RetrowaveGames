using System;
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
        private static int TicksFromPrevGeneration = 0, TicksToNextGeneration = 0, MinTicksToGenerate = 5;
        private static int[,] HiddenArea = new int[FieldWidth, 4];
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

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    HiddenArea[i, j] = 0;
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

        public static void TimerTick()
        {
            GenerateEnemy();

            for (int i = 0; i < FieldHeight; i++)
            {

            }
        }

        private static void GenerateEnemy()
        {
            if (TicksFromPrevGeneration < TicksToNextGeneration)
            {
                TicksFromPrevGeneration++;
            }
            else
            {
                TicksFromPrevGeneration = 0;
                Random rand_gen = new Random();
                TicksToNextGeneration = MinTicksToGenerate + rand_gen.Next(0, 6);
                int enemypos = rand_gen.Next(0, 2), delta = 0;
                switch (enemypos)
                {
                    case 0:
                        delta = 2;
                    break;
                    case 1:
                        delta = 5;
                    break;
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        HiddenArea[i + delta, j] = EnemyCar[i, j];
                    }
                }
            }
        }

        public static bool GetPixel(int x, int y)
        {
            int[,] LocalCopy = new int[FieldWidth, FieldHeight];
            for (int i = 0; i < FieldWidth; i++)
            {
                for (int j = 0; j < FieldHeight; j++)
                {
                    LocalCopy[i, j] = GameField[i, j];
                }
            }

            int Delta = 0;
            switch (CurrentPlayerLine)
            {
                case 0:
                    Delta = 2;
                break;
                case 1:
                    Delta = 5;
                break;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    LocalCopy[i + Delta, j + 15] = PlayerCar[i, j];
                }
            }
            return true;
        }
    }
}
