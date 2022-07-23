using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using EntidadesProyect;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace ClienteProyect
{
    public partial class NodoForm : Form
    {
        GMarkerGoogle marker;
        GMapOverlay mapOverlay;


        double LatInicial = -1.2204448674389083;
        double LngInicial = -78.58131741764485;

        NodoEntidad nodoEntidad = new NodoEntidad();

        public NodoForm()
        {
            InitializeComponent();
            

        }

        private void NodoForm_Load(object sender, EventArgs e)
        {
            CargarValoresIniciales();
            // Console.WriteLine("Si entro en codigo load");
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            mapOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
            mapOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}",LatInicial, LngInicial);

            gMapControl1.Overlays.Add(mapOverlay);

        }

        private void CargarValoresIniciales()
        {
            CargarListadoNodosDataGrid();
        
            tabPage2.Parent = null;
            btEditNodo.Enabled = false;
            btDeleteNodo.Enabled = false;
            //Console.WriteLine("Si entro en codigo iniciales");
        }

        private void CargarListadoNodosDataGrid()
        {
            //GetNodosAsync();
            GetItems();
            Console.WriteLine("Entro a CargarListaNodos");
        }
        
        private async Task GetNodosAsync()
        {
           
            try
            {
                Console.WriteLine("Entro a GetNodos");
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:9092");
                
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent","Awesome-Octocat-App");
                HttpResponseMessage response = await client.GetAsync("http://localhost:9092/API/nodo");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Entro a issacces");
                    var json = await response.Content.ReadAsStringAsync();
                     var nodo=   JsonConvert.DeserializeObject<NodoEntidad>(json);
                    Console.WriteLine(nodo.RazonSocial);
                }
                else
                {
                    Console.WriteLine("Entro a nosacces"+response.ToString());
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Hubo algun error"+ex.Message.ToString());
            }
        }
        private void GetItems()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


            var url = $"http://localhost:9092/API/nodo";
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
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                           // Console.WriteLine(responseBody);
                            var nodo = JsonConvert.DeserializeObject<List<NodoEntidad>>(responseBody);
                            this.dataGridViewNodos.DataSource = nodo;
                            this.dataGridViewNodos.Columns["Id"].Visible = false;
                            this.dataGridViewNodos.Columns["Password"].Visible = false;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSeleccionarLtLn_Click(object sender, EventArgs e)
        {
            txLatitud.Text = gMapControl1.Position.Lat.ToString();
            txLongitud.Text = gMapControl1.Position.Lng.ToString();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            //double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txLatitud.Text = lat.ToString();
            txLongitud.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", lat, lng);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPage2.Parent = null;
            tabPage1.Parent = tabControl1;
        }

        private void btAddNodo_Click(object sender, EventArgs e)
        {
            tabPage1.Parent = null;
            limpiarForm();
            tabPage2.Parent = tabControl1;
            btEditNodo.Enabled = false;
            btDeleteNodo.Enabled = false;
        }

        private void dataGridViewNodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewNodos.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            cargarNodoPorId(id);
            btEditNodo.Enabled = true;
            btDeleteNodo.Enabled = true;
        }

        private void cargarNodoPorId(int id)
        {
            getNodoPorId(id);
            comboBoxTipoId.Text = nodoEntidad.TipoIdentificacion;
            txtNumeroId.Text = nodoEntidad.NumeroIdentificacion;
            txtRazonSocial.Text = nodoEntidad.RazonSocial;
            txtRepresentante.Text = nodoEntidad.Representante;
            txtDireccion.Text = nodoEntidad.Direccion;
            txtTelefono.Text = nodoEntidad.Telefono;
            txtCelular.Text = nodoEntidad.Celular;
            txtPass.Text = nodoEntidad.Password;
            txtPassConfirm.Text = nodoEntidad.Password;
            txLatitud.Text = nodoEntidad.Latitud.ToString();
            txLongitud.Text = nodoEntidad.Longitud.ToString();


            marker.Position = new PointLatLng(Convert.ToDouble(nodoEntidad.Latitud), Convert.ToDouble(nodoEntidad.Longitud));
            marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", Convert.ToDouble(nodoEntidad.Latitud), Convert.ToDouble(nodoEntidad.Longitud));
        }
        private void limpiarForm()
        {
           
            comboBoxTipoId.Text = "";
            txtNumeroId.Text = "";
            txtRazonSocial.Text = "";
            txtRepresentante.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtPass.Text = "";
            txtPassConfirm.Text = "";
            txLatitud.Text = "";
            txLongitud.Text = "";
            nodoEntidad.Id = 0;
        }

        private void getNodoPorId(int id)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = $"http://localhost:9092/API/nodo/"+id;
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
                        if (strReader == null) return;
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

        private void btEditNodo_Click(object sender, EventArgs e)
        {
            tabPage1.Parent = null;
            tabPage2.Parent = tabControl1;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            GuardarNodo();
            CargarListadoNodosDataGrid();
            tabPage1.Parent = tabControl1;
            tabPage2.Parent = null;
        }

        private void GuardarNodo()
        {
            nodoEntidad.TipoIdentificacion = comboBoxTipoId.Text;
            nodoEntidad.NumeroIdentificacion = txtNumeroId.Text;
            nodoEntidad.RazonSocial = txtRazonSocial.Text;
            nodoEntidad.Representante = txtRepresentante.Text;
            nodoEntidad.Direccion = txtDireccion.Text;
            nodoEntidad.Telefono = txtTelefono.Text;
            nodoEntidad.Celular = txtCelular.Text;
            nodoEntidad.Password = txtPass.Text;
            nodoEntidad.Latitud = Convert.ToDecimal(txLatitud.Text);
            nodoEntidad.Longitud = Convert.ToDecimal(txLongitud.Text);

           insertNodo(nodoEntidad);
            if (nodoEntidad!=null)
            {
                MessageBox.Show("Los datos se guardaron satisfactoriamente");
            }

        }

        private void insertNodo(NodoEntidad nodoEntidad)
        {
            
            var jsonStringResult = JsonConvert.SerializeObject(nodoEntidad);
            var jsondepura = Uri.UnescapeDataString(jsonStringResult);
            var url = $"http://localhost:9092/API/nodo";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsondepura);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) {nodoEntidad = null; return; }
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
                nodoEntidad = null;
            }
        }

        private void btDeleteNodo_Click(object sender, EventArgs e)
        {
            EliminarNodo();
        }

        private void EliminarNodo()
        {
            if (MessageBox.Show("Está UD seguro de eliminar el registro?", "Eliminar",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (DeleteNodo(nodoEntidad.Id))
                {
                    MessageBox.Show("El registro se eliminó Satisfactoriamente", "Mensaje",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListadoNodosDataGrid();
                    btEditNodo.Enabled = false;
                    btDeleteNodo.Enabled = false;
                }
            }
        }

        private  bool DeleteNodo(int Id)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = $"http://localhost:9092/API/nodo/" + Id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                        }
                    }
                }
                return true;
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }
        }

    }

   
}
