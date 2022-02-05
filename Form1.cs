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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butonMaximizare_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void butonMinimizare_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)   
                this.Close();
        }

        private void butonAjutor_Click(object sender, EventArgs e)
        {
            Ajutor meniuAjutor = new Ajutor();
            meniuAjutor.Show();
            meniuAjutor.Focus();
            
            butonAjutor.Click-=butonAjutor_Click;
        }

        private void butonOptiuni_Click(object sender, EventArgs e)
        {
            Iesire.Visible = false;
            butonOptiuni.Visible = false;
        }
    }
}
