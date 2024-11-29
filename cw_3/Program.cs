using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            // ZADANIE 2

            int dlugoscCiagu = 0;
            int liczbaDoTablicy = 0;    
            
            Console.WriteLine("Napisz program, który wczyta n liczb podanyuch przez uzytkownika i wypisze je: \na) w wierszu \nb) w kolumnie \nc) w odwrotnej kolejności\n");
            Console.WriteLine("Podaj n liczb (dlugosc ciagu)");

            while (!int.TryParse(Console.ReadLine(), out dlugoscCiagu))
            {
                Console.WriteLine("Nie podałes prawidłowej liczby, spróbuj ponownie");
            }
            int[] tablica = new int[dlugoscCiagu];

            for (int i = 0; i < tablica.Length; i++) 
            {
                Console.WriteLine("Podaj {0} z {1} liczb",i+1,dlugoscCiagu);
                while (!int.TryParse(Console.ReadLine(), out liczbaDoTablicy))
                {
                    Console.WriteLine("Nie podałes prawidłowej liczby, spróbuj ponownie");
                }
                tablica[i] = liczbaDoTablicy; //wpis do tablicy
            } 

            Console.WriteLine("\na) Wypisanie w wierszu:");
            
            for (int i = 0; i < tablica.Length; i++) 
            { 
                Console.Write(tablica[i]); 
            }

            Console.WriteLine("\nb) Wypisanie w kolumnie:");

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }

            Console.WriteLine("\nc) Wypisanie w odwrotnej kolejności:");

            for (int i = tablica.Length - 1; i >= 0; i--) // i - 1 bo szukamy indeksów, i>=0 bo jak dojedziemy do zera konczymy 
            {
                Console.WriteLine(tablica[i]);
            }
            Console.ReadLine(); 

            */

            // TODO: Histogram


            /*
            Console.WriteLine("Program rysuje histogram.");

            int dlugoscCiagu = 0;
            int liczbaDoTablicy = 0;

            Console.WriteLine("Podaj długość ciągu znaków: \n");
            while (!int.TryParse(Console.ReadLine(), out dlugoscCiagu) || dlugoscCiagu < 1)
            {
                Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
            }

            int[] histogram = new int[dlugoscCiagu];

            for (int i = 0; i < dlugoscCiagu; i++)
            {
                Console.WriteLine("Podaj {0} z {1} liczb z przedziału 1-5", i + 1, dlugoscCiagu);
                while (!int.TryParse(Console.ReadLine(), out liczbaDoTablicy) || liczbaDoTablicy > 5 || liczbaDoTablicy < 1)
                {
                    Console.WriteLine("Podałeś nie prawidłową liczbę, spróbuj ponownie");
                }
                histogram[liczbaDoTablicy-1]++; // lDT = 3 , 3-1 = pozycja w tablicy, ++ to podniesienie o jeden tej pozycji
            }

            Console.WriteLine("Rysuje histogram");

            for (int i = 0; i < histogram.Length; i++)
            {
                Console.Write((i + 1) + ": ");
                for (int j = 0; j < histogram[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
            Console.ReadLine();

            */

            //ZADANIE 4 

            /* 
            Console.WriteLine("Program sortuje podany przez uzytkownika ciąg znaków (zakladam sortowanie babelkowe). Program powinien zapytać o długość ciągu. \n");

            int dlugoscCiagu = 0;
            int liczbaDoTablicy = 0;
            int temp = 0;

            Console.WriteLine("Podaj n liczb (dlugosc ciagu)");

            while (!int.TryParse(Console.ReadLine(), out dlugoscCiagu))
            {
                Console.WriteLine("Nie podałes prawidłowej liczby, spróbuj ponownie");
            }
            int[] tablica = new int[dlugoscCiagu];

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Podaj {0} z {1} liczb", i + 1, dlugoscCiagu);
                while (!int.TryParse(Console.ReadLine(), out liczbaDoTablicy))
                {
                    Console.WriteLine("Nie podałes prawidłowej liczby, spróbuj ponownie");
                }
                tablica[i] = liczbaDoTablicy; //wpis do tablicy
            }
            
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Posortowane liczby: \n");
            foreach (int i in tablica)
            {
                Console.Write(i + ",");
            }

            Console.ReadLine();
            */

            /*

            Console.WriteLine("Program rysuje trójkąt prostokątny dla a = 5");

            int a = 5;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a - i - 1; j++) // 5 - 0 - 1 (4 odstepy)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            */


            /* 
           Console.WriteLine("Program znajduje najmniejsza i największą liczbę w ciągu a1, a2, ... , an. Liczby a1, a2, ... ,an są liczbami losowymi (zakładam ciąg podany przez użytkownika)\n");

           Random liczbaLosowa = new Random();
           int dlugoscCiagu = 0;   
           Console.WriteLine("Podaj n liczb (dlugosc ciagu)");

           while (!int.TryParse(Console.ReadLine(), out dlugoscCiagu))
           {
               Console.WriteLine("Nie podałes prawidłowej liczby, spróbuj ponownie");
           }
           int[] tablica = new int[dlugoscCiagu];

           for (int i = 0; i < tablica.Length; i++)
           {
               tablica[i] = liczbaLosowa.Next(1,1000);
           }

           foreach (int i in tablica)
           {
               Console.WriteLine(tablica[i]);
           }


           Console.ReadLine();

           */


               
            Console.WriteLine("Program wyświetla na ekranie figurę o wymiarach a i b podanych przez uzytkownika. Figura ma składać się naprzemiennie z linii zbudowanych z dwóch znaków podanych przez użytkownika. Należy sprawdzać poprawność wprowadzonych liczb. \nPrzykładowe działanie programu: \nPodaj wysokość a = 4\nPodaj szerokość b = 6\nPodaj pierwszy znak = &\nPodaj drugi znak = $");

            int wysokosc = 0;
            int dlugosc = 0;
            string pierwszyZnak;
            string drugiZnak;

            Console.WriteLine("Podaj wysokość: ");
            while (!int.TryParse(Console.ReadLine(), out wysokosc) || wysokosc < 0)
            {
                Console.WriteLine("Podano nie prawidłową liczbę, spróbuj ponownie podając ją wyższą od zera. ");
            }

            Console.WriteLine("Podaj długość: ");
            while (!int.TryParse(Console.ReadLine(), out dlugosc) || dlugosc < 0)
            {
                Console.WriteLine("Podano nie prawidłową liczbę, spróbuj ponownie podając ją wyższą od zera. ");
            }

            Console.WriteLine("Podaj pierwszy znak: ");
            pierwszyZnak = Console.ReadLine();

            Console.WriteLine("Podaj drugi znak: ");
            drugiZnak = Console.ReadLine();

            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < dlugosc; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        Console.Write(pierwszyZnak);
                    }
                    else if ((j+i) % 2 == 1)
                    {
                        Console.Write(drugiZnak);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

               
        }
    }
}
