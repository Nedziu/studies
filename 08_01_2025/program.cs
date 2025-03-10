using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01_2025
{
    internal class program
    {

        static void singHappyBirthday(String name3, int age)
        {
            Console.WriteLine("lorem ipsum");
            Console.WriteLine("lorem ipsum");
            Console.WriteLine("l2orem ipsum" + name3);
            Console.WriteLine("wiek: " + age);

        }
        static void Main(string[] args)
        {
            // PETLE WEWNETRZNE

            /*
            Console.WriteLine("Ile wierszy? ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ile kolumn?");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jaki symbol?: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            */

            // GRA W ZGADYWANIE LICZBY 

            /*
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses; // próby
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max+1);

                while (guess != number)
                {
                    Console.WriteLine($"Odgadnij liczbę pomiedzy {min} - {max}");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Twoja liczba: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine($"Liczba {guess} jest za wysoka!");
                    } else if (guess < number)
                    {
                        Console.WriteLine($"Liczba {guess} jest za niska!");
                    }
                    guesses++;
                }
                Console.WriteLine($"Liczba: {number}");
                Console.WriteLine("Wygrałeś!");
                Console.WriteLine("Liczba prób: " + guesses);

                Console.WriteLine("Czy chcesz grać ponownie? (T/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "T")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Dzieki za gre.");
            */
            // PAPIER KAMIEN NOZYCE 

            /*
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String response;

            while (playAgain) {
                player = "";
                computer = "";
                while (player != "KAMIEN" && player != "PAPIER" && player != "NOZYCE") 
                {
                    Console.WriteLine("Wpisz KAMIEN, PAPIER, NOZYCE:");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                int randomNum = random.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "KAMIEN";
                        break;
                    case 2:
                        computer = "PAPIER";
                        break;
                    case 3:
                        computer = "NOZYCE";
                        break;
                }

                Console.WriteLine("GRACZ: " + player);
                Console.WriteLine("KOMPUTER: " + computer);

                switch (player) 
                {
                    case "KAMIEN":
                        if (computer == "KAMIEN")
                        {
                            Console.WriteLine("REMIS");
                        } else if (computer == "PAPIER")
                        {
                            Console.WriteLine("PRZEGRALES");
                        } else
                        {
                            Console.WriteLine("WYGRALES");
                        }
                        break;
                    case "PAPIER":
                        if (computer == "KAMIEN")
                        {
                            Console.WriteLine("WYGRALES");
                        }
                        else if (computer == "PAPIER")
                        {
                            Console.WriteLine("REMIS");
                        }
                        else
                        {
                            Console.WriteLine("PRZEGRALES");
                        }
                        break;
                    case "NOZYCE":
                        if (computer == "KAMIEN")
                        {
                            Console.WriteLine("PRZEGRALES");
                        }
                        else if (computer == "PAPIER")
                        {
                            Console.WriteLine("WYGRALES");
                        }
                        else
                        {
                            Console.WriteLine("REMIS");
                        }
                        break;

                }
                Console.WriteLine("Czy chcesz zagrać ponownie (T/N");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "T")
                {
                    playAgain = true;
                } 
                else
                {
                    playAgain = false;
                }

            }
            Console.WriteLine("Dzieki za gre");

            */
            // METODY 
            /*
            String name = "bazyli";
            int age = 21;

            //singHappyBirthday();
            //singHappyBirthday();
            singHappyBirthday(name,age);
            Console.ReadKey();
            */
        } 

    }
}
