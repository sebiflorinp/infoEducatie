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
        public templateMeniuPrincipal()
        {
            InitializeComponent();
        }

        private void butonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butonMaximizare_Click(object sender, EventArgs e)
        {
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
    }
}
