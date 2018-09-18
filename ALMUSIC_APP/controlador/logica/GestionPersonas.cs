using ALMUSIC_APP.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.controlador.logica
{
    public class GestionPersonas
    {
        private Artista artista;
        private Usuario usuario;
        private List<Persona> personas;

        public GestionPersonas()
        {
            personas = new List<Persona>();

        }

        public bool agregarArtista(String nombre)
        {
            if (!this.verificarExistencia(nombre)) {
                if(nombre != null)
                {
                    Persona p = new Artista(nombre);
                    personas.Add(p);
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }

        }

        public bool verificarExistencia(string nombre)
        {
            foreach(Persona p in personas) {
                if(p is Artista)
                {
                    Artista a = (Artista)p;
                    if (a.getNombre().Equals(nombre))
                    {
                        return true;//DEVUELVE VERDADERO SI ENCUENTRA UN ARTISTA CON EL MISMO NOMBRE
                    }
                }
            }
            return false;

        }

        public string[] obtenerTodosLosArtistas() {

            List<Artista> artistas = new List<Artista>();
            string[] arrayartistas;
            foreach(Persona p in personas)
            {
                if(p is Artista){
                    artistas.Add((Artista)p);
                }
            }
            arrayartistas = new string[artistas.Count];
            for(int i = 0; i < arrayartistas.Length; i++)
            {
                arrayartistas[i] = artistas.ElementAt(i).getNombre();
            }


            return arrayartistas;
        }

        public bool estaListaArtistaVacia()
        {
            int cantArtistas = 0;
            foreach (Persona p in personas)
            {
                if (p is Artista)
                {
                    cantArtistas++;
                }
            }
            if(cantArtistas > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

}
