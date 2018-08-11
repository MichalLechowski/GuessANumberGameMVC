using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace GraConsoleApp
{
    class Widok
    {
        Kontroler kontroler;
        public Stopwatch stopwatch = new Stopwatch();

        public Widok(Kontroler parent)
        {
            kontroler = parent;
        }

        public void CzyscEkran() => Console.Clear();

        public void WypiszOpisGry()
        {
            Console.WriteLine("Gra polega na odgadnięciu liczby wylosowanej z podanego zakresu.");
        }

        public string WypiszStatystykiGry()
        {
            TimeSpan dtDifference = new TimeSpan();
            dtDifference = kontroler.ListaRuchow[kontroler.ListaRuchow.Count - 1].moment - kontroler.ListaRuchow[0].moment;
            return string.Format($"Liczba prób: {kontroler.ListaRuchow.Count}\nCzas gry: {dtDifference.ToString(@"hh\:mm\:ss")}\nStatus gry: {kontroler.StatusGry}");
        }

        public void WypiszHistorieGry()
        {
            if (kontroler.ListaRuchow.Count != 0)
            {
                int nrRuchu = 1;
                foreach (var item in kontroler.ListaRuchow)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ruch nr: {nrRuchu}");
                    Console.WriteLine($"Propozycja: {item.propozycja}");
                    Console.WriteLine($"Odpowiedź: {item.odpowiedz}");
                    Console.WriteLine($"Czas: {item.moment}");
                    nrRuchu++;
                }
            }
        }
    }
}