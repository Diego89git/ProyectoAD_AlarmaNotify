using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClienteProyect
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint ="ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btCerrarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRestarMenu_Click(object sender, EventArgs e)
        {
            btRestarMenu.Visible = false;
            btMaxMenu.Visible = true;            
            this.WindowState = FormWindowState.Normal;
        }

        private void btMaxMenu_Click(object sender, EventArgs e)
        {
            btMaxMenu.Visible = false;
            btRestarMenu.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btMinMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 60)
            {
                this.tmOcultarMenu.Enabled = false;

            }
            else
            {
                this.panelMenu.Width = panelMenu.Width - 20;
            }
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 220)
            {
                this.tmMostrarMenu.Enabled = false;

            }
            else
            {
                this.panelMenu.Width = panelMenu.Width + 20;
            }
        }

        private void btMenuDesp_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 220)
            {
                tmOcultarMenu.Enabled = true;
            } else if (panelMenu.Width==60){
                tmMostrarMenu.Enabled = true;
            }
        }
        private void AbrirNodoForm(object nodoForm)
        {
            if (panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls.RemoveAt(0);
            }
            Form form = nodoForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(form);
            this.panelContent.Tag = form;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirNodoForm(new NodoForm());
        }
    }
}
