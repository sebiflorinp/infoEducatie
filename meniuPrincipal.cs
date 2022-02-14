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
            luareValoriRezolutii(this.Width, this.Height);
            calculareRatiiForma();
        }

        private void butonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fereastraOptiuni form = new fereastraOptiuni();
            pastrareMarimeFereastraNoua(this, form);
            verificareMaximizareFereastraNoua(this, form);
            this.Hide();
            form.Show();
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
    }
}
