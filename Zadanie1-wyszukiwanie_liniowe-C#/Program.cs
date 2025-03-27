using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Zadanie1_wyszukiwanie_liniowe_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 100_000_000;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }

            int firstElement = array[0];
            int lastElement = array[size - 1];

            // Wyszukiwanie liniowe - pierwszy element
            Stopwatch stopwatch = Stopwatch.StartNew();
            int index = LinearSearch(array, firstElement);
            stopwatch.Stop();
            double linearFirstTime = stopwatch.Elapsed.TotalMilliseconds;

            // Wyszukiwanie liniowe - ostatni element
            stopwatch.Restart();
            index = LinearSearch(array, lastElement);
            stopwatch.Stop();
            double linearLastTime = stopwatch.Elapsed.TotalMilliseconds;

            // Wyszukiwanie binarne - pierwszy element
            stopwatch.Restart();
            index = BinarySearch(array, firstElement);
            stopwatch.Stop();
            double binaryFirstTime = stopwatch.Elapsed.TotalMilliseconds;

            // Wyszukiwanie binarne - ostatni element
            stopwatch.Restart();
            index = BinarySearch(array, lastElement);
            stopwatch.Stop();
            double binaryLastTime = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine($"Czas wyszukiwania liniowego - pierwszy element: {linearFirstTime:F6} ms");
            Console.WriteLine($"Czas wyszukiwania liniowego - ostatni element: {linearLastTime:F6} ms");
            Console.WriteLine($"Czas wyszukiwania binarnego - pierwszy element: {binaryFirstTime:F6} ms");
            Console.WriteLine($"Czas wyszukiwania binarnego - ostatni element: {binaryLastTime:F6} ms");

            GenerateCsv(linearFirstTime, linearLastTime, binaryFirstTime, binaryLastTime);
        }

        static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        static void GenerateCsv(double linearFirst, double linearLast, double binaryFirst, double binaryLast)
        {
            string filePath = "wyniki_wyszukiwania.csv";
            var lines = new List<string>
            {
                "Algorytm,Element,Czas (ms)",
                $"Wyszukiwanie liniowe,Pierwszy,{linearFirst:F6}",
                $"Wyszukiwanie liniowe,Ostatni,{linearLast:F6}",
                $"Wyszukiwanie binarne,Pierwszy,{binaryFirst:F6}",
                $"Wyszukiwanie binarne,Ostatni,{binaryLast:F6}"
            };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Dane zostały zapisane do pliku {filePath}");
        }
    }
}
