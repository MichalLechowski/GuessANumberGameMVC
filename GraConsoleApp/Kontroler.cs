using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelGraLib;

namespace GraConsoleApp
{
    public class Kontroler
    {
        private Widok w;
        private GraModel g;

        public Kontroler()
        {
            w = new Widok(this);
            g = new GraModel();
        }

        public void Run()
        {
            w.CzyscEkran();
            w.WypiszOpisGry();
            Rozgrywka();
        }

        private void Rozgrywka()
        {
            int min, max;
            Console.WriteLine("Podaj zakres losowanej liczby:");

            Console.WriteLine("Min?");
            while (!(Int32.TryParse(Console.ReadLine(), out min)))
            {
                Console.WriteLine("Niepoprawny format liczby! Wpisz poprawną wartość.");
            }

            Console.WriteLine("Max?");
            while (!(Int32.TryParse(Console.ReadLine(), out max)) || !(max > min))
            {
                Console.WriteLine("Niepoprawny format liczby lub wartość max jest większa od min. Wpisz poprawną wartość.");
            }

            g = new GraModel(min, max);
            w.stopwatch.Start();
            
            do
            {
                Console.WriteLine("Podaj propozycję lub wpisz poddaj w celu zrezygnowania z dalszej rozgrywki: ");

                string propAsString;
                propAsString = Console.ReadLine();
                int prop = -1;

                if (propAsString == "poddaj")
                {
                    g.Poddaj();
                }
                else
                {
                    if (!(Int32.TryParse(propAsString, out prop)))
                    {
                        while (!(Int32.TryParse(Console.ReadLine(), out prop)))
                        {
                            Console.WriteLine("Zły format liczby");
                        }
                    }
                }

                switch (g.Propozycja(prop))
                {
                    case Odp.ZaDuzo:
                        Console.WriteLine("za dużo");
                        Console.WriteLine("Liczba sekund od startu gry: " + w.stopwatch.Elapsed.Seconds);
                        break;
                    case Odp.ZaMalo:
                        Console.WriteLine("za mało");
                        Console.WriteLine("Liczba sekund od startu gry: " + w.stopwatch.Elapsed.Seconds);

                        break;
                    case Odp.Trafione:
                        Console.WriteLine("Trafiłeś!");
                        Console.WriteLine(g.Wylosowana);
                        w.stopwatch.Stop();
                        break;
                    default:
                        Console.WriteLine("Gra została poddana");
                        break;
                }
                //zadawanie pytan, sprawdzenie, z modelu pociągnie
            } while (g.Status == StatusGry.Trwa);

            Console.WriteLine(w.WypiszStatystykiGry());
            w.WypiszHistorieGry();

            Console.ReadLine();
        }

        // mapowanie funkcjonalności gry
        public IReadOnlyList<GraModel.Ruch> ListaRuchow => g.ListaRuchow;

        public StatusGry StatusGry => g.Status;
    }
}