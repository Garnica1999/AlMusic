using ALMUSIC_APP.modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.controlador.logica
{
    public class GestionListas : IGestionAgregar<ListaMusica, ListaVideo, ListaReproduccion,Musica, Video>
    {
        private List<ListaReproduccion> listas;

        public GestionListas()
        {
            listas = new List<ListaReproduccion>();
        }

        public bool agregar(ListaReproduccion obj)
        {
            if (obj != null)
            {
                listas.Add(obj);
                return true;
            }
            else {
                return false;
            }
            
        }

        public bool agregar(ListaReproduccion obj, List<Musica> canciones)
        {
            if (obj != null)
            {
                if(obj is ListaMusica)
                {
                    var ls = (ListaMusica)obj;
                    ls.setCancionesEnLista(canciones);
                }
                listas.Add(obj);
                return true;
            }
            else {
                return false;
            }
        }

        public ListaReproduccion agregarDatos(string nombre, Video video)
        {
            return new ListaVideo(nombre);
        }

        public ListaReproduccion agregarDatos(string nombre, Musica musica)
        {
            return new ListaMusica(nombre);
        }

        public bool eliminar(ListaReproduccion obj)
        {
            return listas.Remove(obj);
        }

        public bool eliminar(string nombreActual)
        {
            for (int i = 0 ; i < listas.Count;i++ ){
                if (nombreActual.Equals(this.listas.ElementAt(i).getNombre()))
                {
                    return this.listas.Remove(this.listas.ElementAt(i));
                }
            }
            return false;
        }
        public bool modificar(string nombreActual, string nombreNuevo)
        {
            if (verificarExistencia(nombreActual))
            {
                var ls = this.obtenerListaPorNombre(nombreActual);
                eliminar(nombreActual);

                if(ls != null)
                {
                    ls.setNombre(nombreNuevo);
                    return agregar(ls);
                }
                
            }
            return false;
        }

        public bool modificar(ListaReproduccion obj, string nombre)
        {
            if (eliminar(obj)) {
                obj.setNombre(nombre);
                this.agregar(obj);
                return true;
            }

            return false;
        }

        public int obtenerCantidadDeElementos(ListaReproduccion obj)
        {
            return obj.getCantidad();
        }

        public ListaReproduccion obtenerListaPorID(int i)
        {
            return this.listas.ElementAt(i);
        }

        public ListaReproduccion obtenerListaPorNombre(string nombre)
        {
            foreach(ListaReproduccion ls in listas)
            {
                if (nombre.Equals(ls.getNombre()))
                {
                    return ls;
                }
            }
            return null;
        }

        public string[] obtenerTodaLaLista()
        {
            string[] listas = new string[this.listas.Count];
            List<ListaReproduccion> ls = new List<ListaReproduccion>();
            for(int i = 0; i < this.listas.Count; i++)
            {
                ListaReproduccion l = this.listas.ElementAt(i);
                if (l is ListaMusica)
                {
                    listas[i] = l.getNombre() + "-Musica";
                } else if (l is ListaVideo)
                {
                    listas[i] = l.getNombre() + "-Video";
                }
            }
            return listas;
        }

        public bool verificarExistencia(string nombre)
        {
            foreach(ListaReproduccion ls in listas)
            {
                if (nombre.Equals(ls.getNombre()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool verificarExistencia(ListaReproduccion obj)
        {
            foreach(ListaReproduccion ls in listas)
            {
                if (obj.getNombre().Equals(ls.getNombre()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool verificarExistencia(ListaReproduccion obj, string nombre)
        {
            return verificarExistencia(obj) && verificarExistencia(nombre);
        }
    }
}
