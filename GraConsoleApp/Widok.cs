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
            Console.WriteLine();
        }

        public string WypiszStatystykiGry()
        {
            if (kontroler.ListaRuchow.Count != 0)
            {
                TimeSpan dtDifference = new TimeSpan();
                //takie podejście powoduje, że w przypadku rezygnacji po 1 ruchu, czas będzie zawsze równy 00:00:00
                dtDifference = kontroler.ListaRuchow[kontroler.ListaRuchow.Count - 1].moment - kontroler.ListaRuchow[0].moment;
                return string.Format($"Liczba prób: {kontroler.ListaRuchow.Count}\nCzas gry: {dtDifference.ToString(@"hh\:mm\:ss")}\nStatus gry: {kontroler.StatusGry}");
            }
            else
            {
                return "Nie wykonałeś żadnego ruchu. Brak statystyk.";
            }
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