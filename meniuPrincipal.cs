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
        List<Control> controale = new List<Control>();
        List<Size> marimi = new List<Size>();
        public meniuPrincipal()
        {
            InitializeComponent();
            //this.Width = retinereRezolutie.lungime;
            //this.Height = retinereRezolutie.inaltime;
            //modificareButoaneMeniuPrincipal();
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
        protected void elementeMeniuPrincipal()
        {
            controale.Add(butonIesire);
            marimi.Add(butonIesire.Size);
            controale.Add(butonOptiuni);
            marimi.Add(butonOptiuni.Size);
            controale.Add(butonExerseaza);
            marimi.Add(butonExerseaza.Size);
            controale.Add(butonIesire);
            marimi.Add(butonIesire.Size);
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

        protected override void conversie()
        {
            base.conversie();
            modificareButoaneMeniuPrincipal();
        }

        private void meniuPrincipal_Load(object sender, EventArgs e)
        {
            retinereRezolutii.formaActuala = this;
            aplicareCuloare();
            conversie();
        }
    }
    public static class retinereFormaAnterioara
    {
        public static Form formaAnteriora;
    }


}

