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
    public partial class Form1 : Form
    {
        private Form info = null;

        private GraModel g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNowaGra_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            tbZakresDo.Visible = true;
            tbZakresOd.Visible = true;
            btnWylosuj.Visible = true;
            btnPrzerwij.Visible = true;


        }

        private void btnWylosuj_Click(object sender, EventArgs e)
        {
            labelKomunikat.Text = string.Empty;
            int min = 0;
            int max = 100;

            try
            {
                min = Convert.ToInt32(tbZakresOd.Text);
                max = Convert.ToInt32(tbZakresDo.Text);
            }
            catch (FormatException)
            {
                labelKomunikat.Text = Resource.ErrorNumberFormat;
            }
            catch (OverflowException)
            {
                labelKomunikat.Text = "Za duża liczba";
            }

            g = new GraModel(min, max);
            timer1.Start();

        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            int prop;

            try
            {
                prop = Convert.ToInt32(tbPropozycja.Text);

            }

            catch (Exception)
            {

                throw;
            }


            switch (g.Propozycja(prop))
            {
                case Odp.ZaDuzo:
                    labelOdp.Text = Resource.ZaDuzo;
                    break;
                case Odp.ZaMalo:
                    labelOdp.Text = Resource.ZaMalo;
                    break;
                case Odp.Trafione:
                    labelOdp.Text = Resource.Trafiono;
                    timer1.Stop();
                    lblStatystyki.Text = Statystyki();
                    break;

                default:
                    labelOdp.Text = "Nieznana sytuacja";
                    break;
            }
        }

        private void btnPrzerwij_Click(object sender, EventArgs e)
        {
            g.Poddaj();
            timer1.Stop();
            lblWylosowana.Visible = true;
            lblWylosowana.Text = "Wylosowano: " + g.Wylosowana.ToString();
            lblStatystyki.Text = Statystyki();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = g.AktualnyCzasGry.ToString();
        }

        private string Statystyki()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Liczba prób: ");
            sb.Append(g.ListaRuchow.Count);
            sb.Append(Environment.NewLine);

            sb.Append("Czas gry: ");
            sb.Append((g.ListaRuchow[g.ListaRuchow.Count - 1].moment - g.ListaRuchow[0].moment).ToString());

            sb.Append(Environment.NewLine);
            sb.Append("Status gry: ");
            sb.Append(g.Status);

            return sb.ToString();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (info == null)
            {
                info = new AboutBox();
            }
            info.Show();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            (new HistoriaForm(g)).Show();
        }
    }
}
