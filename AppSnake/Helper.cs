

namespace AppSnake
{
    internal class Helper
    {
        public static void DisplayMessage(string msg)
        {
            if (msg == "snake")
            {
                string str = @"
 ____  _   _    _    _  _______ 
/ ___|| \ | |  / \  | |/ / ____|
\___ \|  \| | / _ \ | ' /|  _|  
 ___) | |\  |/ ___ \| . \| |___ 
|____/|_| \_/_/   \_\_|\_\_____|
";
                ShowWithPrefix(str);
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, (Console.WindowHeight) / 2 + 2);
                Console.WriteLine(msg);
                Console.CursorVisible = false;
            }
        }

        private static void ShowWithPrefix(string inComingStr)
        {
            Console.Clear();
            Console.CursorVisible = false;
            string[] arr = inComingStr.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int strMax = arr.Max(x => x.Length);
            int horizStart = (Console.WindowWidth - strMax) / 2;
            string prefix = new(' ', horizStart);
            Console.SetCursorPosition(horizStart, Console.WindowHeight / 2 - 7);
            var FinalStr = arr.Select(el => prefix + el + "\r\n").ToArray();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Concat(FinalStr));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
