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
    public partial class templateMeniuPrincipal : Form
    {

        protected Rectangle marimiForma;
        protected float marimeDupaLungime;
        protected float marimeDupaInaltime;
        protected float ratieLungime;
        protected float ratieInaltime;
        protected float ratieX;
        protected float ratieY;
        protected float marimeInitialLungime;
        protected float marimeInitialInaltime;
        protected float marimeDeModificatInitialLungime;
        protected float marimeDeModificatInitialInaltime;
        protected float marimeDeModificatFinalLungime;
        protected float marimeDeModificatFinalInaltime;
        protected float locatieInitialX;
        protected float locatieInitialY;
        protected float locatieFinalX;
        protected float locatieFinalY;
        public templateMeniuPrincipal()
        {
            InitializeComponent();
        }

        private void butonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void butonMaximizare_Click(object sender, EventArgs e)
        {
            luareValoriRezolutii();
            calculareRatiiForma();
            WindowState = FormWindowState.Maximized;
            butonAjutor.Visible = false;
            butonMaximizare.Visible = false;
            butonX.Visible = false;
            butonMinimizare.Visible = false;
            baraDrag.Visible = false;
        }

        private void butonMinimizare_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void butonAjutor_Click(object sender, EventArgs e)
        {
            Ajutor meniuAjutor = new Ajutor();
            meniuAjutor.Show();
            meniuAjutor.Focus();
            butonAjutor.Click-=butonAjutor_Click;
        }
        protected void verificareMaximizareFereastraNoua(templateMeniuPrincipal formaDinCareSeApasa,templateMeniuPrincipal formaNoua)
        {
            if (formaDinCareSeApasa.WindowState == FormWindowState.Maximized)
            {
                formaNoua.butonAjutor.Visible = false;
                formaNoua.butonMaximizare.Visible = false;
                formaNoua.butonX.Visible = false;
                formaNoua.butonMinimizare.Visible = false;
                formaNoua.baraDrag.Visible = false;
            }
        }
        protected void pastrareMarimeFereastraNoua(templateMeniuPrincipal fereastraDinCareSeDeschide,templateMeniuPrincipal fereastraNoua)
        {
            if (fereastraDinCareSeDeschide.WindowState == FormWindowState.Maximized)
            {
                fereastraNoua.WindowState = FormWindowState.Maximized;
            }
            else
            {
                var meniuPrincipalLatime = fereastraDinCareSeDeschide.Size.Width;
                var meniuPrincipalInaltime = fereastraDinCareSeDeschide.Size.Height;
                fereastraNoua.Width = meniuPrincipalLatime;
                fereastraNoua.Height = meniuPrincipalInaltime;
            }
        }

        protected void luareValoriRezolutii()
        {
            marimeInitialLungime = this.Size.Width;
            marimeInitialInaltime = this.Size.Height;
            marimeDupaLungime = Screen.PrimaryScreen.Bounds.Width;
            marimeDupaInaltime = Screen.PrimaryScreen.Bounds.Height;
        }

        protected void luareValoriRezolutii(int lungime, int inaltime)
        {
            marimeInitialLungime = this.Size.Width;
            marimeInitialInaltime = this.Size.Height;
            marimeDupaLungime = lungime;
            marimeDupaInaltime = inaltime;
        }

        protected void calculareRatiiForma()
        {
            ratieLungime = marimeDupaLungime / marimeInitialLungime;
            ratieInaltime = marimeDupaInaltime / marimeInitialInaltime;
        }

        protected void calculareRatiiElement(Control deModificat)
        {
            locatieInitialX = deModificat.Location.X;
            locatieInitialY = deModificat.Location.Y;
            ratieX = marimeDupaLungime / marimeInitialLungime ;
            ratieY = marimeDupaInaltime / marimeInitialInaltime;
        }

        protected void modificareElemente(Control deModificat)
        {
            marimeDeModificatInitialLungime = deModificat.Size.Width;
            marimeDeModificatInitialInaltime = deModificat.Size.Height;
            calculareRatiiElement(deModificat);
            marimeDeModificatFinalLungime = marimeDeModificatInitialLungime * ratieLungime;
            marimeDeModificatFinalInaltime = marimeDeModificatInitialInaltime * ratieInaltime;
            locatieFinalX = locatieInitialX * ratieX;
            locatieFinalY =  locatieInitialY * ratieY;
            deModificat.Size = new Size((int) marimeDeModificatFinalLungime,(int) marimeDeModificatFinalInaltime);
            deModificat.Location = new Point((int)locatieFinalX, (int)locatieFinalY);
        }
    }
}
