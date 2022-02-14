using System;
using System.Drawing;
using System.Windows.Forms;

namespace infoEducatie
{
    public partial class templateMeniuPrincipal : Form
    {

        protected float ratieLungime;
        protected float ratieInaltime;
        protected float ratieX;
        protected float ratieY;
        protected Rectangle formaInitiala;
        protected Rectangle formaFinala;
        protected Rectangle controlDeModificatInitial;
        protected Rectangle controlDeModificatFinal;
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
            butonAjutor.Click -= butonAjutor_Click;
        }
        protected void verificareMaximizareFereastraNoua(templateMeniuPrincipal formaDinCareSeApasa, templateMeniuPrincipal formaNoua)
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
        protected void pastrareMarimeFereastraNoua(templateMeniuPrincipal fereastraDinCareSeDeschide, templateMeniuPrincipal fereastraNoua)
        {
            if (fereastraDinCareSeDeschide.WindowState == FormWindowState.Maximized)
            {
                fereastraNoua.WindowState = FormWindowState.Maximized;
            }
            else
            {
                fereastraNoua.Width = fereastraDinCareSeDeschide.Size.Width;
                fereastraNoua.Height = fereastraDinCareSeDeschide.Size.Height;
            }
        }

        protected void luareValoriRezolutii()
        {
            formaInitiala.Width = this.Size.Width;
            formaInitiala.Height = this.Size.Height;
            formaFinala.Width = Screen.PrimaryScreen.Bounds.Width;
            formaFinala.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        protected void luareValoriRezolutii(int lungime, int inaltime)
        {
            formaInitiala.Width = this.Size.Width;
            formaInitiala.Height = this.Size.Height;
            formaFinala.Width = lungime;
            formaFinala.Height = inaltime;
        }

        protected void calculareRatiiForma()
        {
            ratieLungime = (float)formaFinala.Width / formaInitiala.Width;
            ratieInaltime = (float)formaFinala.Height / formaInitiala.Height;
        }

        protected void calculareRatiiElement(Control deModificat)
        {
            controlDeModificatInitial.X = deModificat.Location.X;
            controlDeModificatInitial.Y = deModificat.Location.Y;
            ratieX = (float)formaFinala.Width / formaInitiala.Width;
            ratieY = (float)formaFinala.Height / formaInitiala.Height;
        }

        protected void modificareElemente(Control deModificat)
        {
            controlDeModificatInitial.Width = deModificat.Size.Width;
            controlDeModificatInitial.Height = deModificat.Size.Height;
            calculareRatiiElement(deModificat);
            controlDeModificatFinal.Width = (int)(controlDeModificatInitial.Width * ratieLungime);
            controlDeModificatFinal.Height = (int)(controlDeModificatInitial.Height * ratieInaltime);
            controlDeModificatFinal.X = (int)(controlDeModificatInitial.X * ratieX);
            controlDeModificatFinal.Y = (int)(controlDeModificatInitial.Y * ratieY);
            deModificat.Size = new Size(controlDeModificatFinal.Width, controlDeModificatFinal.Height);
            deModificat.Location = new Point(controlDeModificatFinal.X, controlDeModificatFinal.Y);
        }
    }
}
