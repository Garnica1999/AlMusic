using ALMUSIC_APP.controlador;
using ALMUSIC_APP.controlador.logica;
using ALMUSIC_APP.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ALMUSIC_APP.modelo;

namespace ALMUSIC_APP
{
    public class Program 
    {
        private GestionMusica gestionMusica;
        private GestionPersonas gestionPersonas;
        private GestionListas gestionListas;
        //private GestionVolumen gestionVolumen;
        private GestionVideo gestionVideo;

        private PanelURL panelURL;
        private PanelVideo panelVideo;
        private PanelMusica panelMusica;
        public Program() {
            this.solicitarPermisos();
            gestionMusica = new GestionMusica();
            gestionPersonas = new GestionPersonas();
            gestionListas = new GestionListas();
            gestionVideo = new GestionVideo();
            //gestionVolumen = new GestionVolumen();
            irAPrincipal();
            
        }

        internal void cargarInstaciaDeVideo(Object axWindowsMediaPlayer1)
        {
            //this.gestionVideo.wmp = axWindowsMediaPlayer1;
        }

        internal bool verificarListaVideos()
        {
            
            return this.gestionVideo.verificarLista();
        }

        private void solicitarPermisos()
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.AllAccess;
            try
            {
                f.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }
        }

        internal bool reproducirStreaming(string url)
        {
            this.gestionMusica.iniciarHiloStreaming(url);
            return true;
        }

        internal void agregarArtistasCargarApp()
        {
            for (int i = 0; i < this.obtenerCancionesRegistradas(); i++)
            {
                Musica m = this.gestionMusica.obtenerCancionPorID(i);
                this.gestionPersonas.agregarArtista(m.getArtista());
            }
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program p = new Program();    
        }

        private void irAPrincipal() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PanelPrincipal(this));
        }

        public bool agregarCancion(String extensionArchivoCancion, String rutaDeLaCancion, string rutaDeCarpeta) {
            Musica m = this.gestionMusica.agregarCancion(extensionArchivoCancion, rutaDeLaCancion, rutaDeCarpeta);
            return this.gestionPersonas.agregarArtista(m.getArtista());
        }

        internal void agregarVideo(string extension, string rutaCompleta, object carpeta)
        {
            Video v = this.gestionVideo.agregarVideo(extension, rutaCompleta, carpeta);
            this.gestionListas.agregar(this.gestionListas.agregarDatos(rutaCompleta, v));
        }

        public bool estaListaArtistaVacia()
        {
            return this.gestionPersonas.estaListaArtistaVacia();
        }

        public string[] obtenerTodosLosArtirtas()
        {
            return this.gestionPersonas.obtenerTodosLosArtistas();
        }

        internal string[,] agregarCancionesALista(int columnCount, int rowCount)
        {
            return this.gestionMusica.agregarCancionesALista(columnCount, rowCount);
        }

        internal int obtenerCancionesRegistradas() {
            return this.gestionMusica.obtenerCantidadDeCanciones();
        }

        internal bool listaCancionesVacia()
        {
            return this.gestionMusica.listaMusicaVacia();
        }

        internal string[] obtenerInfoCancionesPorID(int i)
        {
            return this.gestionMusica.obtenerInfoCancionesPorID(i);
        }

        internal byte[] obtenerimg() {
            return this.gestionMusica.obtenerImagenesCaratula();
        }

        internal void reproducirCancion(string ruta)
        {
            this.gestionMusica.iniciarHiloReproduccion(ruta);
        }

        internal void irAPanelURL(Form f)
        {
            panelURL = new PanelURL(this);
            panelURL.Show();
            
        }

        internal string[] obtenerDatosDeVideoPorID(int i)
        {
            return this.gestionVideo.obtenerDatosDeVideoPorID(i);
        }

        internal int obtenerCantidadDeVideosAgregadas()
        {
            return this.gestionVideo.obtenerCantidadDeVideosAgregadas();
        }

        internal bool estaHiloMusicaVivo() {
            return this.gestionMusica.estaHiloMusicaVivo();
        }

        internal double obtenerPosicionActualCancion() {
            return this.gestionMusica.obtenerSegundosActualesCancion();        
        }

        internal long obtenerSengundosTotalesCancion(string rutaID) {
            return this.gestionMusica.obtenerSegundosTotalesCancion(rutaID);
        }

        internal void reanudarCancion()
        {
            this.gestionMusica.reanudarMusica();
        }

        internal void pausarCancion()
        {
            this.gestionMusica.pausarMusica();
        }

        internal void pararCancion()
        {
            this.gestionMusica.pararCancion();
        }

        internal bool pasarSiguienteCancion() {
            return this.gestionMusica.siguiente;
        }

        internal void controlarVolumen(float volumen)
        {
            this.gestionMusica.ingresarVolumen(volumen);
        }

        internal Image obtenerImagenAlbum(string ruta)
        {
            return this.gestionMusica.obtenerImagenAlbum(ruta);
        }

        internal string obtenerTiempoActual()
        {
            return this.gestionMusica.obtenerDuracionActualCancion();
        }
        internal bool obtenerListaReproduccionPrincipal()
        {
            List<Musica> canciones = this.obtenerTodasLasCanciones();
            if (canciones.Count > 0)
            {
                return this.gestionListas.agregar(this.gestionListas.agregarDatos("Lista Principal", canciones.ElementAt(0)), canciones);

            }
            else {
                return false;
            }

        }

        internal List<Musica> obtenerTodasLasCanciones()
        {
            return this.gestionMusica.obtenerTodasLasCanciones();
        }

        internal string[] obtenerTodasLasListas()
        {
            this.obtenerListaReproduccionPrincipal();
            return this.gestionListas.obtenerTodaLaLista();
        }

        internal Form irAPanelVideo()
        {
            var form = Application.OpenForms.OfType<PanelVideo>().FirstOrDefault();
            PanelVideo hijo = form ?? new PanelVideo(this);
            return hijo;
        }

        internal Form irAPanelMusica()
        {
            var form = Application.OpenForms.OfType<PanelMusica>().FirstOrDefault();
            PanelMusica hijo = form ?? new PanelMusica(this);
            return hijo;
        }

        internal unsafe string[,] buscarCancionPorArtista(int *cantidad, String artista)
        {
            return this.gestionMusica.buscarCancionPorArtista(cantidad, artista);
        }
    }
}
