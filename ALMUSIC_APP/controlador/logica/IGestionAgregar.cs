using ALMUSIC_APP.modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.controlador.logica
{
    public interface IGestionAgregar<ListaMusica, ListaVideo, ListaReproduccion, Musica, Video>
    {
        bool agregar(ListaReproduccion obj);
        bool agregar(ListaReproduccion obj, List<Musica> canciones);
        ListaReproduccion agregarDatos(string nombre, Musica musica);
        ListaReproduccion agregarDatos(string nombre, Video video);
        bool eliminar(ListaReproduccion obj);
        bool eliminar(string nombreActual);
        bool modificar(string nombreActual, string nombreNuevo);
        bool modificar(ListaReproduccion obj, string nombre);
        int obtenerCantidadDeElementos(ListaReproduccion obj);
        bool verificarExistencia(ListaReproduccion obj);
        bool verificarExistencia(ListaReproduccion obj, string nombre);
        bool verificarExistencia(string nombre);
        string[] obtenerTodaLaLista();
        ListaReproduccion obtenerListaPorID(int i);
        ListaReproduccion obtenerListaPorNombre(string nombre);

    }
}
