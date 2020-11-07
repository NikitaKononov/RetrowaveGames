using System;


namespace RetrowaveGames {
    struct SnakeBlock
    {
        private int x, y;

        SnakeBlock(int xx, int yy)
        {
            x = xx;
            y = yy;
        }

        public int getY()
        {
            return y;
        }

        public int getX()
        {
            return x;
        }

        public void setX(int xx)
        {
            x = xx;
        }

        public void setY(int yy)
        {
            y = yy;
        }
    }
    public static class SnakeGameLogics
    {
        private static int MaxLength = 600, FieldWidth = 30, FieldHeight = 20;

        private static SnakeBlock[] Snake = new SnakeBlock[MaxLength];
        private static SnakeBlock Fruit = new SnakeBlock();
        private static int SnakeLength, Score;
        private static string Direction;

        public static void MoveSnake()
        {
            for (int i = SnakeLength; i > 0; i--) { 
                Snake[i].setX(Snake[i - 1].getX());
                Snake[i].setY(Snake[i - 1].getY());
            }

            switch (Direction) 
            {
                case "UP":
                    Snake[0].setY(Snake[0].getY() - 1);
                    break;
                case "RIGHT":
                    Snake[0].setX(Snake[0].getX() + 1);
                    break;
                case "DOWN":
                    Snake[0].setY(Snake[0].getY() + 1);
                    break;
                case "LEFT":
                    Snake[0].setX(Snake[0].getX() - 1);
                    break;
            }

            if (CheckFruit())
            {
                Score++;
                SnakeLength++;
                GenerateFruit();
            }
        }

        private static void GenerateFruit()
        {
            Random rnd = new Random();
            Fruit.setX(rnd.Next(0, FieldWidth));
            Fruit.setY(rnd.Next(0, FieldHeight));
        }

        private static bool CheckFruit()
        {
            return Snake[0].getX() == Fruit.getX() && Snake[0].getY() == Fruit.getY();
        }

        public static void ChangeDirection(string newDir)
        {
            switch (newDir)
            {
                case "LEFT":
                    if (Direction != "RIGHT")
                        Direction = newDir;
                    break;
                case "RIGHT":
                    if (Direction != "LEFT")
                        Direction = newDir;
                    break;
                case "UP":
                    if (Direction != "DOWN")
                        Direction = newDir;
                    break;
                case "DOWN":
                    if (Direction != "UP")
                        Direction = newDir;
                    break;
            }

            return;
        }

        public static bool CheckEndGame()
        {
            return CheckBorders() || CheckSelfCross();
        }

        private static bool CheckBorders()
        {
            return Snake[0].getX() >= FieldWidth || Snake[0].getX() < 0 || Snake[0].getY() >= FieldHeight || Snake[0].getY() < 0;
        }

        private static bool CheckSelfCross()
        {
            for (int i = 1; i < SnakeLength; i++) 
            {
                if (Snake[0].getX() == Snake[i].getX() && Snake[0].getY() == Snake[i].getY())
                {
                    return true;
                }
            }
            return false;
        }

        public static void ResetGame()
        {
            SnakeLength = 4;
            Score = 0;
            Direction = "RIGHT";

            for (int i = 0; i < MaxLength; i++)
            {
                Snake[i].setX(0);
                Snake[i].setY(0);
            }

            GenerateFruit();
        }

        public static int GetScore()
        {
            return Score;
        }

        public static int getFieldWidth()
        {
            return FieldWidth;
        }

        public static int getFieldHeight()
        {
            return FieldHeight;
        }

        public static bool CheckPointBelongsToSnake(int xx, int yy)
        {
            for (int i = 0; i < SnakeLength; i++)
            {
                if (Snake[i].getX() == xx && Snake[i].getY() == yy)
                {
                    return true;
                }
            }
            return false;
        }

        public static int[] GetFruit()
        {
            int[] coords = new int[2];
            coords[0] = Fruit.getX();
            coords[1] = Fruit.getY();
            return coords;
        }
    }
}
