using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "number_game";
            string appAuthor = "Asia";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} by {1} ", appName, appAuthor);

            Console.ResetColor(); //resetuje nam kolor 

            Console.WriteLine("Jak masz na imie?"); //pytamy jak ma na imie użytkownik gry 

            string input = Console.ReadLine();
            Console.WriteLine(input+" zagrajmy w grę");

            while (true)
            {
                //ustwiamy poprawną liczbe
                //int number = 7;
                Random random = new Random();
                int number = random.Next(1, 10);

                //zgadnij wartosc
                int guess = 0;

                Console.WriteLine("zgadnij liczbę pomiedzy 1 i 10 ");
                while (guess != number)
                {
                    string input_n = Console.ReadLine();

                    if (!int.TryParse(input_n, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("to nie jest liczba, wprowadz poprawna liczbe");
                        Console.ResetColor();
                        continue;

                    }
                    guess = Int32.Parse(input_n);

                    if (guess != number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("zła liczba, spróbuj jeszcze raz");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("zgadłes!!!");
                Console.ResetColor();

                Console.WriteLine("chcesz zagrac jeszcze raz [Y or N]?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;

                }
                else
                {
                    return ;
                }


            }
        }
    }
}
