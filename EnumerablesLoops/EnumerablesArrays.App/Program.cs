using EnumerablesArrays.Common;
using System;

namespace EnumerablesArrays.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Start();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Oyunu başlatmak için bir tuşa basınız");
            Console.ReadKey();
            Console.Clear();
            var canPlay = true;
            while(canPlay)
            {
                var number = GetInput();
                if (number == 0)
                {
                    game.Finish();
                    break;
                }
                var answer = game.Predict(number);
                canPlay = PrintResult(answer);
            }

            if (game.IsGameReady())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\nOyunu tamamladınız.....");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\nOyunda çıktınız.....");
            }
            

            Console.ReadLine();
        }

        static bool PrintResult(PredictionResult result)
        {
            var canPlay = true;
            switch(result)
            {
                case PredictionResult.Up:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Yukarı");
                    break;
                case PredictionResult.Down:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aşağı");
                    break;
                case PredictionResult.Correct:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tebrikler, Doğru!");
                    canPlay = false;
                    break;
                case PredictionResult.Error:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Oyun başlamadı...");
                    canPlay = false;
                    break;
            }
            return canPlay;
        }

        static byte GetInput()
        {
            byte number = 0;
            Console.ForegroundColor = ConsoleColor.White;
            bool hasError;
            do
            {
                try
                {
                    Console.Write("Bir Sayı Giriniz.......: ");
                    var input = Console.ReadLine();
                    if (input == "exit")
                    {
                        return number;
                    }
                    number = Convert.ToByte(input);
                    hasError = false;
                }
                catch
                {
                    hasError = true;
                }
            } while (hasError);
            //TODO: yukarıdaki döngüyü while ile yapmaya çalışın
            return number;
        }
    }
}
