using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01_2025
{
    internal class MainClass
    {
        static void Main(string[] args) 
        {

            StreamWriter plik = new StreamWriter("output.txt");

            int l1 = 0;
            int l2 = 0;

            Console.WriteLine("Podaj pierwszą liczbę do działania:");
            while (!int.TryParse(Console.ReadLine(), out l1) || l1 < 0)
            {
                Console.WriteLine("Nie wpisano poprawnie liczby, spróbuj ponownie.");
            }

            Console.WriteLine("\nPodaj druga liczbę do działania:");
            while (!int.TryParse(Console.ReadLine(),out l2) || l2 < 0)
            {
                Console.WriteLine("Nie wpisano poprawnie liczby, spróbuj ponownie.");
            }

            Console.Write("Wybierz żądane działanie: \n\t1. Dodawanie \n\t2. Odejmowanie \n\t3. Mnożenie \n\t4. Dzielenie");
            int wybor = Int32.Parse(Console.ReadLine());
            
            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Wynik: " + Calculator.Sum(l1, l2)); 
                    plik.WriteLine(Calculator.Sum(l1, l2));
                    plik.Close();
                    break;
                case 2:
                    Console.WriteLine("Wynik: " + Calculator.Subtraction(l1, l2));
                    plik.WriteLine(Calculator.Subtraction(l1, l2));
                    plik.Close();
                    break;
                case 3: 
                    Console.WriteLine("Wynik: " + Calculator.Multiply(l1, l2));
                    plik.WriteLine(Calculator.Multiply(l1, l2));
                    plik.Close();
                    break;
                case 4:
                    Console.WriteLine("Wynik: " + Calculator.Division(l1, l2));
                    plik.WriteLine(Calculator.Division(l1, l2));
                    plik.Close();
                    break;
                default:
                    Console.WriteLine("Wpisano nie poprawną liczbę, spróbuj ponownie.");
                    break;

            }


            Console.ReadKey();
        }
    }

    internal class Calculator 
    {
        public DateTime Data { get; set; }
        public static double Sum(double x, double y)
        {
            double result = 0;

            result = x + y;
            return result;
            // get 2 numbers, do what is needed. return value to program class, 
        }

        public static double Subtraction(double x, double y)
        {
            double result = 0; result = x - y; return result;
        }

        public static double Multiply(double x, double y)
        {
            double result = 0; result = x * y; return result;
        }

        public static double Division(double x, double y)
        {
            double result = 0; result = x / y; return result;
        }
        
    }
}

namespace ConsoleApp5
{
    struct Dzienniczek
    {
        public string imię;
        public List<float> oceny;
        public Dzienniczek(string podaneImię)
        {
            this.imię = podaneImię;
            oceny = new List<float>();
        }
        public void DodajOcenę(float podanaOcena)
        {
            this.oceny.Add(podanaOcena);
        }
        public string Podsumowanie()
        {
            string tekst = $"Uczeń ma na imię {this.imię}, jego oceny to ";
            foreach (float item in oceny)
            {
                tekst += item + " ";
            }
            tekst += $" a jego średnia ocen to {oceny.Average()}";
            return tekst;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dzienniczek> dziennikSzkolny = new List<Dzienniczek>();

            while (true)
            {
                Console.WriteLine("Program przechowuje informacje o uczniach i ich ocenach. Wybierz opcje:");
                Console.WriteLine("1 - Dodanie dzienniczka ucznia ");
                Console.WriteLine("2 - Wyswietlenie dziennika");
                Console.WriteLine("3 - Zapisanie dziennika");
                Console.WriteLine("4 - Otwarcie dziennika");
                string opcja = Console.ReadLine();
                switch (opcja)
                {
                    case "1":
                        Console.WriteLine("Dodawanie dziennika ucznia. Podaj imię");
                        Dzienniczek uczeń = new Dzienniczek(Console.ReadLine());
                        Console.WriteLine("Podaj oceny, rozdzielajac je spacjami:");
                        string oceny = Console.ReadLine();
                        string[] ocenyTablica = oceny.Split(' ');
                        foreach (string ocena in ocenyTablica)
                        {
                            uczeń.DodajOcenę(float.Parse(ocena));
                        }
                        dziennikSzkolny.Add(uczeń);
                        break;
                    case "2":
                        foreach (Dzienniczek item in dziennikSzkolny)
                        {
                            Console.WriteLine(item.Podsumowanie());
                        }
                        break;
                    case "3":
                        Console.WriteLine("Podaj nazwe pod która chcesz zapisać dziennik:");
                        string nazwa = Console.ReadLine();
                        bool czyZapisać = true;
                        if (File.Exists(nazwa + ".txt"))
                        {
                            Console.WriteLine("Plik istnieje, czy chcesz napisać? tak/nie");
                            if (Console.ReadLine() == "tak")
                                czyZapisać = true;
                            else
                                czyZapisać = false;
                        }
                        if (czyZapisać)
                            using (StreamWriter plik = new StreamWriter(nazwa + ".txt"))
                            {
                                foreach (Dzienniczek item in dziennikSzkolny)
                                {
                                    string ocenyTXT = "";
                                    foreach (var ocenaTXT in item.oceny)
                                    {
                                        ocenyTXT += ocenaTXT + " ";
                                    }
                                    plik.WriteLine(item.imię + ";" + ocenyTXT);
                                }
                            }
                        break;
                    case "4":
                        Console.WriteLine("Podaj nazwe pliku dziennika do otwarcia:");
                        nazwa = Console.ReadLine();

                        if (File.Exists(nazwa + ".txt"))
                            using (StreamReader plik = new StreamReader(nazwa + ".txt"))
                            {
                                dziennikSzkolny = new List<Dzienniczek>();
                                for (int i = 0; !plik.EndOfStream; i++)
                                {
                                    string wierzPliku = plik.ReadLine();
                                    string[] wierszTablica = wierzPliku.Split(';');
                                    uczeń = new Dzienniczek(wierszTablica[0]);
                                    oceny = wierszTablica[1];
                                    ocenyTablica = oceny.Split(' ');
                                    foreach (string ocena in ocenyTablica)
                                    {
                                        if (ocena != "")
                                            uczeń.DodajOcenę(float.Parse(ocena));
                                    }
                                    dziennikSzkolny.Add(uczeń);
                                }

                            }
                        else
                            Console.WriteLine("Nie ma pliku o nazwie: " + nazwa);
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji ");
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
