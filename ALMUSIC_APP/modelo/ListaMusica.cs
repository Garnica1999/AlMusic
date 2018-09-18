using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class ListaMusica : ListaReproduccion
    {
        private Musica cancion;
        private List<Musica> cancionesEnLista;
        
        public ListaMusica(string nombre, Musica musica) : base(nombre)
        {
            this.cancion = musica;
            base.setCantidad(0);
            cancionesEnLista = new List<Musica>();
        }

        public ListaMusica(string nombre) : base(nombre)
        {
            base.setCantidad(0);
            cancionesEnLista = new List<Musica>();
        }

        public void setCancion(Musica cancion)
        {
            this.cancion = cancion;
        }

        public void setCancionesEnLista(List<Musica> cancionesEnLista)
        {
            this.cancionesEnLista = cancionesEnLista;
        }

        public Musica getCancion() {
            return this.cancion;
        }

        public List<Musica> getCancionesEnLista() {
            return this.cancionesEnLista;
        }
    }
}
