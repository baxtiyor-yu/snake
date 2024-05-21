namespace AppSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.DisplayMessage("snake");
            Thread.Sleep(2000);
            new Game().StartGame();
        }
    }
}
