using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using EntidadesProyect;
using System.Net;
using System.IO;

namespace ClienteProyect
{
    public partial class loggin : Form
    {
        NodoEntidad nodoEntidad = new NodoEntidad();
        public loggin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if ( txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Gray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                acceder();
                if (nodoEntidad.Id!=0)
                {
                    if (nodoEntidad.Id == -1)
                    {
                        MessageBox.Show("Usuario no registrado", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (nodoEntidad.Id == -2)
                    {
                        MessageBox.Show("Clave Incorrecta", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Error de Acceso", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Ingreso Exitoso", "Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu formMenu = new Menu();
                formMenu.Visible = true;
                formMenu.Show();
            }
           
        }

        private bool validarCampos()
        {
            var user = txtUsuario.Text;
            var pass = txtPass.Text;
            if (user.Equals("") || user.Equals("USUARIO"))
            {
                MessageBox.Show("No se ha registrado un usuario", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pass.Equals("") || pass.Equals("CONTRASEÑA"))
            {
                MessageBox.Show("No se ha registrado una contraseña", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void acceder()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var user = txtUsuario.Text;
            var pass = txtPass.Text;
            var url = $"http://localhost:9092/API/Loggin/?user=" + user+"&pass="+pass;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return ;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            nodoEntidad = JsonConvert.DeserializeObject<NodoEntidad>(responseBody);

                        }
                    }
                }


            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
