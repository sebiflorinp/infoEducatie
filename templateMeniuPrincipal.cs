﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using infoEducatie.Properties;

namespace infoEducatie
{
    public partial class templateMeniuPrincipal : Form
    {

        protected float ratieLungimeX;
        protected float ratieInaltimeY;
        protected Rectangle formaInitiala;
        protected Rectangle formaFinala;
        protected Rectangle controlDeModificatInitial;
        protected Rectangle controlDeModificatFinal;
        public templateMeniuPrincipal()
        {
            InitializeComponent();
            retinereRezolutie.lungime = Properties.Settings.Default.lungime;
            retinereRezolutie.inaltime = Properties.Settings.Default.inaltime;
            if (Properties.Settings.Default.maximizat == 1)
            {
                maximizare();
            }
            else
            {
                luareValoriRezolutii(retinereRezolutie.lungime, retinereRezolutie.inaltime,this.Width,this.Height);
                calculareRatiiForma();
            }

            retinereCuloare.culoare=Properties.Settings.Default.culoare;
            aplicareCuloare();
        }

        private void butonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // inchide aplicatia

        protected virtual void butonMaximizare_Click(object sender, EventArgs e)
        {
            retinereRezolutie.maximizat = 1;
            Properties.Settings.Default.Save();
            maximizare();
        } // maximizeaza fereastra aplicatiei
        protected virtual void maximizare()
        {
            WindowState = FormWindowState.Maximized;
            luareValoriRezolutii(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height,this.Width,this.Height);
            calculareRatiiForma();
            butonAjutor.Visible = false;
            butonMaximizare.Visible = false;
            butonX.Visible = false;
            butonMinimizare.Visible = false;
            baraDrag.Visible = false;
        } 

        private void butonMinimizare_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        } // minimizeaza aplicatia

        private void butonAjutor_Click(object sender, EventArgs e)
        {
            Ajutor meniuAjutor = new Ajutor();
            retinereFormaAnterioara.formaAnteriora = this;
            meniuAjutor.Show();
            Hide();
        } // deschide fereastra de ajutor
        protected void luareValoriRezolutii(int lungimeNoua, int inaltimeNoua, int lungimeVeche, int inaltimeVeche)
        {
            formaInitiala.Width = lungimeVeche;
            formaInitiala.Height = inaltimeVeche;
            formaFinala.Width = lungimeNoua;
            formaFinala.Height = inaltimeNoua;
        } // cu parametrii cand se trece de la o rezolutie la alta

        protected void calculareRatiiForma()
        {
            ratieLungimeX = (float)formaFinala.Width / formaInitiala.Width;
            ratieInaltimeY = (float)formaFinala.Height / formaInitiala.Height;
        } // ok;

        protected void calculareRatiiForma(Form formaInitiala,Form formaNoua)
        {
            ratieLungimeX = (float)formaInitiala.Width / formaNoua.Width;
            ratieInaltimeY = (float)formaInitiala.Height / formaNoua.Height;
        } // ok;

        protected void modificareElemente(Control deModificat) // ok?
        {
            controlDeModificatInitial.Width = deModificat.Size.Width;
            controlDeModificatInitial.Height = deModificat.Size.Height;
            controlDeModificatInitial.X = deModificat.Location.X;
            controlDeModificatInitial.Y = deModificat.Location.Y;
            controlDeModificatFinal.Width = (int)(controlDeModificatInitial.Width * ratieLungimeX);
            controlDeModificatFinal.Height = (int)(controlDeModificatInitial.Height * ratieInaltimeY);
            controlDeModificatFinal.X = (int)(controlDeModificatInitial.X * ratieLungimeX);
            controlDeModificatFinal.Y = (int)(controlDeModificatInitial.Y * ratieInaltimeY);
            deModificat.Size = new Size(controlDeModificatFinal.Width, controlDeModificatFinal.Height);
            deModificat.Location = new Point(controlDeModificatFinal.X, controlDeModificatFinal.Y);
        }
        protected void trecereForme(Form formaInitiala, Form formaNoua)
        {
            calculareRatiiForma(formaInitiala,formaNoua);
            formaNoua.Size = formaInitiala.Size;
            formaNoua.Location = formaInitiala.Location;
            formaNoua.Show();
            formaInitiala.Hide();
        }

        protected virtual void aplicareCuloare()
        {
            aplicareCuloare(butonAjutor);
            aplicareCuloare(butonX);
            aplicareCuloare(butonMaximizare);
            aplicareCuloare(butonMinimizare);
            aplicareCuloare(baraDrag);
        }

        protected void aplicareCuloare(Button buton)
        {
            buton.FlatAppearance.BorderColor = retinereCuloare.culoare;
            buton.ForeColor = retinereCuloare.culoare;
        } //  pt butoane cu sau fara scris in ele

        protected void aplicareCuloare(Label label)
        {
            label.ForeColor = retinereCuloare.culoare;
        } // pt label-uri

    }
    public static class retinereRezolutie
    {
        public static int inaltime;
        public static int lungime;
        public static int maximizat;
        public static int inaltimeStadard=450;
        public static int lungimeStandard = 800;
    }

    public static class retinereCuloare
    {
        public static Color culoare;
    }
}
