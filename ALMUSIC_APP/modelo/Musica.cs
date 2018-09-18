using ALMUSIC_APP.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP
{
    [Serializable]
    public class Musica : Caratula
    {
        private String extensionCancion;
        private String artistaCancion;
        private String anioPublicacion;
        private String extensionArchivoCancion;
        private String rutaDeLaCancion;
        private String album;
        private String artista;
        private String titulo;
        private String genero;
        private int BMP;
        private long duracionCancion;

        public Musica(String extensionArchivoCancion, String rutaDeLaCancion, string rutaDeCarpeta) : base (rutaDeCarpeta)
        {
            this.extensionArchivoCancion = extensionArchivoCancion;
            this.rutaDeLaCancion = rutaDeLaCancion;
        }

        public String getExtensionCancion()
        {
            return extensionCancion;
        }

        public void setExtensionCancion(String extensionCancion)
        {
            this.extensionCancion = extensionCancion;
        }

        public String getArtistaCancion()
        {
            return artistaCancion;
        }

        public void setArtistaCancion(String artistaCancion)
        {
            this.artistaCancion = artistaCancion;
        }

        public String getAnioPublicacion()
        {
            return anioPublicacion;
        }

        public void setAnioPublicacion(String anioPublicacion)
        {
            this.anioPublicacion = anioPublicacion;
        }

        public String getNombreArchivoCancion()
        {
            return extensionArchivoCancion;
        }

        public void setNombreArchivoCancion(String nombreArchivoCancion)
        {
            this.extensionArchivoCancion = nombreArchivoCancion;
        }

        public String getRutaDeLaCancion()
        {
            return rutaDeLaCancion;
        }

        public void setRutaDeLaCancion(String rutaDeLaCancion)
        {
            this.rutaDeLaCancion = rutaDeLaCancion;
        }

        public String getAlbum()
        {
            return album;
        }

        public void setAlbum(String album)
        {
            this.album = album;
        }

        public String getArtista()
        {
            return artista;
        }

        public void setArtista(String artista)
        {
            this.artista = artista;
        }

        public String getTitulo()
        {
            return titulo;
        }

        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public String getGenero()
        {
            return genero;
        }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }

        public int getBMP()
        {
            return BMP;
        }

        public void setBMP(int BMP)
        {
            this.BMP = BMP;
        }

        public long getDuracionCancion()
        {
            return duracionCancion;
        }

        public void setDuracionCancion(long duracionCancion)
        {
            this.duracionCancion = duracionCancion;
        }
    }
}
