using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALMUSIC_APP.vista
{
    public partial class PanelMusica : Form
    {
        private Program program;
        private ParameterizedThreadStart parameterizedThreadStart;
        private Thread hilo;
        private ParameterizedThreadStart ts;
        private bool musicaPausada;

        public PanelMusica(Program program)
        {
            this.program = program;
            InitializeComponent();
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8);

            timerArtistas.Start();
            agregarCancionesALista();
            cargarArtistas();
            cargarListasReproduccion();
        }


        private void cargarListasReproduccion()
        {
            string[] listas = this.program.obtenerTodasLasListas();

            foreach (string l in listas)
            {
                this.listBoxListasReproduccion.Items.Add(l);
            }

        }

        private void agregarCancionesALista()
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 6;
            dataGridView1.ColumnHeadersVisible = true;

            /* // Set the column header style.
             DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

             columnHeaderStyle.BackColor = Color.Beige;
             columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
             dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;*/

            // Set the column header names.
            dataGridView1.Columns[0].Name = "Artista";

            dataGridView1.Columns[1].Name = "Cancion";
            dataGridView1.Columns[2].Name = "Album";
            dataGridView1.Columns[3].Name = "Duracion";
            dataGridView1.Columns[4].Name = "Año";
            dataGridView1.Columns[5].Name = "Ruta";

            // Populate the rows.
            /*string[] row1 = new string[] { "Meatloaf", "Main Dish", "ground beef",
           "**" };
            string[] row2 = new string[] { "Key Lime Pie", "Dessert",
           "lime juice, evaporated milk", "****" };
            string[] row3 = new string[] { "Orange-Salsa Pork Chops", "Main Dish",
           "pork chops, salsa, orange juice", "****" };
            string[] row4 = new string[] { "Black Bean and Rice Salad", "Salad",
           "black beans, brown rice", "****" };
            string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert",
           "cream cheese", "***" };
            string[] row6 = new string[] { "Black Bean Dip", "Appetizer",
           "black beans, sour cream", "***" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };*/

            for (int i = 0; i < this.program.obtenerCancionesRegistradas(); i++)
            {
                string[] infoCanciones = this.program.obtenerInfoCancionesPorID(i);
                dataGridView1.Rows.Add(infoCanciones);
            }

            /*foreach (string[] rowArray in rows)
            {
                
            }*/

            /*Stream stream = new MemoryStream(this.program.obtenerimg());
            Icon treeIcon = new Icon(stream);
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.Image = treeIcon.ToBitmap();
            iconColumn.Name = "Tree";
            iconColumn.HeaderText = "Nice tree";
            dataGridView1.Columns.Insert(2, iconColumn);*/



        }
        /*void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Imagen")
            {
                Stream stream = new MemoryStream(this.program.obtenerimg());
                e.Value = Image.FromStream(stream);
            }
        }*/

        private void cargarArtistas()
        {
            if (this.program.listaCancionesVacia())
            {
                this.program.agregarArtistasCargarApp();
                this.agregarArtistasCargarApp();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reproducirOPausar();
        }

        private void reproducirOPausar()
        {
            if (!musicaPausada)
            {
                //SI ESTA REPRODUCIENDO, VA A PAUSAR
                pausar();
                musicaPausada = true;
                timerSiguienteCancion.Stop();
                timerControlSlider.Stop();
                this.timerTiempoActualCancion.Stop();
                this.btReproducir.BackgroundImage = this.imageListIconos.Images[5];
            }
            else
            {
                //SI ESTA EN PAUSA, VA A REPRODUCIR
                reanudar();
                musicaPausada = false;
                timerSiguienteCancion.Start();
                timerControlSlider.Start();
                this.timerTiempoActualCancion.Start();
                this.btReproducir.BackgroundImage = this.imageListIconos.Images[0];
            }
        }

        private void reanudar()
        {
            this.program.reanudarCancion();
        }

        private void pausar()
        {
            this.program.pausarCancion();
        }

        private void seleccionarBibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {

                String carpeta = folderBrowser.SelectedPath;
                //System.Console.WriteLine(carpeta);
                //MessageBox.Show(carpeta, "Alerta", MessageBoxButtons.OK);

                parameterizedThreadStart = new ParameterizedThreadStart(busquedaRecursiva);
                hilo = new Thread(parameterizedThreadStart);

                hilo.Start(carpeta);


            }
        }

        private void busquedaRecursiva(Object sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories((String)sDir))
                {

                    agregarPermisosCarpeta(d);
                    foreach (string f in Directory.GetFiles(d, "*.mp3"))
                    {

                        //System.Console.WriteLine(f);
                        asignarPermisos(d, (String)sDir, f);
                        this.program.agregarCancion(".mp3", f, (String)sDir);
                    }
                    busquedaRecursiva(d);
                }

            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private void agregarPermisosCarpeta(string d)
        {
            FileIOPermission f2 = new FileIOPermission(FileIOPermissionAccess.AllAccess, d);
            //f2.AddPathList(FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, "C:\\example\\out.txt");
            try
            {
                f2.Demand();

            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.StackTrace);
            }
        }

        private void asignarPermisos(string d, string sDir, string f)
        {
            FileIOPermission f2 = new FileIOPermission(FileIOPermissionAccess.AllAccess, d);

            FileIOPermission f3 = new FileIOPermission(FileIOPermissionAccess.AllAccess, sDir);
            f2.AddPathList(FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, f);
            try
            {
                f2.Demand();
                f3.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.StackTrace);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarArtistasALista()
        {
            listArtistas.Sorted = true;
            string[] artistas = this.program.obtenerTodosLosArtirtas();
            if (this.program.estaListaArtistaVacia())
            {
                if (!hilo.IsAlive)
                {

                    for (int i = 0; i < artistas.Length; i++)
                    {
                        listArtistas.Items.Add(artistas[i]);

                    }
                    timerArtistas.Stop();
                }
            }

        }

        private void agregarArtistasCargarApp()
        {
            listArtistas.Sorted = true;
            string[] artistas = this.program.obtenerTodosLosArtirtas();
            if (listArtistas.Items.Count <= 0)
            {
                for (int i = 0; i < artistas.Length; i++)
                {
                    listArtistas.Items.Add(artistas[i]);
                }
            }

        }

        private void timerArtistas_Tick(object sender, EventArgs e)
        {
            if (hilo != null)
                agregarArtistasALista();

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            agregarArtistasCargarApp();
            //Console.WriteLine("Hola");
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string ruta = obtenerInformacionSegunSeleccion();
            reproducirCancion(ruta);
            imprimirAlbumEnPantalla(ruta);
            this.timerTiempoActualCancion.Start();



        }



        private void imprimirTiempoCancion()
        {
            this.labelTiempoActual.Text = this.program.obtenerTiempoActual();
        }

        private void imprimirAlbumEnPantalla(string ruta)
        {
            Image im = this.program.obtenerImagenAlbum(ruta);

            if (im != null)
            {
                pictureBoxAlbum.BackgroundImage = im;
            }
            else
            {
                pictureBoxAlbum.BackgroundImage = this.imageList2.Images[0];
            }

        }

        private void reproducirCancion(string ruta)
        {

            this.program.reproducirCancion(ruta);
            musicaPausada = false;
            timerSiguienteCancion.Start();
            actualizarSliderControlMusical();
            timerControlSlider.Start();

        }

        private void actualizarSliderControlMusical()
        {
            long segundosTotalesCancion = this.program.obtenerSengundosTotalesCancion(obtenerInformacionSegunSeleccion());
            this.trackBarSegCancion.Minimum = 0;
            this.trackBarSegCancion.Maximum = Convert.ToInt32(segundosTotalesCancion);
        }

        private string obtenerInformacionSegunSeleccion()
        {

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            String ruta = "";
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    //Console.WriteLine(dataGridView1.SelectedRows[i].Index.ToString());
                    //Console.WriteLine(dataGridView1.SelectedRows[i].Cells[5].Value);
                    ruta = (String)dataGridView1.SelectedRows[i].Cells[5].Value;
                    imprimirInformacionPrincipal(i);
                }
            }

            return ruta;
        }

        private void imprimirInformacionPrincipal(int i)
        {
            labelArtista.Text = (String)dataGridView1.SelectedRows[i].Cells[0].Value;
            labelCancion.Text = (String)dataGridView1.SelectedRows[i].Cells[1].Value + "-" + (String)dataGridView1.SelectedRows[i].Cells[2].Value;
        }

        private void abrirDesdeURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.program.irAPanelURL(this);

        }

        private void timerControlSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                double segundosTranscurridos = this.program.obtenerPosicionActualCancion();
                this.trackBarSegCancion.Value = Convert.ToInt32(segundosTranscurridos);
                if (this.program.obtenerSengundosTotalesCancion(obtenerInformacionSegunSeleccion()) == this.program.obtenerPosicionActualCancion())
                {
                    this.trackBarSegCancion.Value = 0;
                    this.timerControlSlider.Stop();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }

        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            siguienteCancion();
        }

        private void siguienteCancion()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int filaSeleccionada = 0;
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    filaSeleccionada = Convert.ToInt32(dataGridView1.SelectedRows[i].Index.ToString());
                }
            }
            this.dataGridView1.CurrentCell = this.dataGridView1[1, filaSeleccionada + 1];
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            anteriorCancion();
        }

        private void anteriorCancion()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int filaSeleccionada = 0;
            if (selectedRowCount > 0)
            {

                for (int i = 0; i < selectedRowCount; i++)
                {
                    filaSeleccionada = Convert.ToInt32(dataGridView1.SelectedRows[i].Index.ToString());
                }
            }
            this.dataGridView1.CurrentCell = this.dataGridView1[1, filaSeleccionada - 1];
        }

        private void btParar_Click(object sender, EventArgs e)
        {
            pararCancion();
        }

        private void pararCancion()
        {
            this.program.pararCancion();
            timerSiguienteCancion.Stop();
            timerControlSlider.Stop();
            this.timerTiempoActualCancion.Stop();
            this.labelTiempoActual.Text = "0:00";
        }

        private void timerSiguienteCancion_Tick(object sender, EventArgs e)
        {
            pasarSiguienteCancion();
        }

        private void pasarSiguienteCancion()
        {
            if (this.program.pasarSiguienteCancion())
            {
                siguienteCancion();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int volumen = this.trackBar1.Value;
            this.program.controlarVolumen(volumen);
        }


        private void timerTiempoActualCancion_Tick(object sender, EventArgs e)
        {
            this.imprimirTiempoCancion();
        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {

        }

        private void Default_Click(object sender, EventArgs e)
        {

        }
    }
}
