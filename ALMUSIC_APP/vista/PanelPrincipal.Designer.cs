namespace ALMUSIC_APP
{
    partial class PanelPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTiempoTotal = new System.Windows.Forms.Label();
            this.labelTiempoActual = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelCancion = new System.Windows.Forms.Label();
            this.labelArtista = new System.Windows.Forms.Label();
            this.trackBarSegCancion = new System.Windows.Forms.TrackBar();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btReproducir = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarBibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirDesdeURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.versionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.timerArtistas = new System.Windows.Forms.Timer(this.components);
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.timerControlSlider = new System.Windows.Forms.Timer(this.components);
            this.timerSiguienteCancion = new System.Windows.Forms.Timer(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.timerTiempoActualCancion = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Default = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.listBoxListasReproduccion = new System.Windows.Forms.ListBox();
            this.panelListaHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listArtistas = new System.Windows.Forms.ListBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegCancion)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelListaHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.labelTiempoTotal);
            this.panelHeader.Controls.Add(this.labelTiempoActual);
            this.panelHeader.Controls.Add(this.trackBar1);
            this.panelHeader.Controls.Add(this.labelCancion);
            this.panelHeader.Controls.Add(this.labelArtista);
            this.panelHeader.Controls.Add(this.trackBarSegCancion);
            this.panelHeader.Controls.Add(this.btActualizar);
            this.panelHeader.Controls.Add(this.btSiguiente);
            this.panelHeader.Controls.Add(this.btReproducir);
            this.panelHeader.Controls.Add(this.btAtras);
            this.panelHeader.Controls.Add(this.btParar);
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(963, 77);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTiempoTotal
            // 
            this.labelTiempoTotal.Location = new System.Drawing.Point(616, 49);
            this.labelTiempoTotal.Name = "labelTiempoTotal";
            this.labelTiempoTotal.Size = new System.Drawing.Size(42, 17);
            this.labelTiempoTotal.TabIndex = 13;
            this.labelTiempoTotal.Text = "0:00";
            this.labelTiempoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTiempoActual
            // 
            this.labelTiempoActual.Location = new System.Drawing.Point(259, 49);
            this.labelTiempoActual.Name = "labelTiempoActual";
            this.labelTiempoActual.Size = new System.Drawing.Size(38, 17);
            this.labelTiempoActual.TabIndex = 12;
            this.labelTiempoActual.Text = "0:00";
            this.labelTiempoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(207, 4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(26, 65);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelCancion
            // 
            this.labelCancion.Location = new System.Drawing.Point(301, 19);
            this.labelCancion.Name = "labelCancion";
            this.labelCancion.Size = new System.Drawing.Size(312, 19);
            this.labelCancion.TabIndex = 10;
            this.labelCancion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelArtista
            // 
            this.labelArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtista.Location = new System.Drawing.Point(301, 4);
            this.labelArtista.Name = "labelArtista";
            this.labelArtista.Size = new System.Drawing.Size(312, 15);
            this.labelArtista.TabIndex = 9;
            this.labelArtista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSegCancion
            // 
            this.trackBarSegCancion.AutoSize = false;
            this.trackBarSegCancion.LargeChange = 1;
            this.trackBarSegCancion.Location = new System.Drawing.Point(301, 38);
            this.trackBarSegCancion.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarSegCancion.Maximum = 1000;
            this.trackBarSegCancion.Name = "trackBarSegCancion";
            this.trackBarSegCancion.Size = new System.Drawing.Size(312, 31);
            this.trackBarSegCancion.TabIndex = 8;
            this.trackBarSegCancion.TickFrequency = 0;
            this.trackBarSegCancion.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // btActualizar
            // 
            this.btActualizar.BackgroundImage = global::ALMUSIC_APP.Properties.Resources.refresh_1;
            this.btActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btActualizar.FlatAppearance.BorderSize = 0;
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Location = new System.Drawing.Point(913, 19);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(32, 32);
            this.btActualizar.TabIndex = 7;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.BackgroundImage = global::ALMUSIC_APP.Properties.Resources.flechas_de_avance_rapido;
            this.btSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSiguiente.FlatAppearance.BorderSize = 0;
            this.btSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSiguiente.Location = new System.Drawing.Point(157, 22);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(28, 28);
            this.btSiguiente.TabIndex = 5;
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btReproducir
            // 
            this.btReproducir.BackgroundImage = global::ALMUSIC_APP.Properties.Resources.boton_de_reproduccion;
            this.btReproducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReproducir.FlatAppearance.BorderSize = 0;
            this.btReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReproducir.Location = new System.Drawing.Point(119, 22);
            this.btReproducir.Name = "btReproducir";
            this.btReproducir.Size = new System.Drawing.Size(28, 28);
            this.btReproducir.TabIndex = 4;
            this.btReproducir.UseVisualStyleBackColor = true;
            this.btReproducir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btAtras
            // 
            this.btAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btAtras.BackgroundImage = global::ALMUSIC_APP.Properties.Resources.boton_retroceder;
            this.btAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAtras.FlatAppearance.BorderSize = 0;
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Location = new System.Drawing.Point(80, 23);
            this.btAtras.Margin = new System.Windows.Forms.Padding(0);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(28, 28);
            this.btAtras.TabIndex = 3;
            this.btAtras.UseVisualStyleBackColor = false;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btParar
            // 
            this.btParar.BackgroundImage = global::ALMUSIC_APP.Properties.Resources.stop;
            this.btParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btParar.FlatAppearance.BorderSize = 0;
            this.btParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParar.Location = new System.Drawing.Point(21, 23);
            this.btParar.Margin = new System.Windows.Forms.Padding(0);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(28, 28);
            this.btParar.TabIndex = 2;
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(963, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarBibliotecaToolStripMenuItem,
            this.abrirDesdeURLToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // seleccionarBibliotecaToolStripMenuItem
            // 
            this.seleccionarBibliotecaToolStripMenuItem.Name = "seleccionarBibliotecaToolStripMenuItem";
            this.seleccionarBibliotecaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.seleccionarBibliotecaToolStripMenuItem.Text = "Seleccionar Biblioteca";
            this.seleccionarBibliotecaToolStripMenuItem.Click += new System.EventHandler(this.seleccionarBibliotecaToolStripMenuItem_Click);
            // 
            // abrirDesdeURLToolStripMenuItem
            // 
            this.abrirDesdeURLToolStripMenuItem.Name = "abrirDesdeURLToolStripMenuItem";
            this.abrirDesdeURLToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.abrirDesdeURLToolStripMenuItem.Text = "Abrir desde URL";
            this.abrirDesdeURLToolStripMenuItem.Click += new System.EventHandler(this.abrirDesdeURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.toolStripSeparator2,
            this.versionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // versionesToolStripMenuItem
            // 
            this.versionesToolStripMenuItem.Name = "versionesToolStripMenuItem";
            this.versionesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.versionesToolStripMenuItem.Text = "Versiones";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // timerArtistas
            // 
            this.timerArtistas.Tick += new System.EventHandler(this.timerArtistas_Tick);
            // 
            // imageListIconos
            // 
            this.imageListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconos.ImageStream")));
            this.imageListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconos.Images.SetKeyName(0, "boton-de-reproduccion.png");
            this.imageListIconos.Images.SetKeyName(1, "boton-retroceder.png");
            this.imageListIconos.Images.SetKeyName(2, "flechas-de-avance-rapido.png");
            this.imageListIconos.Images.SetKeyName(3, "refresh-1.png");
            this.imageListIconos.Images.SetKeyName(4, "stop.png");
            this.imageListIconos.Images.SetKeyName(5, "boton-de-pausa.png");
            // 
            // timerControlSlider
            // 
            this.timerControlSlider.Interval = 1;
            this.timerControlSlider.Tick += new System.EventHandler(this.timerControlSlider_Tick);
            // 
            // timerSiguienteCancion
            // 
            this.timerSiguienteCancion.Tick += new System.EventHandler(this.timerSiguienteCancion_Tick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "mp3.png");
            // 
            // timerTiempoActualCancion
            // 
            this.timerTiempoActualCancion.Interval = 1;
            this.timerTiempoActualCancion.Tick += new System.EventHandler(this.timerTiempoActualCancion_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.Default);
            this.panelMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 27);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(963, 42);
            this.panelMenu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "PlayLists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podcast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Default
            // 
            this.Default.AutoSize = true;
            this.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default.Location = new System.Drawing.Point(12, 7);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(79, 30);
            this.Default.TabIndex = 0;
            this.Default.Text = "Música";
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.listBoxListasReproduccion);
            this.panelContenedor.Controls.Add(this.panelHeader);
            this.panelContenedor.Controls.Add(this.panelListaHeader);
            this.panelContenedor.Controls.Add(this.pictureBoxAlbum);
            this.panelContenedor.Controls.Add(this.dataGridView1);
            this.panelContenedor.Controls.Add(this.listArtistas);
            this.panelContenedor.Location = new System.Drawing.Point(0, 66);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(963, 517);
            this.panelContenedor.TabIndex = 7;
            // 
            // listBoxListasReproduccion
            // 
            this.listBoxListasReproduccion.FormattingEnabled = true;
            this.listBoxListasReproduccion.Location = new System.Drawing.Point(732, 108);
            this.listBoxListasReproduccion.Name = "listBoxListasReproduccion";
            this.listBoxListasReproduccion.Size = new System.Drawing.Size(221, 381);
            this.listBoxListasReproduccion.TabIndex = 10;
            // 
            // panelListaHeader
            // 
            this.panelListaHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(232)))));
            this.panelListaHeader.Controls.Add(this.label3);
            this.panelListaHeader.Location = new System.Drawing.Point(732, 82);
            this.panelListaHeader.Name = "panelListaHeader";
            this.panelListaHeader.Size = new System.Drawing.Size(221, 27);
            this.panelListaHeader.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Listas de Reproducción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(4, 352);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(185, 133);
            this.pictureBoxAlbum.TabIndex = 8;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.Click += new System.EventHandler(this.pictureBoxAlbum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(196, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 403);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // listArtistas
            // 
            this.listArtistas.FormattingEnabled = true;
            this.listArtistas.Location = new System.Drawing.Point(4, 82);
            this.listArtistas.Name = "listArtistas";
            this.listArtistas.Size = new System.Drawing.Size(186, 264);
            this.listArtistas.TabIndex = 6;
            this.listArtistas.SelectedIndexChanged += new System.EventHandler(this.listArtistas_SelectedIndexChanged);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 584);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "PanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALMusic";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegCancion)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelListaHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btReproducir;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarBibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirDesdeURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem versionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Timer timerArtistas;
        private System.Windows.Forms.ImageList imageListIconos;
        private System.Windows.Forms.TrackBar trackBarSegCancion;
        private System.Windows.Forms.Label labelArtista;
        private System.Windows.Forms.Label labelCancion;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timerControlSlider;
        private System.Windows.Forms.Timer timerSiguienteCancion;
        private System.Windows.Forms.Label labelTiempoActual;
        private System.Windows.Forms.Label labelTiempoTotal;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Timer timerTiempoActualCancion;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Default;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ListBox listBoxListasReproduccion;
        private System.Windows.Forms.Panel panelListaHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listArtistas;
    }
}

