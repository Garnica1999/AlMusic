namespace ALMUSIC_APP.vista
{
    partial class PanelVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelVideo));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folderVideo = new System.Windows.Forms.FolderBrowserDialog();
            this.timerAñadirVideos = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegCancion)).BeginInit();
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
            this.panelHeader.Location = new System.Drawing.Point(0, 440);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(972, 76);
            this.panelHeader.TabIndex = 1;
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
            this.trackBar1.Location = new System.Drawing.Point(210, 4);
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
            this.labelArtista.Location = new System.Drawing.Point(286, 4);
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
            this.btActualizar.Location = new System.Drawing.Point(925, 18);
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
            this.btSiguiente.Location = new System.Drawing.Point(161, 24);
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
            this.btReproducir.Location = new System.Drawing.Point(122, 24);
            this.btReproducir.Name = "btReproducir";
            this.btReproducir.Size = new System.Drawing.Size(28, 28);
            this.btReproducir.TabIndex = 4;
            this.btReproducir.UseVisualStyleBackColor = true;
            this.btReproducir.Click += new System.EventHandler(this.btReproducir_Click);
            // 
            // btAtras
            // 
            this.btAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btAtras.BackgroundImage = global::ALMUSIC_APP.Properties.Resources.boton_retroceder;
            this.btAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAtras.FlatAppearance.BorderSize = 0;
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Location = new System.Drawing.Point(83, 25);
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
            this.btParar.Location = new System.Drawing.Point(24, 25);
            this.btParar.Margin = new System.Windows.Forms.Padding(0);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(28, 28);
            this.btParar.TabIndex = 2;
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(680, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 432);
            this.dataGridView1.TabIndex = 3;

            // 
            // timerAñadirVideos
            // 
            this.timerAñadirVideos.Tick += new System.EventHandler(this.timerAñadirVideos_Tick);
            // 
            // PanelVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelHeader);
            this.Name = "PanelVideo";
            this.Text = "PanelVideo";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegCancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FolderBrowserDialog folderVideo;
        private System.Windows.Forms.Timer timerAñadirVideos;
    }
}