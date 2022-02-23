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
    public partial class meniuPrincipal : templateMeniuPrincipal
    {
        public meniuPrincipal()
        {
            InitializeComponent();
            this.Width = retinereRezolutie.lungime;
            this.Height = retinereRezolutie.inaltime;
            modificareButoaneMeniuPrincipal();
        }

        private void butonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void butonMaximizare_Click(object sender, EventArgs e)
        {
            base.butonMaximizare_Click(sender, e);
            modificareButoaneMeniuPrincipal();
           
        }

        protected void modificareButoaneMeniuPrincipal()
        {
            modificareElemente(butonIesire);
            modificareElemente(butonOptiuni);
            modificareElemente(butonExerseaza);
            modificareElemente(butonInvata);
        }

        private void butonOptiuni_Click(object sender, EventArgs e)
        {
            fereastraOptiuni form = new fereastraOptiuni();
            retinereFormaAnterioara.formaAnteriora = this;
            trecereForme(this, form);
        }

        private void butonInvata_Click(object sender, EventArgs e)
        {

        }

        protected override void aplicareCuloare()
        {
            base.aplicareCuloare();
            aplicareCuloare(butonIesire);
            aplicareCuloare(butonExerseaza);
            aplicareCuloare(butonInvata);
            aplicareCuloare(butonOptiuni);
        }

        private void meniuPrincipal_Load(object sender, EventArgs e)
        {
            aplicareCuloare();
        }
    }
    public static class retinereFormaAnterioara
    {
        public static Form formaAnteriora;
    }


}

