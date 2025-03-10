using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01_2025
{
    class Dzienniczek
    {
        public string imieUcznia;
        public List<int> ocenyUcznia;
        public Dzienniczek(string podaneImie)
        {
            imieUcznia = podaneImie;
            ocenyUcznia = new List<int>(); 
        }

        public void DodajOcene(int ocena) 
        { 
            ocenyUcznia.Add(ocena);
        }

        public string Podsumowanie()
        {
            String podsumowanie = $"Uczen nazywa się: {imieUcznia} i ma oceny: ";
            foreach (int ocena in ocenyUcznia)
            {
                podsumowanie += ocena + " ";
            }
            return podsumowanie;
        }

        public string Zapis()
        {
            String zapis = $"{imieUcznia}";
            foreach (int ocena in ocenyUcznia)
            {
                zapis += ocena + " ";
            }
            return zapis;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dzienniczek> dziennikSzkolny = new List<Dzienniczek>(); //inicjalizacja ogólnego zbioru dzienników szkolnych

            while (true) 
            {

                Console.WriteLine("Program umożliwia utworzenie dzienniczka ucznia");
                Console.WriteLine("\t1 - Utworzenie dzienniczka");
                Console.WriteLine("\t2 - Wyświetlenie dzienniczka");
                Console.WriteLine("\t3 - Zapisanie dzienniczka do pliku");
                Console.WriteLine("\t4 - Otworzenie dzienniczka z pliku");
                Console.WriteLine("\t5 - Wyjście");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Tworzenie dzienniczka\n");
                        Console.WriteLine("Podaj imię ucznia:");
                        string imieUcznia = Console.ReadLine(); 

                        Dzienniczek uczen = new Dzienniczek(imieUcznia); // utworzenie nowego obiektu Dzienniczka z nazwą uczen, przekazywany parametr (nazwa zbioru) to imieUcznia
                        
                        Console.WriteLine("Podaj oceny rozdzielając je spacjami");
                        string ocenyUcznia = Console.ReadLine();
                        string[] OcenyTab = ocenyUcznia.Split(' '); // podział ocen na osobne indeksy w tabeli
                        foreach (string ocena in OcenyTab)
                        {
                            uczen.DodajOcene(int.Parse(ocena));
                        }

                        dziennikSzkolny.Add(uczen); // dodanie wszystkich zebranych wartości do ogólnego zbioru dzienników szkolnych 

                        break;
                    case "2":
                        Console.WriteLine("Wyświetlanie dzienniczka\n");
                        foreach (Dzienniczek item in dziennikSzkolny)
                        {
                            Console.WriteLine(item.Podsumowanie());
                        }
                        break;
                    case "3":
                        Console.WriteLine("Zapisanie dzienniczka do pliku\n");
                        Console.WriteLine("Pod jaką nazwą chcesz zapisać plik?");
                        string nazwaPliku = Console.ReadLine();
                        string path = @nazwaPliku;

                        if (!File.Exists(path))
                        {
                            using (StreamWriter plik = new StreamWriter(path + ".txt"))
                            {
                                foreach (Dzienniczek item in dziennikSzkolny)
                                {
                                    string ocenyTXT = "";
                                    foreach (var ocenaTXT in item.ocenyUcznia)
                                    {
                                        ocenyTXT += ocenaTXT + " ";
                                    }
                                    plik.WriteLine(item.imieUcznia + ";" + ocenyTXT); //zapis z ";" jest wymagany aby rozdzielic później imie ucznia z ocenami (wyjasnione nizej)
                                }
                            }
                        } 
                        else
                        {
                            Console.WriteLine("Plik pod taką nazwą już istnieje");
                        }
                        
                        break;
                    case "4":
                        Console.WriteLine("Otworzenie dzienniczka z pliku\n");
                        Console.WriteLine("Podaj nazwę dziennika do otwarcia");
                        string nazwaPliku2 = Console.ReadLine(); 
                        string path2 = @nazwaPliku2;
                        
                        if (!File.Exists(path2))
                        {
                            using (StreamReader plik2 = new StreamReader(path2 + ".txt"))
                            {
                                dziennikSzkolny = new List<Dzienniczek>(); // wymagane do dodania uczniow z pliku
                                for (int i = 0; !plik2.EndOfStream; i++)
                                {
                                    string wierzchPliku = plik2.ReadLine(); // odczyt pierwszej linii 
                                    string[] wierszTablica = wierzchPliku.Split(';'); // podział imieUcznia / oceny (zapis: janek; 1 2 3 4)
                                    uczen = new Dzienniczek(wierszTablica[0]); // utworzenie nowego obiektu w dzienniczku z nazwy ucznia wziętego z rozdzielonej tabeli
                                    ocenyUcznia = wierszTablica[1]; 
                                    string[] ocenyTab = ocenyUcznia.Split(' '); // rozdzielenie ocen ucznia na osobne indeksy w tabeli
                                    foreach (string ocena in ocenyTab) 
                                    {
                                        if (ocena != "")
                                        {
                                            uczen.DodajOcene(int.Parse(ocena)); 
                                        }
                                    }
                                    dziennikSzkolny.Add(uczen);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Taki plik nie istnieje.");
                        }
                        
                        break;
                    case "5":
                        Console.WriteLine("Wyjście");
                        return;
                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                }
            }
        }
    }
}
