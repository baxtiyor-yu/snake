
namespace AppSnake
{
    internal class Game
    {
        public void StartGame()
        {
            bool again = true;
            bool finished = false;
            while (again)
            {
                Console.Clear();                
                Canvas canvas = new Canvas();
                Snake snake = new Snake();
                Food food = new Food();
                canvas.DrawCanvas();

                while (!finished)
                {
                    try
                    {
                        Console.SetCursorPosition(20, 1);
                        Console.WriteLine("Score: {0}", snake.Score);
                        snake.Input();
                        food.DrawFood();
                        snake.DrawSnake();
                        snake.MoveSnake();
                        snake.Eat(food.FoodLocation(), food);
                        snake.IsDead();
                        snake.HitWall(canvas);
                    }
                    catch (SnakeException e)
                    {
                        Console.Clear();
                        Helper.DisplayMessage(e.Message);
                        Thread.Sleep(1000);
                        finished = true;
                    }
                }

                Helper.DisplayMessage("Try again? (y/n)");

                if (Console.ReadKey(true).Key.Equals(ConsoleKey.Y))
                {
                    finished = false;
                }
                else
                {
                    again = false;
                }
            }
            Console.Clear();
        }
    }
}
