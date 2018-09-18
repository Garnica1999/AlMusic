using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class ListaVideo : ListaReproduccion
    {

        private Video video;
        private List<Video> videos;

        public ListaVideo(string nombre, Video video) : base(nombre)
        {
            
            this.video = video;
            base.setCantidad(0);
            videos = new List<Video>();
        }

        public ListaVideo(string nombre) : base(nombre)
        {
            base.setCantidad(0);
            videos = new List<Video>();
        }

        public void setVideo(Video video)
        {
            this.video = video;
        }

        public void setVideos(List<Video> videos)
        {
            this.videos = videos;
        }

        public Video getVideo() {
            return this.video;
        }

        public List<Video> getVideos() {
            return this.videos;
        }
    }
}
