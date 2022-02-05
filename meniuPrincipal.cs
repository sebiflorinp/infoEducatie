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
        }

        private void butonIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fereastraOptiuni form = new fereastraOptiuni();
            var meniuPrincipalLatime = this.Size.Width;
            var meniuPrincipalInaltime = this.Size.Height;
            form.Width = meniuPrincipalLatime;
            form.Height = meniuPrincipalInaltime;
            verificareMaximizareFereastraNoua(this,form);
            form.Show();
        }
    }
}
