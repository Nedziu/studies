using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string x = "T";

            //// 3x3
            //Console.WriteLine(x + " | " + "x" + " | " + "x");
            //Console.WriteLine("---" + "+" + "---" + "+" + "---");
            //Console.WriteLine(" x " + " | " + " x " + " | " + " x");
            //Console.WriteLine(" x " + " | " + " x " + " | " + " x");


            //Console.ReadLine();


            //Console.WriteLine("Napisz program sprawdzający czy dana liczba jest parzysta\n");

            //int x = 0;
            //Console.WriteLine("Podaj liczbę: ");


            //while (!int.TryParse(Console.ReadLine(), out x))
            //{
            //    Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
            //}

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Liczba jest parzysta");
            //}
            //else
            //{
            //    Console.WriteLine("Liczba nie jest parzysta");
            //}
            //Console.ReadLine();

            //Console.WriteLine("Napisz program sprawdzający czy podana liczba jest podzielna przez inną liczbę\n");
            //Console.WriteLine("Podaj liczbę do podzielenia: ");

            //int liczbaDzielona = 0;
            //int dzielnik = 0;   

            //while (!int.TryParse(Console.ReadLine(), out liczbaDzielona))
            //{
            //    Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
            //}

            //Console.WriteLine("Podaj dzielnik: ");

            //while (!int.TryParse(Console.ReadLine(), out dzielnik))
            //{
            //    Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
            //}

            //if (liczbaDzielona % dzielnik == 0)
            //{
            //    Console.WriteLine("Liczba jest podzielna");
            //}
            //else
            //{
            //    Console.WriteLine("Liczba nie jest podzielna");
            //}
            //Console.ReadLine();


            Console.WriteLine("Program, który pobierze od uzytkownika 3 liczby i wypisze je w porzadku niemalejącym.\n");
            Console.WriteLine("Podaj pierwszą liczbę: ");

            double x = 0;
            double y = 0;
            double z = 0;

            double sortX = 0;
            double sortY = 0;
            double sortZ = 0;

            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
            }

            Console.WriteLine("Podaj drugą liczbę: ");

            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
            }

            Console.WriteLine("Podaj trzecią liczbę: ");

            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
            }


            Console.WriteLine("Wyjscie: ");
            Console.WriteLine("{0}, {1}, {2}",x,y,z);


            if (x > y && x > z) // 5,2,1
            {
                if (y > z) // 1,2,5
                {
                    Console.WriteLine("{0}, {1}, {2}", z, y, x);
                }
                else // 2,1,5
                {
                    Console.WriteLine("{0}, {1}, {2}", y, z, x);
                }
            }
            else if (y > x && y > z)
            {
                if (x > z)
                {
                    Console.WriteLine("{0}, {1}, {2}", z, x, y);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", x, z, y);
                }
            }
            else if (z > x && z > y)
            {
                if (x > y)
                {
                    Console.WriteLine("{0}, {1}, {2}", y, x, z);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", x, y, z);
                }
            }


            Console.WriteLine("{0}, {1}, {2}",x,y,z);
            Console.ReadLine();
        }
    }
}
