using ALMUSIC_APP.controlador.persistencia;
using ALMUSIC_APP.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.controlador.logica
{
    public class GestionVideo
    {
        private List<Video> videos;
        //internal AxWMPLib.AxWindowsMediaPlayer wmp { get; set; }
        private Video video;
        private VideoArchivo videoArchivo;

        public GestionVideo()
        {
            
            videos = new List<Video>();
            videoArchivo = new VideoArchivo("videos.bin");
            cargarDatos();
        }

        private void cargarDatos()
        {
            videos = videoArchivo.obtenerTodosLosDatos();
        }

        internal bool verificarLista()
        {
            if(videos.Count == 0)
            {
                return true;
            }
            return false;
        }

        internal Video agregarVideo(string extension, string rutaCompleta, object carpeta)
        {
            video = new Video(rutaCompleta);
            extraerInformacion(rutaCompleta);
            videos.Add(video);
            videoArchivo.ingresarDato(video);
            return video;
        }

        private void extraerInformacion(string rutaCompleta)
        {
            /*wmp.URL = rutaCompleta;
            String resolucion = wmp.currentMedia.imageSourceWidth + "x" + wmp.currentMedia.imageSourceHeight + "";
            String nombre = wmp.Ctlcontrols.currentItem.name;
            String duracion = Convert.ToInt32(wmp.Ctlcontrols.currentItem.duration) + "";

            video.setResolucion(resolucion);
            video.setNombreVideo(nombre);
            video.setDuracion(duracion);*/
        }

        internal int obtenerCantidadDeVideosAgregadas()
        {
            return this.videos.Count;
        }

        internal string[] obtenerDatosDeVideoPorID(int i)
        {
            string[] datos = new string[4];
            datos[0] = this.videos.ElementAt(i).getNombreVideo();
            datos[1] = this.videos.ElementAt(i).getDuracion();
            datos[2] = this.videos.ElementAt(i).getResolucion();
            datos[3] = this.videos.ElementAt(i).getDirectorio().getRutaDeCarpeta();

            return datos;
        }
    }
}
