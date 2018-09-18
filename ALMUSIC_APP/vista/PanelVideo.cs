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
    
    public partial class PanelVideo : Form
    {
        private Program program;
        private Thread hilo;
        public PanelVideo(Program program)
        {
            this.program = program;
            InitializeComponent();

            
            cargarInstaciaDeVideo();
            cargarListaVideos();
            //this.axWindowsMediaPlayer1.uiMode = "none";
            //this.axWindowsMediaPlayer1.URL = "H:\\Videos\\Chistecitos de Dross.mp4";
            //this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void cargarInstaciaDeVideo()
        {
            //this.program.cargarInstaciaDeVideo(this.axWindowsMediaPlayer1);
        }

        private void cargarListaVideos()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Nombre Video";
            dataGridView1.Columns[1].Name = "Duración";
            dataGridView1.Columns[2].Name = "Resolución";
            dataGridView1.Columns[3].Name = "Directorio";
            if (!this.program.verificarListaVideos())
            {
                this.añadirVideosALista();
            } else
            {
                DialogResult resultado = MessageBox.Show("No se ha encontrado la biblioteca principal de Videos. \n¿Desea Agregarla ahora?", "Gestion de Videos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resultado == DialogResult.Yes)
                {
                    if(this.folderVideo.ShowDialog() == DialogResult.OK)
                    {
                        this.timerAñadirVideos.Start();
                        String carpeta = folderVideo.SelectedPath;
                        hilo = new Thread(new ParameterizedThreadStart(buscarCarpetas));
                        hilo.Start(carpeta);

                    }
                }
            }
            
        }

        private void buscarCarpetas(Object sDir)
        {
            try
            {
                
                foreach (string d in Directory.GetDirectories((String)sDir))
                {

                    agregarPermisosCarpeta(d);
                    foreach (string f in Directory.GetFiles(d, "*.mp4"))
                    {

                        System.Console.WriteLine(f);
                        asignarPermisos(d, (String)sDir, f);
                        this.program.agregarVideo(".mp4", f, (String)sDir);
                    }
                    buscarCarpetas(d);
                }

                foreach (string f in Directory.GetFiles((String)sDir, "*.mp4"))
                {

                    System.Console.WriteLine(f);

                    this.program.agregarVideo(".mp4", f, (String)sDir);
                }
            }

            
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
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

        private void timerAñadirVideos_Tick(object sender, EventArgs e)
        {
            añadirVideosALista();
        }

        private void añadirVideosALista()
        {
            if (hilo != null) {
                if (!hilo.IsAlive)
                {
                    for (int i = 0; i < this.program.obtenerCantidadDeVideosAgregadas(); i++)
                    {
                        string[] datos = this.program.obtenerDatosDeVideoPorID(i);
                        this.dataGridView1.Rows.Add(datos);
                    }

                    this.timerAñadirVideos.Stop();
                }
            }
            
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btReproducir_Click(object sender, EventArgs e)
        {

        }

        private void btAtras_Click(object sender, EventArgs e)
        {

        }

        private void btParar_Click(object sender, EventArgs e)
        {

        }
    }
}
