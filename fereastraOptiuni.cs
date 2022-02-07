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

        protected string rezolutie;
        public fereastraOptiuni()
        {
            InitializeComponent();
        }

        private void optiuniBack_Click(object sender, EventArgs e)
        {
            templateMeniuPrincipal meniuPrincipal = new meniuPrincipal();
            pastrareMarimeFereastraNoua(this, meniuPrincipal);
            verificareMaximizareFereastraNoua(this, meniuPrincipal);
            Close();
            meniuPrincipal.Show();
        }

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
            rezolutie = String.Copy(valoareRezolutieSelectata.Text);
            var lungime = rezolutie.Substring(0, rezolutie.IndexOf(" "));
            var inaltime = rezolutie.Substring(rezolutie.IndexOf(" ") + 3, rezolutie.IndexOf(" "));
            this.WindowState = FormWindowState.Normal;
            this.Height = Int32.Parse(inaltime);
            this.Width = Int32.Parse(lungime);
            valoareaRezolutieCurenta.Text = lungime + " x " + inaltime;
        }
    }
}
