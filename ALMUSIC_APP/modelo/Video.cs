using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class Video : Artista
    {
        private string nombreVideo;
        private string duracion;
        private string resolucion;
        private Directorio directorio;

        public Video(string nombre, string nombreVideo, string duracion, string resolucion, string rutaDeLaCarpeta) : base(nombre)
        {
            this.nombreVideo = nombreVideo;
            this.duracion = duracion;
            this.resolucion = resolucion;
            directorio = new Directorio(rutaDeLaCarpeta);
        }

        public Video(string rutaDeLaCarpeta) : base()
        {
            directorio = new Directorio(rutaDeLaCarpeta);
        }

        public string getNombreVideo() {
            return this.nombreVideo;
        }

        public string getDuracion()
        {
            return this.duracion;
        }

        public string getResolucion()
        {
            return this.resolucion;
        }

        public Directorio getDirectorio()
        {
            return this.directorio;
        }

        public void setNombreVideo(string nombreVideo)
        {
            this.nombreVideo = nombreVideo;
        }

        public void setDuracion(string duracion)
        {
            this.duracion = duracion;
        }

        public void setResolucion(string resolucion)
        {
            this.resolucion = resolucion;
        }

        public void setDirectorio(Directorio directorio)
        {
            this.directorio = directorio;
        }
    }
}
