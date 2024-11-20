using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            int n = 0;
            int liczbaDoTablicy = 0;

            Console.WriteLine("Napisz program, który wczyta n liczb podanych przez uzytkownika i wypisze je \na) w wierszu \nb) w kolumnie \nc) w odwrotnej kolejności\n");
            
            Console.WriteLine("Podaj 'n' liczb");
            
            while (!int.TryParse(Console.ReadLine(), out n)) 
            {
                Console.WriteLine("Nie podałeś poprawnej liczby, podaj ją ponownie: ");
            }
            int[] tablica = new int[n]; //definicja tablicy

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("\nPodaj {0} z {1} liczb",i+1,n);
                while (!int.TryParse(Console.ReadLine(), out liczbaDoTablicy))
                {
                    Console.WriteLine("Nie podałeś poprawnej liczby, podaj ją ponownie: ");
                }
                tablica[i] = liczbaDoTablicy; // zapis do tablicy do indeksu i 
            }

            // a) w wierszu

            Console.WriteLine("\nZapis w wierszu:");
            foreach (int i in tablica)
            {
                Console.Write(i + " ");
            }

            // b) w kolumnie

            Console.WriteLine("\nZapis w kolumnie");
            foreach (int i in tablica)
            {
                Console.WriteLine(i);
            }

            // c) w odwrotnej kolejności 

            Console.WriteLine("\nZapis w odwrotnej kolejności");
            for (int i = tablica.Length-1; i>=0; i--)
            {
                Console.Write(tablica[i]);
            }

            Console.ReadLine();    
            */

            int n = 0;
            int m = 0;
            double sumaSzescianow = 0;
            double suma = 0;

            Console.WriteLine("Program oblicza sumę sześcianów liczb naturalnych zawartych między n, a m: (n^3 + (n+1)^3 + ... + m^3");

            Console.WriteLine("Podaj n (od): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Podano nie prawidłową liczbę, spróbuj ponownie");
            }

            Console.WriteLine("Podaj m (do): ");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0 || m < n)
            {
                Console.WriteLine("Podano nie prawidłową liczbę, spróbuj ponownie");
            }

            for (int i = n; i <= m; i++)
            {
                Console.WriteLine("iteracja: {0}",i);
                Console.WriteLine("Potega: {0}\n",Math.Pow(i,3));
                sumaSzescianow = Math.Pow(i,3);
                suma += sumaSzescianow;
            }

            Console.WriteLine("Suma szescianów: {0}",suma);
            Console.ReadLine();

        }
    }
}
