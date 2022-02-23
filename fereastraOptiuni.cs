using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoEducatie
{
    public partial class fereastraOptiuni : templateMeniuPrincipal
    {

        protected Rectangle marimiForma;
        protected string rezolutie;
        public fereastraOptiuni()
        {
            InitializeComponent();
            modificareButoaneMeniuOptiuni();
            culoareCurenta.BackColor = retinereCuloare.culoare;
        }

        private void optiuniBack_Click(object sender, EventArgs e)
        {
            trecereForme(this, retinereFormaAnterioara.formaAnteriora);
            Close();
            Application.Restart();
        } // merge in forma care a deschis aceasta forma

        protected override void aplicareCuloare()
        {
            base.aplicareCuloare();
            aplicareCuloare(optiuni);
            aplicareCuloare(optiuniBack);
            aplicareCuloare(rezolutieNouAleasa);
            aplicareCuloare(rezolutieCurenta);
            aplicareCuloare(rezolutieSelectata);
            aplicareCuloare(lRezolutie);
            aplicareCuloare(lCuloareCurenta);
            aplicareCuloare(lCuloareSelectata);
            aplicareCuloare(culori);
            aplicareCuloare(bgCulori);
            aplicareCuloare(bgRezolutii);
            aplicareCuloare(valoareaRezolutieCurenta);
            aplicareCuloare(valoareRezolutieSelectata);
            aplicareCuloare(butonAplica);
            rezolutiiDisponibile.ForeColor = retinereCuloare.culoare;
        } // ce se coloreaza normal + elemente specifice acestei forme

        private void rezolutiiDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {
            valoareRezolutieSelectata.Text = rezolutiiDisponibile.Text;
        }

        private void fereastraOptiuni_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                valoareaRezolutieCurenta.Text = "Fullscreen";
            }
            else
            {
                marimiForma.X = this.Size.Width;
                marimiForma.Y = this.Size.Height;
                valoareaRezolutieCurenta.Text = marimiForma.X + " x " + marimiForma.Y;
            }
        }

        private void butonAplica_Click(object sender, EventArgs e)
        {
            if (valoareRezolutieSelectata.Text!="...")
            {
                rezolutie = String.Copy(valoareRezolutieSelectata.Text);
                var lungime = rezolutie.Substring(0, rezolutie.IndexOf(" "));
                var inaltime = rezolutie.Substring(rezolutie.IndexOf(" ") + 3, rezolutie.IndexOf(" "));
                formaFinala.Width = Int32.Parse(lungime);
                formaFinala.Height = Int32.Parse(inaltime);
                luareValoriRezolutii(formaInitiala.Width, formaInitiala.Height, formaFinala.Width, formaFinala.Height);
                this.WindowState = FormWindowState.Normal;
                this.Height = formaFinala.Height;
                this.Width = formaFinala.Width;
                valoareaRezolutieCurenta.Text = lungime + " x " + inaltime;
                this.CenterToScreen();
                calculareRatiiForma(formaInitiala, formaFinala);
                modificareButoaneMeniuOptiuni();
            }
            if(culoareCurenta.BackColor!=culoareSelectata.BackColor)
            {
                Properties.Settings.Default.culoare=culoareSelectata.BackColor;
                retinereCuloare.culoare=culoareSelectata.BackColor;
                aplicareCuloare();
                Properties.Settings.Default.Save();
            }
        }

        protected override void butonMaximizare_Click(object sender, EventArgs e)
        {
            base.butonMaximizare_Click(sender, e);
            modificareButoaneMeniuOptiuni();
        }  // ce face initial + ce va mai modifica in aceasta forma (fereastraOptiuni)

        protected void modificareButoaneMeniuOptiuni()
        {
            modificareElemente(butonAplica);
            modificareElemente(rezolutieCurenta);
            modificareElemente(rezolutieNouAleasa);
            modificareElemente(rezolutieSelectata);
            modificareElemente(rezolutiiDisponibile);
            modificareElemente(optiuni);
            modificareElemente(optiuniBack);
            modificareElemente(valoareaRezolutieCurenta);
            modificareElemente(valoareRezolutieSelectata);
            modificareElemente(bgCulori);
            modificareElemente(bgRezolutii);
            modificareElemente(culori);
            modificareElemente(culoare1);
            modificareElemente(culoare2);
            modificareElemente(culoare3);
            modificareElemente(culoare4);
            modificareElemente(culoare5);
            modificareElemente(culoare6);
            modificareElemente(culoare7);
            modificareElemente(culoare8);
            modificareElemente(culoare9);
            modificareElemente(culoare10);
            modificareElemente(culoare11);
            modificareElemente(culoare12);
            modificareElemente(culoare13);
            modificareElemente(culoare14);
            modificareElemente(culoare15);
            modificareElemente(culoare16);
            modificareElemente(culoare17);
            modificareElemente(culoare18);
            modificareElemente(culoare19);
            modificareElemente(culoare20);
            modificareElemente(culoare21);
            modificareElemente(culoare22);
            modificareElemente(culoare23);
            modificareElemente(culoare24);
            modificareElemente(culoare25);
            modificareElemente(culoare26);
            modificareElemente(culoare27);
            modificareElemente(culoare28);
            modificareElemente(culoare29);
            modificareElemente(culoare30);
            modificareElemente(culoare31);
            modificareElemente(culoare32);
            modificareElemente(culoare33);
            modificareElemente(culoare34);
            modificareElemente(culoare35);
            modificareElemente(culoare36);
            modificareElemente(culoare37);
            modificareElemente(culoare38);
            modificareElemente(culoare39);
            modificareElemente(culoare40);
            modificareElemente(culoare41);
            modificareElemente(culoare42);
            modificareElemente(culoare43);
            modificareElemente(culoare44);
            modificareElemente(culoare45);
            modificareElemente(culoare46);
            modificareElemente(culoare47);
            modificareElemente(culoare48);
            modificareElemente(culoare49);
            modificareElemente(culoare50);
            modificareElemente(culoare51);
            modificareElemente(culoare52);
            modificareElemente(culoare53);
            modificareElemente(culoare54);
            modificareElemente(culoare55);
            modificareElemente(culoare56);
            modificareElemente(culoare57);
            modificareElemente(culoare58);
            modificareElemente(culoare59);
            modificareElemente(culoare60);
            modificareElemente(culoareCurenta);
            modificareElemente(culoareSelectata);
            modificareElemente(lCuloareCurenta);
            modificareElemente(lCuloareSelectata);
            modificareElemente(lRezolutie);

        } // ce elemente vor fi modificate (marime)
    }
}
