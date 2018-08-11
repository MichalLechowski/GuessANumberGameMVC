using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGraLib;

namespace GraWindowsFormsApp
{
    public partial class HistoriaForm : Form
    {
        private GraModel gra;
        public HistoriaForm()
        {
            InitializeComponent();
        }

        public HistoriaForm(GraModel gra) : this()
        {
            this.gra = gra;

            listViewHistoria.View = View.Details;
            listViewHistoria.Columns.Add("Nr", 30);
            listViewHistoria.Columns.Add("Propozycja", 80);
            listViewHistoria.Columns.Add("Odpowiedź", 80);
            listViewHistoria.Columns.Add("Czas", 120);

            if (gra.ListaRuchow.Count == 0)
            {
                return;
            }

            int i = 1;
            foreach (var ruch in gra.ListaRuchow)
            {
                string[] tab = new string[4];
                tab[0] = i.ToString();
                tab[1] = ruch.propozycja.ToString();
                tab[2] = ruch.odpowiedz.ToString();
                tab[3] = ruch.moment.ToString();

                ListViewItem item = new ListViewItem(tab);
                listViewHistoria.Items.Add(item);
                i++;
            }
        }
    }
}
