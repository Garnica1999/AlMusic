namespace ALMUSIC_APP.vista
{
    partial class PanelMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMusica));
            this.listBoxListasReproduccion = new System.Windows.Forms.ListBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTiempoTotal = new System.Windows.Forms.Label();
            this.labelTiempoActual = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelCancion = new System.Windows.Forms.Label();
            this.labelArtista = new System.Windows.Forms.Label();
            this.trackBarSegCancion = new System.Windows.Forms.TrackBar();
            this.panelListaHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listArtistas = new System.Windows.Forms.ListBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btReproducir = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.timerArtistas = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.timerControlSlider = new System.Windows.Forms.Timer(this.components);
            this.timerSiguienteCancion = new System.Windows.Forms.Timer(this.components);
            this.timerTiempoActualCancion = new System.Windows.Forms.Timer(this.components);
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegCancion)).BeginInit();
            this.panelListaHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxListasReproduccion
            // 
            this.listBoxListasReproduccion.FormattingEnabled = true;
            this.listBoxListasReproduccion.Location = new System.Drawing.Point(732, 108);
            this.listBoxListasReproduccion.Name = "listBoxListasReproduccion";
            this.listBoxListasReproduccion.Size = new System.Drawing.Size(221, 381);
            this.listBoxListasReproduccion.TabIndex = 16;
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
            this.panelHeader.Size = new System.Drawing.Size(966, 77);
            this.panelHeader.TabIndex = 11;
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
            // panelListaHeader
            // 
            this.panelListaHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(232)))));
            this.panelListaHeader.Controls.Add(this.label3);
            this.panelListaHeader.Location = new System.Drawing.Point(732, 82);
            this.panelListaHeader.Name = "panelListaHeader";
            this.panelListaHeader.Size = new System.Drawing.Size(221, 27);
            this.panelListaHeader.TabIndex = 15;
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
            this.dataGridView1.TabIndex = 13;
            // 
            // listArtistas
            // 
            this.listArtistas.FormattingEnabled = true;
            this.listArtistas.Location = new System.Drawing.Point(4, 82);
            this.listArtistas.Name = "listArtistas";
            this.listArtistas.Size = new System.Drawing.Size(186, 264);
            this.listArtistas.TabIndex = 12;
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
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(4, 352);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(185, 133);
            this.pictureBoxAlbum.TabIndex = 14;
            this.pictureBoxAlbum.TabStop = false;
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
            // 
            // timerTiempoActualCancion
            // 
            this.timerTiempoActualCancion.Interval = 1;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "mp3.png");
            // 
            // PanelMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 516);
            this.Controls.Add(this.listBoxListasReproduccion);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelListaHeader);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listArtistas);
            this.Name = "PanelMusica";
            this.Text = "PanelMusica";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegCancion)).EndInit();
            this.panelListaHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListasReproduccion;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTiempoTotal;
        private System.Windows.Forms.Label labelTiempoActual;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelCancion;
        private System.Windows.Forms.Label labelArtista;
        private System.Windows.Forms.TrackBar trackBarSegCancion;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btReproducir;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.Panel panelListaHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listArtistas;
        private System.Windows.Forms.Timer timerArtistas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageListIconos;
        private System.Windows.Forms.Timer timerControlSlider;
        private System.Windows.Forms.Timer timerSiguienteCancion;
        private System.Windows.Forms.Timer timerTiempoActualCancion;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.ImageList imageList2;
    }
}