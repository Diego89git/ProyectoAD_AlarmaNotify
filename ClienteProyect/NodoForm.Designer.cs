
namespace ClienteProyect
{
    partial class NodoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btDeleteNodo = new System.Windows.Forms.Button();
            this.btEditNodo = new System.Windows.Forms.Button();
            this.btAddNodo = new System.Windows.Forms.Button();
            this.dataGridViewNodos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btSeleccionarLtLn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txLongitud = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txLatitud = new System.Windows.Forms.TextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTipoId = new System.Windows.Forms.ComboBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNodos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 50);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NODOS / USUARIOS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 461);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btDeleteNodo);
            this.tabPage1.Controls.Add(this.btEditNodo);
            this.tabPage1.Controls.Add(this.btAddNodo);
            this.tabPage1.Controls.Add(this.dataGridViewNodos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Nodos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btDeleteNodo
            // 
            this.btDeleteNodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteNodo.BackColor = System.Drawing.Color.Crimson;
            this.btDeleteNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteNodo.ForeColor = System.Drawing.Color.White;
            this.btDeleteNodo.Image = global::ClienteProyect.Properties.Resources.delete;
            this.btDeleteNodo.Location = new System.Drawing.Point(764, 93);
            this.btDeleteNodo.Name = "btDeleteNodo";
            this.btDeleteNodo.Size = new System.Drawing.Size(105, 38);
            this.btDeleteNodo.TabIndex = 3;
            this.btDeleteNodo.Text = "Eliminar";
            this.btDeleteNodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDeleteNodo.UseVisualStyleBackColor = false;
            this.btDeleteNodo.Click += new System.EventHandler(this.btDeleteNodo_Click);
            // 
            // btEditNodo
            // 
            this.btEditNodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditNodo.BackColor = System.Drawing.Color.OrangeRed;
            this.btEditNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditNodo.ForeColor = System.Drawing.Color.White;
            this.btEditNodo.Image = global::ClienteProyect.Properties.Resources.edit;
            this.btEditNodo.Location = new System.Drawing.Point(764, 49);
            this.btEditNodo.Name = "btEditNodo";
            this.btEditNodo.Size = new System.Drawing.Size(105, 38);
            this.btEditNodo.TabIndex = 2;
            this.btEditNodo.Text = "Editar";
            this.btEditNodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditNodo.UseVisualStyleBackColor = false;
            this.btEditNodo.Click += new System.EventHandler(this.btEditNodo_Click);
            // 
            // btAddNodo
            // 
            this.btAddNodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNodo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAddNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNodo.ForeColor = System.Drawing.Color.White;
            this.btAddNodo.Image = global::ClienteProyect.Properties.Resources._new;
            this.btAddNodo.Location = new System.Drawing.Point(763, 9);
            this.btAddNodo.Name = "btAddNodo";
            this.btAddNodo.Size = new System.Drawing.Size(105, 34);
            this.btAddNodo.TabIndex = 1;
            this.btAddNodo.Text = "Añadir";
            this.btAddNodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddNodo.UseVisualStyleBackColor = false;
            this.btAddNodo.Click += new System.EventHandler(this.btAddNodo_Click);
            // 
            // dataGridViewNodos
            // 
            this.dataGridViewNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNodos.Location = new System.Drawing.Point(12, 9);
            this.dataGridViewNodos.Name = "dataGridViewNodos";
            this.dataGridViewNodos.Size = new System.Drawing.Size(744, 399);
            this.dataGridViewNodos.TabIndex = 0;
            this.dataGridViewNodos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNodos_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Guardar Nodo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Blue;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Image = global::ClienteProyect.Properties.Resources.check;
            this.btGuardar.Location = new System.Drawing.Point(401, 392);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(136, 35);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::ClienteProyect.Properties.Resources.back;
            this.btnCancelar.Location = new System.Drawing.Point(272, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btSeleccionarLtLn);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txLongitud);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txLatitud);
            this.panel4.Controls.Add(this.gMapControl1);
            this.panel4.Controls.Add(this.txtDireccion);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(401, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 382);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(150, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Datos de Localización";
            // 
            // btSeleccionarLtLn
            // 
            this.btSeleccionarLtLn.Location = new System.Drawing.Point(194, 288);
            this.btSeleccionarLtLn.Name = "btSeleccionarLtLn";
            this.btSeleccionarLtLn.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionarLtLn.TabIndex = 13;
            this.btSeleccionarLtLn.Text = "Seleccionar";
            this.btSeleccionarLtLn.UseVisualStyleBackColor = true;
            this.btSeleccionarLtLn.Click += new System.EventHandler(this.btSeleccionarLtLn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Latitud";
            // 
            // txLongitud
            // 
            this.txLongitud.Location = new System.Drawing.Point(239, 348);
            this.txLongitud.Name = "txLongitud";
            this.txLongitud.Size = new System.Drawing.Size(198, 20);
            this.txLongitud.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Latitud";
            // 
            // txLatitud
            // 
            this.txLatitud.Location = new System.Drawing.Point(35, 348);
            this.txLatitud.Name = "txLatitud";
            this.txLatitud.Size = new System.Drawing.Size(198, 20);
            this.txLatitud.TabIndex = 10;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(21, 91);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(425, 191);
            this.gMapControl1.TabIndex = 10;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 59);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(425, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Dirección [Referencia de Ubicación]";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCelular);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtRepresentante);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Location = new System.Drawing.Point(6, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 185);
            this.panel3.TabIndex = 7;
            this.panel3.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(7, 52);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(198, 20);
            this.txtCelular.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Datos de Contacto";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.Location = new System.Drawing.Point(7, 156);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(198, 20);
            this.txtRepresentante.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Representante";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(7, 101);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(198, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPassConfirm);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBoxTipoId);
            this.panel2.Controls.Add(this.txtRazonSocial);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNumeroId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 191);
            this.panel2.TabIndex = 6;
            this.panel2.Tag = "";
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(226, 106);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(152, 20);
            this.txtPassConfirm.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Confirmar Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(226, 59);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(152, 20);
            this.txtPass.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Datos de Identificación";
            // 
            // comboBoxTipoId
            // 
            this.comboBoxTipoId.FormattingEnabled = true;
            this.comboBoxTipoId.Items.AddRange(new object[] {
            "RUC",
            "CEDULA",
            "PASAPORTE"});
            this.comboBoxTipoId.Location = new System.Drawing.Point(7, 58);
            this.comboBoxTipoId.Name = "comboBoxTipoId";
            this.comboBoxTipoId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoId.TabIndex = 3;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(7, 157);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(371, 20);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Identificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre[Razon Social]";
            // 
            // txtNumeroId
            // 
            this.txtNumeroId.Location = new System.Drawing.Point(7, 106);
            this.txtNumeroId.Name = "txtNumeroId";
            this.txtNumeroId.Size = new System.Drawing.Size(198, 20);
            this.txtNumeroId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero de Identificaciòn";
            // 
            // NodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NodoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NodoForm";
            this.Load += new System.EventHandler(this.NodoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNodos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btDeleteNodo;
        private System.Windows.Forms.Button btEditNodo;
        private System.Windows.Forms.Button btAddNodo;
        private System.Windows.Forms.DataGridView dataGridViewNodos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTipoId;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txLongitud;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txLatitud;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btSeleccionarLtLn;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label13;
    }
}