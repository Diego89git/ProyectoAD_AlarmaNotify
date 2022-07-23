
namespace ClienteProyect
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btRestarMenu = new System.Windows.Forms.PictureBox();
            this.btMinMenu = new System.Windows.Forms.PictureBox();
            this.btMaxMenu = new System.Windows.Forms.PictureBox();
            this.btCerrarMenu = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMenuDesp = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRestarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenuDesp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.OrangeRed;
            this.panelTop.Controls.Add(this.btRestarMenu);
            this.panelTop.Controls.Add(this.btMinMenu);
            this.panelTop.Controls.Add(this.btMaxMenu);
            this.panelTop.Controls.Add(this.btCerrarMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 40);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btRestarMenu
            // 
            this.btRestarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestarMenu.Image = global::ClienteProyect.Properties.Resources.restaurar;
            this.btRestarMenu.Location = new System.Drawing.Point(1025, 3);
            this.btRestarMenu.Name = "btRestarMenu";
            this.btRestarMenu.Size = new System.Drawing.Size(40, 31);
            this.btRestarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btRestarMenu.TabIndex = 3;
            this.btRestarMenu.TabStop = false;
            this.btRestarMenu.Visible = false;
            this.btRestarMenu.Click += new System.EventHandler(this.btRestarMenu_Click);
            // 
            // btMinMenu
            // 
            this.btMinMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMinMenu.Image = global::ClienteProyect.Properties.Resources.minimizar;
            this.btMinMenu.Location = new System.Drawing.Point(978, 24);
            this.btMinMenu.Name = "btMinMenu";
            this.btMinMenu.Size = new System.Drawing.Size(44, 10);
            this.btMinMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btMinMenu.TabIndex = 2;
            this.btMinMenu.TabStop = false;
            this.btMinMenu.Click += new System.EventHandler(this.btMinMenu_Click);
            // 
            // btMaxMenu
            // 
            this.btMaxMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaxMenu.Image = global::ClienteProyect.Properties.Resources.maximizar;
            this.btMaxMenu.Location = new System.Drawing.Point(1030, 3);
            this.btMaxMenu.Name = "btMaxMenu";
            this.btMaxMenu.Size = new System.Drawing.Size(35, 31);
            this.btMaxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMaxMenu.TabIndex = 1;
            this.btMaxMenu.TabStop = false;
            this.btMaxMenu.Click += new System.EventHandler(this.btMaxMenu_Click);
            // 
            // btCerrarMenu
            // 
            this.btCerrarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrarMenu.Image = global::ClienteProyect.Properties.Resources.systemlogout_103399;
            this.btCerrarMenu.Location = new System.Drawing.Point(1069, 3);
            this.btCerrarMenu.Name = "btCerrarMenu";
            this.btCerrarMenu.Size = new System.Drawing.Size(28, 31);
            this.btCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btCerrarMenu.TabIndex = 0;
            this.btCerrarMenu.TabStop = false;
            this.btCerrarMenu.Click += new System.EventHandler(this.btCerrarMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btMenuDesp);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 540);
            this.panelMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "SISTEMA DE \r\nALARMA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(0, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 50);
            this.panel4.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::ClienteProyect.Properties.Resources.reportes;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(5, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "  Reporte Incidentes";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(0, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 50);
            this.panel3.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::ClienteProyect.Properties.Resources.historial;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(5, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = " Historial Notificaciones";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OrangeRed;
            this.panel5.Location = new System.Drawing.Point(0, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 50);
            this.panel5.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 50);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ClienteProyect.Properties.Resources.nodosNew;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(5, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "  Nodos/Usuarios";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 50);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(5, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "  Dashboard";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::ClienteProyect.Properties.Resources.alarma;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btMenuDesp
            // 
            this.btMenuDesp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMenuDesp.BackColor = System.Drawing.Color.Black;
            this.btMenuDesp.Image = global::ClienteProyect.Properties.Resources.iconMenu1;
            this.btMenuDesp.Location = new System.Drawing.Point(173, 3);
            this.btMenuDesp.Name = "btMenuDesp";
            this.btMenuDesp.Size = new System.Drawing.Size(44, 38);
            this.btMenuDesp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMenuDesp.TabIndex = 0;
            this.btMenuDesp.TabStop = false;
            this.btMenuDesp.Click += new System.EventHandler(this.btMenuDesp_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(880, 540);
            this.panelContent.TabIndex = 2;
            // 
            // tmOcultarMenu
            // 
            this.tmOcultarMenu.Interval = 5;
            this.tmOcultarMenu.Tick += new System.EventHandler(this.tmOcultarMenu_Tick);
            // 
            // tmMostrarMenu
            // 
            this.tmMostrarMenu.Interval = 5;
            this.tmMostrarMenu.Tick += new System.EventHandler(this.tmMostrarMenu_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 5);
            this.panel6.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btRestarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenuDesp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btCerrarMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox btMaxMenu;
        private System.Windows.Forms.PictureBox btMinMenu;
        private System.Windows.Forms.PictureBox btRestarMenu;
        private System.Windows.Forms.PictureBox btMenuDesp;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Timer tmMostrarMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
    }
}