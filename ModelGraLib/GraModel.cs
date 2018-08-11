using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGraLib
{
    public class GraModel
    {
        private readonly int wylosowana;
        private StatusGry status;
        private IList<Ruch> lista;

        public TimeSpan? AktualnyCzasGry
        {
            get
            {
                if (lista.Count == 0)
                {
                    return null;
                }
                return (DateTime.Now - lista[0].moment);
            }
        }

        public GraModel(int min = 1, int max = 100)
        {
            Random rand = new Random();
            wylosowana = rand.Next(min, max + 1);

            status = StatusGry.Nowa;

            lista = new List<Ruch>();
        }

        public StatusGry Status => status;

        public int? Wylosowana => (status == StatusGry.Poddana || status == StatusGry.Odgadnieta) ? (int?)wylosowana : null;

        public Odp? Propozycja(int x)
        {
            if (lista.Count == 0)
            {
                status = StatusGry.Trwa;
            }

            if (status == StatusGry.Poddana || status == StatusGry.Odgadnieta)
            {
                return null;
            }

            Odp odp;

            if (x == wylosowana)
            {
                odp = Odp.Trafione;
                status = StatusGry.Odgadnieta;
            }
            else if (x < wylosowana)
            {
                odp = Odp.ZaMalo;
            }
            else
            {
                odp = Odp.ZaDuzo;
            }

            lista.Add(new Ruch(x, odp));
            return odp;

            //todo: zapis do listy
        }

        public void Poddaj()
        {
            status = StatusGry.Poddana;
        }

        //uniemożliwia dostęp do metod Add,Remove etc. przez ustawienia na asreadonly
        public IReadOnlyList<Ruch> ListaRuchow => ((List<Ruch>)lista).AsReadOnly();

        //nested class
        public class Ruch
        {
            public readonly int propozycja;
            public readonly Odp odpowiedz;
            public readonly DateTime moment;

            internal Ruch(int propozycja, Odp odpowiedz)
            {
                
                this.propozycja = propozycja;
                this.odpowiedz = odpowiedz;
                moment = DateTime.Now;

            }

            public override string ToString()
            {
                return $"[{propozycja}, {odpowiedz}, {moment}]";
            }
        }
        
    }

 
}
